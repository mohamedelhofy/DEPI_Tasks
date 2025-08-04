namespace MyFirstWinFormApp
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            buavtton1 = new Button();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            lblStatus = new Label();
            groupBox2 = new GroupBox();
            Handball = new CheckBox();
            checkBox2 = new CheckBox();
            Robotics = new CheckBox();
            checkBox1 = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            progressBar1 = new ProgressBar();
            Report = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            pageSetupDialog1 = new PageSetupDialog();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            Report.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(13, 4, 0, 4);
            menuStrip1.Size = new Size(1734, 53);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, newToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(87, 45);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(258, 54);
            openToolStripMenuItem.Text = "Open";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(258, 54);
            newToolStripMenuItem.Text = "New";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(255, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(258, 54);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // buavtton1
            // 
            buavtton1.Location = new Point(244, 935);
            buavtton1.Margin = new Padding(6);
            buavtton1.Name = "buavtton1";
            buavtton1.Size = new Size(319, 80);
            buavtton1.TabIndex = 1;
            buavtton1.Text = "show result";
            buavtton1.UseVisualStyleBackColor = true;
            buavtton1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 92);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 41);
            label1.TabIndex = 2;
            label1.Text = "Name :";
            // 
            // txtName
            // 
            txtName.Location = new Point(244, 86);
            txtName.Margin = new Padding(6);
            txtName.Name = "txtName";
            txtName.Size = new Size(527, 47);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 162);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(188, 41);
            label2.TabIndex = 4;
            label2.Text = "DateOfBirth :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(244, 156);
            dateTimePicker1.Margin = new Padding(6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(527, 47);
            dateTimePicker1.TabIndex = 5;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(98, 88);
            radioButton1.Margin = new Padding(6);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(119, 45);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "male";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(434, 88);
            radioButton2.Margin = new Padding(6);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(144, 45);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(26, 223);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(750, 199);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gender";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "أعزب", "متنزوج", "أومل" });
            comboBox1.Location = new Point(227, 449);
            comboBox1.Margin = new Padding(6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(544, 49);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(70, 455);
            lblStatus.Margin = new Padding(6, 0, 6, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(98, 41);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "Status";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Handball);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(Robotics);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Location = new Point(70, 547);
            groupBox2.Margin = new Padding(6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6);
            groupBox2.Size = new Size(717, 220);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Habites";
            // 
            // Handball
            // 
            Handball.AutoSize = true;
            Handball.Location = new Point(53, 129);
            Handball.Name = "Handball";
            Handball.Size = new Size(174, 45);
            Handball.TabIndex = 18;
            Handball.Text = "Handball";
            Handball.UseVisualStyleBackColor = true;
            Handball.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(361, 53);
            checkBox2.Margin = new Padding(6);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(238, 45);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Programming";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // Robotics
            // 
            Robotics.AutoSize = true;
            Robotics.Location = new Point(361, 129);
            Robotics.Name = "Robotics";
            Robotics.Size = new Size(171, 45);
            Robotics.TabIndex = 17;
            Robotics.Text = "Robotics";
            Robotics.UseVisualStyleBackColor = true;
            Robotics.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(53, 53);
            checkBox1.Margin = new Padding(6);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(198, 45);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Read Book";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(142, 779);
            numericUpDown1.Margin = new Padding(6);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(142, 47);
            numericUpDown1.TabIndex = 13;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 785);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 41);
            label4.TabIndex = 14;
            label4.Text = "C# : ";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(298, 779);
            progressBar1.Margin = new Padding(6);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(478, 55);
            progressBar1.TabIndex = 15;
            progressBar1.Click += progressBar1_Click;
            // 
            // Report
            // 
            Report.Controls.Add(button4);
            Report.Controls.Add(button3);
            Report.Controls.Add(button2);
            Report.Controls.Add(richTextBox1);
            Report.Location = new Point(844, 86);
            Report.Margin = new Padding(6);
            Report.Name = "Report";
            Report.Padding = new Padding(6);
            Report.Size = new Size(880, 968);
            Report.TabIndex = 16;
            Report.TabStop = false;
            Report.Text = "Report";
            // 
            // button4
            // 
            button4.Location = new Point(635, 869);
            button4.Margin = new Padding(6);
            button4.Name = "button4";
            button4.Size = new Size(200, 59);
            button4.TabIndex = 3;
            button4.Text = "Print";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(334, 869);
            button3.Margin = new Padding(6);
            button3.Name = "button3";
            button3.Size = new Size(200, 59);
            button3.TabIndex = 2;
            button3.Text = "Preview";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(32, 869);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(200, 59);
            button2.TabIndex = 1;
            button2.Text = "Page Setup";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(32, 53);
            richTextBox1.Margin = new Padding(6);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(799, 783);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1734, 1110);
            Controls.Add(Report);
            Controls.Add(progressBar1);
            Controls.Add(label4);
            Controls.Add(numericUpDown1);
            Controls.Add(groupBox2);
            Controls.Add(lblStatus);
            Controls.Add(comboBox1);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(buavtton1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6);
            MaximizeBox = false;
            Name = "MainFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Application ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            Report.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button buavtton1;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label lblStatus;
        private GroupBox groupBox2;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private ProgressBar progressBar1;
        private GroupBox Report;
        private Button button4;
        private Button button3;
        private Button button2;
        private RichTextBox richTextBox1;
        private PageSetupDialog pageSetupDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private CheckBox Robotics;
        private CheckBox Handball;
    }
}