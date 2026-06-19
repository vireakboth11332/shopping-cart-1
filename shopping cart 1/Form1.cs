using System.Data;

namespace shopping_cart_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            // បង្កើត DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Item");
            dt.Columns.Add("Price");
            dt.Columns.Add("Qty");
            dt.Columns.Add("Total");

            // បន្ថែម Sample Data
            dt.Rows.Add("Burger", 5.00, 2, 10.00);
            dt.Rows.Add("Pizza", 8.00, 1, 8.00);
            dt.Rows.Add("Coke", 1.50, 3, 4.50);

            // Bind ទៅ DataGridView
            dataGridView1.AutoGenerateColumns = true; // បើអ្នកចង់ឲ្យ Column បង្កើតដោយ DataSource
            dataGridView1.DataSource = dt;
        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void Food_Enter(object sender, EventArgs e)
        {

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
    }

}
