using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Bansim.khachhang
{
    public partial class frmkhachhang : Form
    {
        KhachhangCtrl khctrl = new KhachhangCtrl();
        int flag = 0;


        public frmkhachhang()
        {
            InitializeComponent();
        }

        private void frmkhachhang_Load(object sender, EventArgs e)
        {
            DataTable tbkhachhang = new DataTable();
            tbkhachhang = khctrl.GetData();
            dataGridView1.DataSource = tbkhachhang;
            bingding();
        }
        void bingding()
        {
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", dataGridView1.DataSource, "MaKH");
            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("Text", dataGridView1.DataSource, "TenKH");
            cbGioiTinh.DataBindings.Clear();
            cbGioiTinh.DataBindings.Add("Text", dataGridView1.DataSource, "GioiTinh");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dataGridView1.DataSource, "DiaChi");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dataGridView1.DataSource, "SDT");

        }
        void dis_end(bool e)
        {
            txtMaKH.Enabled = e;
            txtTenKH.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSDT.Enabled = e;
            cbGioiTinh.Enabled = e;
            btnHuy.Enabled = e;
            btnluu.Enabled = e;
            btnThem.Enabled = !e;
            btnxoa.Enabled = !e;
            btnsua.Enabled = !e;

        }

        private void clearData()
        {
            txtMaKH.Text = "";
            txtDiaChi.Text = "";
            // LoadcmbKhachHang();
            cbGioiTinh.Text = "";
            txtSDT.Text = "";
            txtTenKH.Text = "";
            
        }

      

       
        void loadcontrol()
        {
            cbGioiTinh.Items.Clear();
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
        }
        void gandulieu(ClassKhachhang kh)
        {
            kh.Ma = txtMaKH.Text.Trim();
            if (cbGioiTinh.SelectedIndex == 0)
            {
                kh.Gioitinh = "Nam";

            }
            else
                kh.Gioitinh = "Nữ";
            kh.Gioitinh = cbGioiTinh.Text.Trim();
            kh.Diachi = txtDiaChi.Text.Trim();
            kh.Sdt = txtSDT.Text.Trim();
            kh.Ten = txtTenKH.Text.Trim();

        }
       

      

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            flag = 0;
            dis_end(true);
            loadcontrol();
            clearData();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            ClassKhachhang kh2 = new ClassKhachhang();
            gandulieu(kh2);
            if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtDiaChi.Text == "" || cbGioiTinh.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dis_end(true);
                
            }
            else
            {
                if (flag == 0)
                {

                    if (khctrl.AddData(kh2))
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (khctrl.UpdData(kh2))
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dis_end(false);
                frmkhachhang_Load(sender, e);
            }
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            flag = 1;
            dis_end(true);
            loadcontrol();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dis_end(false);
            frmkhachhang_Load(sender, e);
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (khctrl.DelData(txtMaKH.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmkhachhang_Load(sender, e);
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
