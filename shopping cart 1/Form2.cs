using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace shopping_cart_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string connString = @"Server=DESKTOP-RP8M6HR\SQLEXPRESS;Database=YummyYummyDB;Trusted_Connection=True;TrustServerCertificate=True;";

            // ២. ពិនិត្យមើលបើបុគ្គលិកមិនទាន់បានវាយអក្សរចូល
            if (string.IsNullOrEmpty(SunnyTxtUsername.Text) || string.IsNullOrEmpty(SunnyTxtPassword.Text))
            {
                MessageBox.Show("សូមបញ្ចូល Username និង Password ឱ្យបានត្រឹមត្រូវ!", "ព្រមាន", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    // ៣. សរសេរកូដ SQL ដើម្បីស្វែងរកគណនីបុគ្គលិក
                    string loginQuery = "SELECT UserID FROM Users WHERE Username = @User AND Password = @Pass;";

                    using (SqlCommand cmd = new SqlCommand(loginQuery, conn))
                    {
                        // ដូរឈ្មោះ txtUsername និង txtPassword ទៅតាម Textbox ជាក់ស្ដែងរបស់ប្អូន
                        cmd.Parameters.AddWithValue("@User", SunnyTxtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@Pass", SunnyTxtPassword.Text.Trim());

                        // ដំណើរការស្វែងរកទិន្នន័យ
                        object result = cmd.ExecuteScalar();

                        if (result != null) // បើរកឃើញទិន្នន័យ (មានន័យថា Username & Password ត្រូវ)
                        {
                            int loggedInUserID = Convert.ToInt32(result);
                            MessageBox.Show("ស្វាគមន៍ការចូលមកកាន់ប្រព័ន្ធលក់ YummyYummy POS!", "ជោគជ័យ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // ៤. បើកផ្ទាំងលក់ចម្បង (Form1) រួចបិទផ្ទាំង Login នេះចោល
                            Form1 mainForm = new Form1();
                            mainForm.Show();
                            this.Hide(); // លាក់ផ្ទាំង Login នេះទុក
                        }
                        else // បើរកមិនឃើញ (Username ឬ Password ខុស)
                        {
                            MessageBox.Show("Username ឬ Password មិនត្រឹមត្រូវឡើយ! សូមពិនិត្យឡើងវិញ។", "កំហុស", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            SunnyTxtPassword.Clear();
                            SunnyTxtUsername.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("មានបញ្ហាភ្ជាប់ទៅកាន់ Database៖ " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
