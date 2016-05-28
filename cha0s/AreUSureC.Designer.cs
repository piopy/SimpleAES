namespace cha0s
{
    partial class AreYouUSureD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreYouUSureD));
            this.y = new System.Windows.Forms.Button();
            this.n = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // y
            // 
            this.y.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.y.Location = new System.Drawing.Point(31, 116);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(75, 23);
            this.y.TabIndex = 2;
            this.y.Text = "Yes";
            this.y.UseVisualStyleBackColor = true;
            // 
            // n
            // 
            this.n.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.n.Location = new System.Drawing.Point(113, 116);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(75, 23);
            this.n.TabIndex = 3;
            this.n.Text = "No";
            this.n.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Are you sure you wanna proceed?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "The program is going to crypt your file";
            // 
            // AreYouUSureD
            // 
            this.AcceptButton = this.y;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.n;
            this.ClientSize = new System.Drawing.Size(217, 151);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.n);
            this.Controls.Add(this.y);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(233, 190);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(233, 190);
            this.Name = "AreYouUSureD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button y;
        private System.Windows.Forms.Button n;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}