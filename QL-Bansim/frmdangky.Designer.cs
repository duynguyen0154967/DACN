namespace QL_Bansim
{
    partial class frmdangky
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
            this.txtdangkytk = new System.Windows.Forms.TextBox();
            this.txtdangkymk = new System.Windows.Forms.TextBox();
            this.btndangky = new System.Windows.Forms.Button();
            this.txtnhaplaimk = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtdangkytk
            // 
            this.txtdangkytk.Location = new System.Drawing.Point(106, 53);
            this.txtdangkytk.Name = "txtdangkytk";
            this.txtdangkytk.Size = new System.Drawing.Size(100, 20);
            this.txtdangkytk.TabIndex = 0;
            // 
            // txtdangkymk
            // 
            this.txtdangkymk.Location = new System.Drawing.Point(106, 79);
            this.txtdangkymk.Name = "txtdangkymk";
            this.txtdangkymk.Size = new System.Drawing.Size(100, 20);
            this.txtdangkymk.TabIndex = 1;
            // 
            // btndangky
            // 
            this.btndangky.Location = new System.Drawing.Point(131, 205);
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(75, 23);
            this.btndangky.TabIndex = 2;
            this.btndangky.Text = "ĐĂNG KÝ";
            this.btndangky.UseVisualStyleBackColor = true;
            this.btndangky.Click += new System.EventHandler(this.btndangky_Click);
            // 
            // txtnhaplaimk
            // 
            this.txtnhaplaimk.Location = new System.Drawing.Point(106, 105);
            this.txtnhaplaimk.Name = "txtnhaplaimk";
            this.txtnhaplaimk.Size = new System.Drawing.Size(100, 20);
            this.txtnhaplaimk.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(106, 131);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 20);
            this.txtTen.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(106, 157);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 20);
            this.txtDiaChi.TabIndex = 5;
            // 
            // frmdangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtnhaplaimk);
            this.Controls.Add(this.btndangky);
            this.Controls.Add(this.txtdangkymk);
            this.Controls.Add(this.txtdangkytk);
            this.Name = "frmdangky";
            this.Text = "frmdangky";
            this.Load += new System.EventHandler(this.frmdangky_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdangkytk;
        private System.Windows.Forms.TextBox txtdangkymk;
        private System.Windows.Forms.Button btndangky;
        private System.Windows.Forms.TextBox txtnhaplaimk;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtDiaChi;
    }
}