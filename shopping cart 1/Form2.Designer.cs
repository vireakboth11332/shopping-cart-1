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
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            uiButton2 = new Sunny.UI.UIButton();
            uiipTextBox1 = new Sunny.UI.UIIPTextBox();
            uiButton1 = new Sunny.UI.UIButton();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            uiipTextBox2 = new Sunny.UI.UIIPTextBox();
            pictureBox6 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            uiipTextBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            uiipTextBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(152, 55);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 378);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(410, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(440, 378);
            panel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(44, 335);
            label3.Name = "label3";
            label3.Size = new Size(238, 18);
            label3.TabIndex = 8;
            label3.Text = "Don't have any account?";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Copilot_20260619_092507;
            pictureBox2.Location = new Point(129, 12);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(147, 132);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveBorder;
            label2.Location = new Point(38, 204);
            label2.Name = "label2";
            label2.Size = new Size(88, 18);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(35, 128);
            label1.Name = "label1";
            label1.Size = new Size(88, 18);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(uiipTextBox2);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(uiButton2);
            panel4.Controls.Add(uiipTextBox1);
            panel4.Controls.Add(uiButton1);
            panel4.Controls.Add(pictureBox3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(440, 378);
            panel4.TabIndex = 0;
            panel4.Paint += this.panel4_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 8F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(232, 280);
            label4.Name = "label4";
            label4.Size = new Size(126, 14);
            label4.TabIndex = 9;
            label4.Text = "Forgot Password ?";
            // 
            // uiButton2
            // 
            uiButton2.FillColor = Color.Blue;
            uiButton2.Font = new Font("Microsoft Uighur", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiButton2.Location = new Point(37, 275);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(130, 35);
            uiButton2.TabIndex = 9;
            uiButton2.Text = "&Login";
            uiButton2.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiipTextBox1
            // 
            uiipTextBox1.Controls.Add(pictureBox4);
            uiipTextBox1.FillColor2 = Color.FromArgb(235, 243, 255);
            uiipTextBox1.Font = new Font("Microsoft Sans Serif", 12F);
            uiipTextBox1.Location = new Point(37, 151);
            uiipTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiipTextBox1.MinimumSize = new Size(1, 1);
            uiipTextBox1.Name = "uiipTextBox1";
            uiipTextBox1.Padding = new Padding(1);
            uiipTextBox1.ShowText = false;
            uiipTextBox1.Size = new Size(321, 36);
            uiipTextBox1.TabIndex = 7;
            uiipTextBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiButton1
            // 
            uiButton1.FillColor = Color.White;
            uiButton1.Font = new Font("Microsoft Sans Serif", 12F);
            uiButton1.ForeColor = Color.Red;
            uiButton1.Location = new Point(288, 331);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.RectColor = Color.White;
            uiButton1.RectHoverColor = Color.White;
            uiButton1.RectPressColor = Color.FromArgb(128, 255, 255);
            uiButton1.RectSelectedColor = Color.Red;
            uiButton1.Size = new Size(100, 28);
            uiButton1.TabIndex = 6;
            uiButton1.Text = "&Sign In";
            uiButton1.TipsFont = new Font("Microsoft Sans Serif", 9F);
            uiButton1.TipsForeColor = Color.Transparent;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(255, 255, 128);
            pictureBox3.Image = Properties.Resources.images;
            pictureBox3.Location = new Point(401, 2);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(410, 378);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Yellow;
            pictureBox1.Image = Properties.Resources.Copilot_20260619_103255_removebg_preview;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 378);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = Properties.Resources.User_Female;
            pictureBox4.Location = new Point(280, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // uiipTextBox2
            // 
            uiipTextBox2.Controls.Add(pictureBox6);
            uiipTextBox2.FillColor2 = Color.FromArgb(235, 243, 255);
            uiipTextBox2.Font = new Font("Microsoft Sans Serif", 12F);
            uiipTextBox2.Location = new Point(37, 231);
            uiipTextBox2.Margin = new Padding(4, 5, 4, 5);
            uiipTextBox2.MinimumSize = new Size(1, 1);
            uiipTextBox2.Name = "uiipTextBox2";
            uiipTextBox2.Padding = new Padding(1);
            uiipTextBox2.ShowText = false;
            uiipTextBox2.Size = new Size(321, 36);
            uiipTextBox2.TabIndex = 8;
            uiipTextBox2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.Image = Properties.Resources.Key1;
            pictureBox6.Location = new Point(280, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(32, 32);
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1232, 506);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Login";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            uiipTextBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            uiipTextBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
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
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIIPTextBox uiipTextBox1;
        private Sunny.UI.UIButton uiButton1;
        private Label label4;
        private PictureBox pictureBox4;
        private Sunny.UI.UIIPTextBox uiipTextBox2;
        private PictureBox pictureBox6;
    }
}