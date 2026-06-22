using Microsoft.Data.SqlClient;
using System.Data;

namespace shopping_cart_1
{
    public partial class Form1 : Form
    {
  
        private readonly string _connString = @"Server=DESKTOP-RP8M6HR\\SQLEXPRESS;Database=YummyYummyDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            // Ensure theme applied after all runtime rendering is ready
            ApplyModernTheme();
        }

        private int GetOrCreateUserId(SqlConnection conn, SqlTransaction tran, string username)
        {
            if (string.IsNullOrWhiteSpace(username)) username = "guest";

            
            using (SqlCommand cmd = new SqlCommand("SELECT UserID FROM Users WHERE Username = @Username", conn, tran))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
            }

            
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Users (Username) VALUES (@Username); SELECT SCOPE_IDENTITY();", conn, tran))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                object inserted = cmd.ExecuteScalar();
                return Convert.ToInt32(inserted);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
            dataGridViewCart.Rows.Clear();
            label31.Text = "$0.00"; 
            label30.Text = "$0.00"; 
            label32.Text = "$0.00"; 
            CboPaymentMethod.Items.Clear();
            CboPaymentMethod.Items.AddRange(new object[] { "Cash", "Card", "Mobile Payment" });
            CboPaymentMethod.SelectedIndex = -1;

            
            ApplyModernTheme();

            
            CalculateInvoiceTotal();
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            string connString = @"Server=DESKTOP-RP8M6HR\SQLEXPRESS;Database=YummyYummyDB;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    
                    string insertOrderQuery = @"INSERT INTO Orders (SubTotal, Tax, TotalAmount, UserID) 
                                       VALUES (@SubTotal, @Tax, @TotalAmount, @UserID);
                                       SELECT SCOPE_IDENTITY();"; 

                    int newOrderID = 0;
                    using (SqlCommand cmd = new SqlCommand(insertOrderQuery, conn))
                    {
                       
                        cmd.Parameters.AddWithValue("@SubTotal", Convert.ToDecimal(label31.Text.Replace("$", "")));
                        cmd.Parameters.AddWithValue("@Tax", Convert.ToDecimal(label30.Text.Replace("$", "")));
                        cmd.Parameters.AddWithValue("@TotalAmount", Convert.ToDecimal(label32.Text.Replace("$", "")));
                        cmd.Parameters.AddWithValue("@UserID", 1); 

                        newOrderID = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                  
                    foreach (DataGridViewRow row in dataGridViewCart.Rows)
                    {
                        if (row.Cells["Item"].Value != null)
                        {
                            string insertDetailQuery = @"INSERT INTO OrderDetails (OrderID, ItemName, Price, Qty, Total) 
                                                 VALUES (@OrderID, @ItemName, @Price, @Qty, @Total);";

                            using (SqlCommand cmdDetail = new SqlCommand(insertDetailQuery, conn))
                            {
                                cmdDetail.Parameters.AddWithValue("@OrderID", newOrderID);
                                cmdDetail.Parameters.AddWithValue("@ItemName", row.Cells["Item"].Value.ToString());
                                cmdDetail.Parameters.AddWithValue("@Price", Convert.ToDecimal(row.Cells["Price"].Value));
                                cmdDetail.Parameters.AddWithValue("@Qty", Convert.ToInt32(row.Cells["Qty"].Value));
                                cmdDetail.Parameters.AddWithValue("@Total", Convert.ToDecimal(row.Cells["Total"].Value));

                                cmdDetail.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show("ការទូទាត់ប្រាក់ជោគជ័យ និងបានរក្សាទុកក្នុង Database រួចរាល់!", "ជោគជ័យ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    dataGridViewCart.Rows.Clear();
                   
                    CalculateInvoiceTotal();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("មានបញ្ហាភ្ជាប់ទៅកាន់ Database៖ " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Food_Enter(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string itemName = "";
            decimal price = 0;

            
            if (clickedButton.Name == "btnAddBurger") { itemName = "Burger"; price = 5.00m; }
            else if (clickedButton.Name == "btnAddPizza") { itemName = "Pizza"; price = 10.99m; }
            else if (clickedButton.Name == "btnAddHotdog") { itemName = "Hotdog"; price = 2.00m; }
            else if (clickedButton.Name == "btnAddSandwich") { itemName = "Sandwich"; price = 1.00m; }
            else if (clickedButton.Name == "btnAddFries") { itemName = "Fries"; price = 2.00m; }
            else if (clickedButton.Name == "btnAddChicken") { itemName = "Fries Chicken"; price = 3.00m; }
            else if (clickedButton.Name == "btnAddSushi") { itemName = "Sushi"; price = 15.00m; }
            else if (clickedButton.Name == "btnAddSalad") { itemName = "Salad"; price = 1.00m; }
            else if (clickedButton.Name == "btnAddSpaghetti") { itemName = "Spaghetti"; price = 2.00m; }

            int qty = 1;
            decimal total = price * qty;

            dataGridViewCart.Rows.Add(itemName, price, qty, total);

            
            CalculateInvoiceTotal();
        }

        
        private void AddItem_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                string itemName = "";
                decimal price = 0m;

              
                switch (clickedButton.Name)
                {
                    case "button1": itemName = "Burger"; price = 5.00m; break;
                    case "button2": itemName = "Pizza"; price = 10.99m; break;
                    case "button3": itemName = "Hotdog"; price = 2.00m; break;
                    case "button4": itemName = "Sandwich"; price = 1.00m; break;
                    case "button5": itemName = "Fries"; price = 2.00m; break;
                    case "button6": itemName = "Fries Chicken"; price = 3.00m; break;
                    case "button7": itemName = "Sushi"; price = 15.00m; break;
                    case "button10": itemName = "Noodle"; price = 2.00m; break;
                    case "button11": itemName = "Taco"; price = 1.00m; break;
                    case "button12": itemName = "Steak"; price = 5.00m; break;

                    case "button24": itemName = "CocaCola"; price = 1.00m; break;
                    case "button23": itemName = "Capuccino"; price = 1.50m; break;
                    case "button22": itemName = "Orange Juice"; price = 1.00m; break;
                    case "button21": itemName = "Smoothie"; price = 1.00m; break;
                    case "button20": itemName = "GreenTea"; price = 1.00m; break;
                    case "button19": itemName = "Water"; price = 0.25m; break;
                    case "button18": itemName = "Matcha"; price = 2.00m; break;
                    case "button17": itemName = "LemonTea"; price = 1.00m; break;
                    case "button16": itemName = "Hot Chocolate"; price = 2.00m; break;
                    case "button15": itemName = "Energy Drink"; price = 1.00m; break;
                    case "button14": itemName = "Beer"; price = 2.00m; break;
                    case "button13": itemName = "Wine"; price = 25.00m; break;
                    default:
                        
                        return;
                }

                int qty = 1;
                decimal total = price * qty;

                dataGridViewCart.Rows.Add(itemName, price, qty, total);
                CalculateInvoiceTotal();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void CalculateInvoiceTotal()
        {
            decimal subTotal = 0;

            
            foreach (DataGridViewRow row in dataGridViewCart.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    subTotal += Convert.ToDecimal(row.Cells[3].Value);
                }
            }

            decimal tax = subTotal * 0.10m; 
            decimal totalAmount = subTotal + tax;

            
            label31.Text = "$" + subTotal.ToString("N2");
            label30.Text = "$" + tax.ToString("N2");
            label32.Text = "$" + totalAmount.ToString("N2");

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            dataGridViewCart.Rows.Clear();
            TxtCustomerName.Clear();
            CboPaymentMethod.SelectedIndex = -1; 

            
            label31.Text = "$0.00";
            label30.Text = "$0.00";
            label32.Text = "$0.00";

          
            CalculateInvoiceTotal();

            MessageBox.Show("បានបង្កើតការកុម្មង់ថ្មីរួចរាល់!", "YummyYummy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDiscount_Click(object sender, EventArgs e)
        {
            
            string input = Microsoft.VisualBasic.Interaction.InputBox("សូមបញ្ចូលចំនួនទឹកប្រាក់ដែលត្រូវដកតម្លៃ ($) :", "Discount", "0.00");

            if (decimal.TryParse(input, out decimal discountAmount))
            {
               
                decimal currentTotal = Convert.ToDecimal(label32.Text.Replace("$", ""));

                if (discountAmount <= currentTotal)
                {
                    decimal finalTotal = currentTotal - discountAmount;

                  
                    label32.Text = "$" + finalTotal.ToString("N2");
                    MessageBox.Show($"បានបញ្ចុះតម្លៃជូនចំនួន ${discountAmount.ToString("N2")} រួចរាល់!", "Discount Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ចំនួនលុយ Discount មិនអាចធំជាងលុយសរុបឡើយ!", "កំហុស", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnPrintReceipt_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.Rows.Count == 0)
            {
                MessageBox.Show("មិនទាន់មានមុខម្ហូបក្នុងតារាងសម្រាប់បោះពុម្ភឡើយ!", "ព្រមាន", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string receipt = "======= YUMMY YUMMY RECEIPT =======\n";
            receipt += $"Customer: {TxtCustomerName.Text}\n";
            receipt += $"Payment: {CboPaymentMethod.Text}\n"; // ប្រើប្រាស់ Text ពី ComboBox
            receipt += "-----------------------------------\n";
            receipt += "Item\t\tQty\tTotal\n";
            receipt += "-----------------------------------\n";

            foreach (DataGridViewRow row in dataGridViewCart.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    receipt += $"{row.Cells[0].Value}\t{row.Cells[2].Value}\t${row.Cells[3].Value}\n";
                }
            }

            receipt += "-----------------------------------\n";
            receipt += $"SubTotal: {label31.Text}\n";
            receipt += $"Tax (10%): {label30.Text}\n";
            receipt += $"Grand Total: {label32.Text}\n";
            receipt += "===================================\n";
            receipt += "Thank you for supporting us!";

            MessageBox.Show(receipt, "Print Receipt Preview", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void ApplyModernTheme()
        {
            try
            {
             
                Color primary = Color.FromArgb(33, 150, 243); // blue
                Color accent = Color.FromArgb(25, 118, 210);
                Color background = Color.FromArgb(245, 245, 245);
                Color panelBack = Color.White;

                this.BackColor = background;
                this.Font = new Font("Segoe UI", 9F);

                // Style buttons throughout the form
                foreach (Control c in this.Controls)
                {
                    StyleControlRecursive(c, primary, accent, panelBack);
                }
            }
            catch
            {
                // Ignore theme errors
            }
        }

        private void StyleControlRecursive(Control control, Color primary, Color accent, Color panelBack)
        {
            if (control is Button btn)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = primary;
                btn.UseVisualStyleBackColor = false;
                btn.ForeColor = Color.White;
                btn.Font = new Font(btn.Font.FontFamily, 9F, FontStyle.Bold);
            }
            else if (control is Panel pnl)
            {
                pnl.BackColor = panelBack;
            }
            else if (control is GroupBox gb)
            {
                gb.ForeColor = primary;
                gb.BackColor = Color.Transparent;
            }

            if (control is DataGridView grid)
            {
                grid.EnableHeadersVisualStyles = false;
                grid.BackgroundColor = Color.White;
                grid.BorderStyle = BorderStyle.None;
                grid.ColumnHeadersDefaultCellStyle.BackColor = primary;
                grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                grid.ColumnHeadersDefaultCellStyle.Font = new Font(grid.Font, FontStyle.Bold);
                grid.RowHeadersVisible = false;
                grid.DefaultCellStyle.SelectionBackColor = Color.LightGray;
                grid.DefaultCellStyle.SelectionForeColor = Color.Black;
            }

            if (control is Label lbl)
            {
                // keep label color neutral but readable
                lbl.ForeColor = Color.FromArgb(33, 33, 33);
            }

            if (control is TextBox tb)
            {
                tb.BackColor = Color.White;
                tb.BorderStyle = BorderStyle.FixedSingle;
            }

            if (control is ComboBox cb)
            {
                cb.BackColor = Color.White;
            }

            // Recurse into child controls
            foreach (Control child in control.Controls)
            {
                StyleControlRecursive(child, primary, accent, panelBack);
            }
        }
    }
}
    


