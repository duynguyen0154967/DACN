namespace QL_Bansim
{
    partial class frmdangnhap
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
            this.btndn = new System.Windows.Forms.Button();
            this.txttendn = new System.Windows.Forms.TextBox();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btndn
            // 
            this.btndn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btndn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btndn.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndn.Location = new System.Drawing.Point(58, 186);
            this.btndn.Name = "btndn";
            this.btndn.Size = new System.Drawing.Size(118, 33);
            this.btndn.TabIndex = 3;
            this.btndn.Text = "Đăng Nhập";
            this.btndn.UseVisualStyleBackColor = false;
            this.btndn.Click += new System.EventHandler(this.btndn_Click);
            // 
            // txttendn
            // 
            this.txttendn.BackColor = System.Drawing.SystemColors.Control;
            this.txttendn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttendn.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txttendn.Location = new System.Drawing.Point(18, 65);
            this.txttendn.Name = "txttendn";
            this.txttendn.Size = new System.Drawing.Size(200, 26);
            this.txttendn.TabIndex = 1;
            this.txttendn.Text = "TÊN TÀI KHOẢN";
            this.txttendn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txttendn.Enter += new System.EventHandler(this.txttendn_Enter);
            this.txttendn.Leave += new System.EventHandler(this.txttendn_Leave);
            // 
            // txtpw
            // 
            this.txtpw.BackColor = System.Drawing.SystemColors.Control;
            this.txtpw.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpw.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtpw.Location = new System.Drawing.Point(18, 122);
            this.txtpw.Name = "txtpw";
            this.txtpw.PasswordChar = '*';
            this.txtpw.Size = new System.Drawing.Size(200, 26);
            this.txtpw.TabIndex = 2;
            this.txtpw.Text = "MẬT KHẨU";
            this.txtpw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpw.UseSystemPasswordChar = true;
            this.txtpw.Enter += new System.EventHandler(this.txtpw_Enter);
            this.txtpw.Leave += new System.EventHandler(this.txtpw_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "ĐĂNG NHẬP";
            // 
            // frmdangnhap
            // 
            this.AcceptButton = this.btndn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(233, 260);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.txttendn);
            this.Controls.Add(this.btndn);
            this.Name = "frmdangnhap";
            this.Text = "frmdangnhap";
            this.Load += new System.EventHandler(this.frmdangnhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndn;
        private System.Windows.Forms.TextBox txttendn;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.Label label3;
    }
}