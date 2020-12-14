using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class frmdangnhap : Form
    {
        //Khai báo đối tượng Commonconnect
        
        //Khai báo đối tượng SqlConnection
        
        public static string ID_USER = "";
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void frmdangnhap_Load(object sender, EventArgs e)
        {
        }
        SqlConnection con = new SqlConnection(@"Data Source=WIN7-PC\SQLEXPRESS;Initial Catalog=QL_BanSim;Integrated Security=True");
        private string getID(string username, string pass)
        {
            string id = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from  UserSystem where UserName='" + username + "' and Password='" + pass + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["UserName"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                con.Close();
            }
            return id;
        }
        private void btndn_Click(object sender, EventArgs e)
        {
            ID_USER = getID(txttendn.Text, txtpw.Text);
         
             if (ID_USER != "")
             {
                 frmmain fmain = new frmmain();
                 fmain.Show();
                 this.Hide();
             }
             else
             {
                 MessageBox.Show("Tài khoản và mật khẩu không đúng !");
             }
            


        }

        private void txttendn_Enter(object sender, EventArgs e)
        {
            if (txttendn.Text == "TÊN TÀI KHOẢN")
            {
                txttendn.Text = "";
                txttendn.ForeColor = Color.Black;
            }
        }

        private void txttendn_Leave(object sender, EventArgs e)
        {
            if (txttendn.Text == "")
            {
                txttendn.Text = "TÊN TÀI KHOẢN";
                txttendn.ForeColor = Color.Silver;
            }
        }

        private void txtpw_Enter(object sender, EventArgs e)
        {
            if (txtpw.Text == "MẬT KHẨU")
            {
                txtpw.Text = "";
                txtpw.ForeColor = Color.Black;
            }
        }

        private void txtpw_Leave(object sender, EventArgs e)
        {
            if (txtpw.Text == "")
            {
                txtpw.Text = "MẬT KHẨU";
                txtpw.ForeColor = Color.Silver;
            }
        }
        
      
    }
 }
    

