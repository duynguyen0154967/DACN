using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Diagnostics;

namespace QL_Bansim
{

    public partial class frmdangky : Form
    {
        string connectionString = @"Data Source=DESKTOP-OF9SSIR;Initial Catalog=QL_BanSim;Integrated Security=True;";
        public frmdangky()
        {
            InitializeComponent();
        }

        private void frmdangky_Load(object sender, EventArgs e)
        {

        }


        private void btndangky_Click(object sender, EventArgs e)
        {
            
            if (txtdangkytk.Text == "" || txtdangkymk.Text == "")
                MessageBox.Show("Vui lòng nhập thông tin đầy  đủ");
            else if (txtdangkymk.Text != txtnhaplaimk.Text)
                MessageBox.Show("Mật khẩu sai");
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand("Useradd2", sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@UserName", txtdangkytk.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@Password", txtdangkymk.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@Ten", txtTen.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Đăng ký thành công");
                    
                    clear();
                }
            }
           
            
        }
        
        
          
        
        void clear()
        {
            txtdangkymk.Text = txtdangkytk.Text =txtDiaChi.Text=txtnhaplaimk.Text=txtTen.Text ="";
        }
    }
}
