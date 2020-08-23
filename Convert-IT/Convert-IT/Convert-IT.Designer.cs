namespace Convert_IT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Filetypes = new System.Windows.Forms.ComboBox();
            this.to_text = new System.Windows.Forms.Label();
            this.userfile = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.Convert_Screen = new System.Windows.Forms.Panel();
            this.Download_Panel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Download_Contents = new System.Windows.Forms.Panel();
            this.Download_Name = new System.Windows.Forms.Label();
            this.Download = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Home.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Convert_Screen.SuspendLayout();
            this.Download_Panel.SuspendLayout();
            this.Download_Contents.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Roboto", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Converter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Home
            // 
            this.Home.Controls.Add(this.button1);
            this.Home.Controls.Add(this.label1);
            this.Home.Location = new System.Drawing.Point(12, 9);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(951, 636);
            this.Home.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(307, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 82);
            this.button1.TabIndex = 15;
            this.button1.Text = "Choose Files";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Roboto", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(350, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "File Converter";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Filetypes);
            this.panel1.Controls.Add(this.to_text);
            this.panel1.Controls.Add(this.userfile);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(21, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 69);
            this.panel1.TabIndex = 2;
            // 
            // Filetypes
            // 
            this.Filetypes.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.Filetypes.FormattingEnabled = true;
            this.Filetypes.Items.AddRange(new object[] {
            "JPG",
            "PNG",
            "GIF",
            "ICO",
            "BMP"});
            this.Filetypes.Location = new System.Drawing.Point(431, 26);
            this.Filetypes.Name = "Filetypes";
            this.Filetypes.Size = new System.Drawing.Size(67, 33);
            this.Filetypes.TabIndex = 3;
            this.Filetypes.Text = "...";
            // 
            // to_text
            // 
            this.to_text.AutoSize = true;
            this.to_text.Location = new System.Drawing.Point(400, 29);
            this.to_text.Name = "to_text";
            this.to_text.Size = new System.Drawing.Size(27, 24);
            this.to_text.TabIndex = 1;
            this.to_text.Text = "to";
            // 
            // userfile
            // 
            this.userfile.AutoSize = true;
            this.userfile.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.userfile.Location = new System.Drawing.Point(24, 24);
            this.userfile.Name = "userfile";
            this.userfile.Size = new System.Drawing.Size(51, 26);
            this.userfile.TabIndex = 0;
            this.userfile.Text = "N/A";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.Location = new System.Drawing.Point(378, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(564, 61);
            this.button2.TabIndex = 3;
            this.button2.Text = "Convert";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.back_button.Location = new System.Drawing.Point(6, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(105, 42);
            this.back_button.TabIndex = 4;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Convert_Screen
            // 
            this.Convert_Screen.Controls.Add(this.back_button);
            this.Convert_Screen.Controls.Add(this.button2);
            this.Convert_Screen.Controls.Add(this.panel1);
            this.Convert_Screen.Controls.Add(this.label2);
            this.Convert_Screen.Location = new System.Drawing.Point(9, 9);
            this.Convert_Screen.Name = "Convert_Screen";
            this.Convert_Screen.Size = new System.Drawing.Size(951, 636);
            this.Convert_Screen.TabIndex = 2;
            this.Convert_Screen.Visible = false;
            this.Convert_Screen.Paint += new System.Windows.Forms.PaintEventHandler(this.Convert_Screen_Paint);
            // 
            // Download_Panel
            // 
            this.Download_Panel.Controls.Add(this.button4);
            this.Download_Panel.Controls.Add(this.label3);
            this.Download_Panel.Controls.Add(this.button3);
            this.Download_Panel.Controls.Add(this.Download_Contents);
            this.Download_Panel.Controls.Add(this.Back);
            this.Download_Panel.Location = new System.Drawing.Point(9, 9);
            this.Download_Panel.Name = "Download_Panel";
            this.Download_Panel.Size = new System.Drawing.Size(951, 636);
            this.Download_Panel.TabIndex = 3;
            this.Download_Panel.Visible = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(814, 594);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 39);
            this.button4.TabIndex = 4;
            this.button4.Text = "My Files";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(474, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Files will be stored for FOREVER . Go to My Files to delete them manually.";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(360, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(246, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Convert More Files";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Download_Contents
            // 
            this.Download_Contents.Controls.Add(this.Download_Name);
            this.Download_Contents.Controls.Add(this.Download);
            this.Download_Contents.Location = new System.Drawing.Point(6, 102);
            this.Download_Contents.Name = "Download_Contents";
            this.Download_Contents.Size = new System.Drawing.Size(936, 106);
            this.Download_Contents.TabIndex = 1;
            // 
            // Download_Name
            // 
            this.Download_Name.AutoSize = true;
            this.Download_Name.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Download_Name.Location = new System.Drawing.Point(64, 37);
            this.Download_Name.Name = "Download_Name";
            this.Download_Name.Size = new System.Drawing.Size(51, 26);
            this.Download_Name.TabIndex = 1;
            this.Download_Name.Text = "N/A";
            this.Download_Name.Click += new System.EventHandler(this.Download_Name_Click);
            // 
            // Download
            // 
            this.Download.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.Download.Location = new System.Drawing.Point(737, 29);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(148, 45);
            this.Download.TabIndex = 0;
            this.Download.Text = "Download";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.Back.Location = new System.Drawing.Point(4, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(117, 41);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 657);
            this.Controls.Add(this.Download_Panel);
            this.Controls.Add(this.Convert_Screen);
            this.Controls.Add(this.Home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Convert-IT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Convert_Screen.ResumeLayout(false);
            this.Convert_Screen.PerformLayout();
            this.Download_Panel.ResumeLayout(false);
            this.Download_Panel.PerformLayout();
            this.Download_Contents.ResumeLayout(false);
            this.Download_Contents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Home;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Filetypes;
        private System.Windows.Forms.Label to_text;
        private System.Windows.Forms.Label userfile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Panel Convert_Screen;
        private System.Windows.Forms.Panel Download_Panel;
        private System.Windows.Forms.Panel Download_Contents;
        private System.Windows.Forms.Label Download_Name;
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}

