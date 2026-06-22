namespace shopping_cart_1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            SunnyTxtPassword = new Sunny.UI.UIIPTextBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            BtnLogin = new Sunny.UI.UIButton();
            SunnyTxtUsername = new Sunny.UI.UIIPTextBox();
            uiButton1 = new Sunny.UI.UIButton();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(174, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 504);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(468, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(503, 504);
            panel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(50, 447);
            label3.Name = "label3";
            label3.Size = new Size(286, 22);
            label3.TabIndex = 8;
            label3.Text = "Don't have any account?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveBorder;
            label2.Location = new Point(43, 272);
            label2.Name = "label2";
            label2.Size = new Size(106, 22);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(40, 171);
            label1.Name = "label1";
            label1.Size = new Size(106, 22);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(SunnyTxtPassword);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(BtnLogin);
            panel4.Controls.Add(SunnyTxtUsername);
            panel4.Controls.Add(uiButton1);
            panel4.Controls.Add(pictureBox3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(503, 504);
            panel4.TabIndex = 0;
            // 
            // SunnyTxtPassword
            // 
            SunnyTxtPassword.FillColor2 = Color.FromArgb(235, 243, 255);
            SunnyTxtPassword.Font = new Font("Microsoft Sans Serif", 12F);
            SunnyTxtPassword.Location = new Point(42, 308);
            SunnyTxtPassword.Margin = new Padding(5, 7, 5, 7);
            SunnyTxtPassword.MinimumSize = new Size(1, 1);
            SunnyTxtPassword.Name = "SunnyTxtPassword";
            SunnyTxtPassword.Padding = new Padding(1);
            SunnyTxtPassword.ShowText = false;
            SunnyTxtPassword.Size = new Size(367, 48);
            SunnyTxtPassword.TabIndex = 8;
            SunnyTxtPassword.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Copilot_20260619_092507;
            pictureBox2.Location = new Point(139, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(168, 176);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 8F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(265, 373);
            label4.Name = "label4";
            label4.Size = new Size(144, 17);
            label4.TabIndex = 9;
            label4.Text = "Forgot Password ?";
            // 
            // BtnLogin
            // 
            BtnLogin.FillColor = Color.Blue;
            BtnLogin.Font = new Font("Microsoft Uighur", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogin.Location = new Point(42, 367);
            BtnLogin.Margin = new Padding(3, 4, 3, 4);
            BtnLogin.MinimumSize = new Size(1, 1);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(149, 47);
            BtnLogin.TabIndex = 9;
            BtnLogin.Text = "&Login";
            BtnLogin.TipsFont = new Font("Microsoft Sans Serif", 9F);
            BtnLogin.Click += BtnLogin_Click;
            // 
            // SunnyTxtUsername
            // 
            SunnyTxtUsername.FillColor2 = Color.FromArgb(235, 243, 255);
            SunnyTxtUsername.Font = new Font("Microsoft Sans Serif", 12F);
            SunnyTxtUsername.Location = new Point(42, 201);
            SunnyTxtUsername.Margin = new Padding(5, 7, 5, 7);
            SunnyTxtUsername.MinimumSize = new Size(1, 1);
            SunnyTxtUsername.Name = "SunnyTxtUsername";
            SunnyTxtUsername.Padding = new Padding(1);
            SunnyTxtUsername.ShowText = false;
            SunnyTxtUsername.Size = new Size(367, 48);
            SunnyTxtUsername.TabIndex = 7;
            SunnyTxtUsername.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiButton1
            // 
            uiButton1.FillColor = Color.White;
            uiButton1.Font = new Font("Microsoft Sans Serif", 12F);
            uiButton1.ForeColor = Color.Red;
            uiButton1.Location = new Point(329, 441);
            uiButton1.Margin = new Padding(3, 4, 3, 4);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.RectColor = Color.White;
            uiButton1.RectHoverColor = Color.White;
            uiButton1.RectPressColor = Color.FromArgb(128, 255, 255);
            uiButton1.RectSelectedColor = Color.Red;
            uiButton1.Size = new Size(114, 37);
            uiButton1.TabIndex = 6;
            uiButton1.Text = "&Sign In";
            uiButton1.TipsFont = new Font("Microsoft Sans Serif", 9F);
            uiButton1.TipsForeColor = Color.Transparent;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(255, 255, 128);
            pictureBox3.Image = Properties.Resources.images;
            pictureBox3.Location = new Point(458, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(469, 504);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Yellow;
            pictureBox1.Image = Properties.Resources.Copilot_20260619_103255_removebg_preview;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(469, 504);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1408, 675);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Login";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel4;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label3;
        private Sunny.UI.UIButton BtnLogin;
        private Sunny.UI.UIIPTextBox SunnyTxtUsername;
        private Sunny.UI.UIButton uiButton1;
        private Label label4;
        private Sunny.UI.UIIPTextBox SunnyTxtPassword;
    }
}