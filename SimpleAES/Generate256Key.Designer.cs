namespace SimpleAES
{
    partial class Generate256Key
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generate256Key));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clipboard = new System.Windows.Forms.Button();
            this.chiave = new System.Windows.Forms.TextBox();
            this.gen = new System.Windows.Forms.Button();
            this.orig = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 82);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.clipboard);
            this.tabPage1.Controls.Add(this.chiave);
            this.tabPage1.Controls.Add(this.gen);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 56);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Random";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.password);
            this.tabPage2.Controls.Add(this.orig);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 56);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sentence";
            // 
            // clipboard
            // 
            this.clipboard.Location = new System.Drawing.Point(465, 28);
            this.clipboard.Name = "clipboard";
            this.clipboard.Size = new System.Drawing.Size(103, 29);
            this.clipboard.TabIndex = 5;
            this.clipboard.Text = "Copy To Clipboard";
            this.clipboard.UseVisualStyleBackColor = true;
            this.clipboard.Click += new System.EventHandler(this.Clipboard_Click_1);
            // 
            // chiave
            // 
            this.chiave.Enabled = false;
            this.chiave.Location = new System.Drawing.Point(6, 17);
            this.chiave.Name = "chiave";
            this.chiave.ReadOnly = true;
            this.chiave.Size = new System.Drawing.Size(450, 20);
            this.chiave.TabIndex = 4;
            // 
            // gen
            // 
            this.gen.Location = new System.Drawing.Point(465, -1);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(103, 29);
            this.gen.TabIndex = 3;
            this.gen.Text = "Generate";
            this.gen.UseVisualStyleBackColor = true;
            this.gen.Click += new System.EventHandler(this.Gen_Click_1);
            // 
            // orig
            // 
            this.orig.Location = new System.Drawing.Point(9, 5);
            this.orig.Name = "orig";
            this.orig.Size = new System.Drawing.Size(439, 20);
            this.orig.TabIndex = 0;
            this.orig.TextChanged += new System.EventHandler(this.testocambiato);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(9, 30);
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Size = new System.Drawing.Size(439, 20);
            this.password.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Copy To Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Generate256Key
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 82);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 121);
            this.MinimumSize = new System.Drawing.Size(600, 121);
            this.Name = "Generate256Key";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generate256Key";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button clipboard;
        private System.Windows.Forms.TextBox chiave;
        private System.Windows.Forms.Button gen;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox orig;
        private System.Windows.Forms.Button button1;
    }
}