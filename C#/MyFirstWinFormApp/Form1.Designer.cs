namespace MyFirstWinFormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Login = new Button();
            txtUsername = new TextBox();
            UserName = new Label();
            Password = new Label();
            txtPassword = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Login
            // 
            Login.BackColor = Color.Snow;
            Login.Image = (Image)resources.GetObject("Login.Image");
            Login.ImageAlign = ContentAlignment.MiddleLeft;
            Login.Location = new Point(382, 279);
            Login.Margin = new Padding(6);
            Login.Name = "Login";
            Login.Size = new Size(206, 90);
            Login.TabIndex = 0;
            Login.Text = "Login";
            Login.TextAlign = ContentAlignment.MiddleRight;
            Login.UseVisualStyleBackColor = false;
            Login.Click += button1_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(225, 70);
            txtUsername.Margin = new Padding(6);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(567, 47);
            txtUsername.TabIndex = 1;
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Location = new Point(45, 76);
            UserName.Margin = new Padding(6, 0, 6, 0);
            UserName.Name = "UserName";
            UserName.Size = new Size(157, 41);
            UserName.TabIndex = 2;
            UserName.Text = "UserName";
            UserName.Click += label1_Click;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(51, 182);
            Password.Margin = new Padding(6, 0, 6, 0);
            Password.Name = "Password";
            Password.Size = new Size(143, 41);
            Password.TabIndex = 3;
            Password.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(227, 180);
            txtPassword.Margin = new Padding(6);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(565, 47);
            txtPassword.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(810, 70);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AcceptButton = Login;
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1024, 404);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword);
            Controls.Add(Password);
            Controls.Add(UserName);
            Controls.Add(txtUsername);
            Controls.Add(Login);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lock screen";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login;
        private TextBox txtUsername;
        private Label UserName;
        private Label Password;
        private TextBox txtPassword;
        private PictureBox pictureBox1;
    }
}
