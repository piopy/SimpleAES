namespace cha0s
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.TextBox();
            this.cry = new System.Windows.Forms.Button();
            this.t1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.TextBox();
            this.dec = new System.Windows.Forms.Button();
            this.t2 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.p1);
            this.groupBox1.Controls.Add(this.cry);
            this.groupBox1.Controls.Add(this.t1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crypt";
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(224, 18);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(32, 23);
            this.b1.TabIndex = 4;
            this.b1.Text = "...";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // p1
            // 
            this.p1.Enabled = false;
            this.p1.Location = new System.Drawing.Point(345, 19);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(120, 20);
            this.p1.TabIndex = 2;
            this.p1.UseSystemPasswordChar = true;
            // 
            // cry
            // 
            this.cry.Location = new System.Drawing.Point(471, 17);
            this.cry.Name = "cry";
            this.cry.Size = new System.Drawing.Size(75, 23);
            this.cry.TabIndex = 1;
            this.cry.Text = "Start";
            this.cry.UseVisualStyleBackColor = true;
            this.cry.Click += new System.EventHandler(this.button1_Click);
            // 
            // t1
            // 
            this.t1.Enabled = false;
            this.t1.Location = new System.Drawing.Point(6, 19);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(212, 20);
            this.t1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.p2);
            this.groupBox2.Controls.Add(this.dec);
            this.groupBox2.Controls.Add(this.t2);
            this.groupBox2.Location = new System.Drawing.Point(13, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 56);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decrypt";
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(224, 18);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(32, 23);
            this.b2.TabIndex = 4;
            this.b2.Text = "...";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // p2
            // 
            this.p2.Enabled = false;
            this.p2.Location = new System.Drawing.Point(345, 19);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(120, 20);
            this.p2.TabIndex = 2;
            this.p2.UseSystemPasswordChar = true;
            // 
            // dec
            // 
            this.dec.Location = new System.Drawing.Point(471, 17);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(75, 23);
            this.dec.TabIndex = 1;
            this.dec.Text = "Start";
            this.dec.UseVisualStyleBackColor = true;
            this.dec.Click += new System.EventHandler(this.button4_Click);
            // 
            // t2
            // 
            this.t2.Enabled = false;
            this.t2.Location = new System.Drawing.Point(6, 19);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(212, 20);
            this.t2.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 138);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(225, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "by BurningHAM, Copyright 2016, GPL License";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 163);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 202);
            this.MinimumSize = new System.Drawing.Size(600, 202);
            this.Name = "MainForm";
            this.Text = "cha0s";
            this.Load += new System.EventHandler(this.onload);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.Button cry;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox p2;
        private System.Windows.Forms.Button dec;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

