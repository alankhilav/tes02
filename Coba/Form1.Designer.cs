namespace Coba
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
            this.btnKirim = new System.Windows.Forms.Button();
            this.tbPesan = new System.Windows.Forms.TextBox();
            this.rtbPesan = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnKirim
            // 
            this.btnKirim.Location = new System.Drawing.Point(197, 9);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(75, 23);
            this.btnKirim.TabIndex = 0;
            this.btnKirim.Text = "Kirim";
            this.btnKirim.UseVisualStyleBackColor = true;
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);
            // 
            // tbPesan
            // 
            this.tbPesan.Location = new System.Drawing.Point(12, 12);
            this.tbPesan.Name = "tbPesan";
            this.tbPesan.Size = new System.Drawing.Size(179, 20);
            this.tbPesan.TabIndex = 1;
            this.tbPesan.Enter += new System.EventHandler(this.btnKirim_Click);
            this.tbPesan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPesan_KeyDown);
            // 
            // rtbPesan
            // 
            this.rtbPesan.Location = new System.Drawing.Point(12, 50);
            this.rtbPesan.Name = "rtbPesan";
            this.rtbPesan.Size = new System.Drawing.Size(260, 200);
            this.rtbPesan.TabIndex = 2;
            this.rtbPesan.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rtbPesan);
            this.Controls.Add(this.tbPesan);
            this.Controls.Add(this.btnKirim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKirim;
        private System.Windows.Forms.TextBox tbPesan;
        private System.Windows.Forms.RichTextBox rtbPesan;
    }
}

