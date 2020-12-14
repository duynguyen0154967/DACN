using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Bansim
{
    public partial class frmhanghoa : Form
    {
        hanghoaCtrl hhctrl = new hanghoaCtrl();
        int flag = 0;
        public frmhanghoa()
        {
            InitializeComponent();
        }

        private void frmhanghoa_Load(object sender, EventArgs e)
        {
            DataTable tbhanghoa = new DataTable();
            tbhanghoa = hhctrl.GetData();
            dataGridView1.DataSource = tbhanghoa;
            bingding();
        }
        void bingding()
        {
            txtMaSim.DataBindings.Clear();
            txtMaSim.DataBindings.Add("Text", dataGridView1.DataSource, "MaSim");
            cbtenNM.DataBindings.Clear();
            cbtenNM.DataBindings.Add("Text", dataGridView1.DataSource, "TenNhaMang");
            txtso.DataBindings.Clear();
            txtso.DataBindings.Add("Text", dataGridView1.DataSource, "SDTSim");
            cbloai.DataBindings.Clear();
            cbloai.DataBindings.Add("Text", dataGridView1.DataSource, "Loai");
            txtdongia.DataBindings.Clear();
            txtdongia.DataBindings.Add("Text", dataGridView1.DataSource, "DonGia");

        }
        void dis_end(bool e)
        {
            txtMaSim.Enabled = e;
            cbtenNM.Enabled = e;
            cbloai.Enabled = e;
            txtdongia.Enabled = e;
            txtso.Enabled = e;
            btnHuy.Enabled = e;
            btnluu.Enabled = e;
            btnThem.Enabled = !e;
            btnxoa.Enabled = !e;
            btnsua.Enabled = !e;

        }
        void loadcontrol()
        {
            cbtenNM.Items.Clear();
            cbtenNM.Items.Add("VIETTEL");
            cbtenNM.Items.Add("VINA");
            cbtenNM.Items.Add("MOBI");
        }
        void loadcontrol2()
        {
            cbloai.Items.Clear();
            cbloai.Items.Add("Thường");
            cbloai.Items.Add("Số đẹp");
            cbloai.Items.Add("Số tứ quý");
        }
        void gandulieu(Classhanghoa hh)
        {
            hh.Ma = txtMaSim.Text.Trim();
            if (cbtenNM.SelectedIndex == 0)
            {
                hh.Ten = "VIETTEL";

            }
            if (cbtenNM.SelectedIndex == 1)
            {
                hh.Ten = "VINA";

            }
            if (cbtenNM.SelectedIndex == 2)
                hh.Ten = "MOBI";

            
            hh.SO = txtso.Text.Trim();
            if (cbloai.SelectedIndex == 0)
            {
                hh.LOAI = "Thường";
                hh.DONGIA = int.Parse(txtdongia.Text.Trim());
            }

            if (cbloai.SelectedIndex == 1)
            {
                hh.LOAI = "Số đẹp";
                hh.DONGIA = int.Parse(txtdongia.Text.Trim()) * (float)3.0;
            }
           
            if (cbloai.SelectedIndex == 2)
            {
                hh.LOAI = "Số tứ quý";
                hh.DONGIA = int.Parse(txtdongia.Text.Trim()) * (float)5.0;
            }
            hh.Ten = cbtenNM.Text.Trim();
            hh.LOAI = cbloai.Text.Trim();
            
            

        }
        private void clearData()
        {
            txtMaSim.Text = "";
            txtso.Text = "";
            // LoadcmbKhachHang();
            cbloai.Text = "";
            cbtenNM.Text = "";
            txtdongia.Text = "";
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_end(true);
            loadcontrol();
            loadcontrol2();
            clearData();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa Sim này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (hhctrl.DelData(txtMaSim.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmhanghoa_Load(sender, e);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true);
                        
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            Classhanghoa hh2 = new Classhanghoa();
            gandulieu(hh2);

            if (txtMaSim.Text == "" || txtso.Text == "" || txtdongia.Text == "" || cbloai.Text == "" || cbtenNM.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (flag == 0)
                {

                    if (hhctrl.AddData(hh2))
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (hhctrl.UpdData(hh2))
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dis_end(false);
                frmhanghoa_Load(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dis_end(false);
            frmhanghoa_Load(sender, e);
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtdongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

      
    }
}
