using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_Bansim
{
    public partial class frmNhanVien : Form
    {
        NhanVienCtrl nvctrl = new NhanVienCtrl();
        int flag = 0;
        

        public frmNhanVien()
        {
            InitializeComponent();
        }


        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DataTable tbnhanvien = new DataTable();
            tbnhanvien = nvctrl.GetData();
            dataGridView1.DataSource = tbnhanvien;
            bingding();
        }
        void bingding()
        {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dataGridView1.DataSource, "MaNV");
            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", dataGridView1.DataSource, "TenNV");
            cbGioiTinh.DataBindings.Clear();
            cbGioiTinh.DataBindings.Add("Text", dataGridView1.DataSource, "GioiTinh");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dataGridView1.DataSource, "DiaChi");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dataGridView1.DataSource, "SDT");

        }
        void dis_end(bool e)
        {
            txtMaNV.Enabled = e;
            txtTenNV.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSDT.Enabled = e;
            cbGioiTinh.Enabled = e;
            btnHuy.Enabled = e;
            btnLuu.Enabled = e;
            btnThem.Enabled =! e;
            btnXoa.Enabled =! e;
            btnSua.Enabled =! e;

        }
        private void clearData()
        {
            txtMaNV.Text = "";
            txtSDT.Text = "";
            // LoadcmbKhachHang();
            cbGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtTenNV.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_end ( true);
            loadcontrol();
            clearData();
        
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true);
            loadcontrol();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (nvctrl.DelData(txtMaNV.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmNhanVien_Load(sender, e);
        }
        void loadcontrol()
        {
            cbGioiTinh.Items.Clear();
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
        }
        void gandulieu(ClassNhanVien nv)
        {
            nv.Ma = txtMaNV.Text.Trim();
            if (cbGioiTinh.SelectedIndex == 0)
            {
                nv.Gioitinh = "Nam";
                
            }
            else
                nv.Gioitinh = "Nữ";
            nv.Gioitinh = cbGioiTinh.Text.Trim();   
            nv.Diachi = txtDiaChi.Text.Trim();
            nv.Sdt = txtSDT.Text.Trim();
            nv.Ten = txtTenNV.Text.Trim();
            
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            ClassNhanVien nv2 = new ClassNhanVien();
            gandulieu(nv2);
            if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtDiaChi.Text == "" || cbGioiTinh.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dis_end(true);
            }
            else
            {
                if (flag == 0)
                {

                    if (nvctrl.AddData(nv2))
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (nvctrl.UpdData(nv2))
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dis_end(false);
                frmNhanVien_Load(sender, e);
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dis_end(false);
            frmNhanVien_Load(sender, e);
           


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
