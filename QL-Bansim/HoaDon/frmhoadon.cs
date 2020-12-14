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
    public partial class frmhoadon : Form
    {
        HoaDonCtrl hdCtr = new HoaDonCtrl();
        CTHDCtrl ctCtr = new CTHDCtrl();
        hanghoaCtrl hhctr = new hanghoaCtrl();        
        DataTable dtDSCT = new System.Data.DataTable();
        int vitriclick = 0;

        public frmhoadon()
        {
            InitializeComponent();
        }

        private void frmhoadon_Load(object sender, EventArgs e)
        {
            Dis_Enl(false);
            DataTable dt = new System.Data.DataTable();
            dt = hdCtr.getData();
            dtgvDSHD.DataSource = dt;
            bingding();
            txtNgayLap.Enabled = false;
        }
        private void bingding()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dtgvDSHD.DataSource, "MaHoaDon");
            txtNgayLap.DataBindings.Clear();
            txtNgayLap.DataBindings.Add("Text", dtgvDSHD.DataSource, "NgayLap");
            cmbmanv.DataBindings.Clear();
            cmbmanv.DataBindings.Add("Text", dtgvDSHD.DataSource, "TenNV");
            txtmakh.DataBindings.Clear();
            txtmakh.DataBindings.Add("Text", dtgvDSHD.DataSource, "TenKH");
            //cmbKhachHang.DataBindings.Clear();
            //cmbKhachHang.DataBindings.Add("Text", dtgvDSHD.DataSource, "TenKH");
        }
        private void Dis_Enl(bool e)
        {
            txtMa.Enabled = e;
            cmbmanv.Enabled = e;
            //cmbKhachHang.Enabled = e;
            txtmakh.Enabled = e;
            btnAdd.Enabled = !e;
            
            btnSave.Enabled = e;
            btnCancel.Enabled = e;
            
            btnThem.Enabled = e;
            
            cmbHH.Enabled = e;
            txtSL.Enabled = e;
            
        }

        private void cmbHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = hhctr.getData("Where MaSim = '" + cmbHH.SelectedValue.ToString() + "'");
            if (dt.Rows.Count > 0)
            {
                double gia = double.Parse(dt.Rows[0][2].ToString());

                txtDonGia.Text = (gia * 1.1).ToString();

                lbThanhTien.Text = (double.Parse(txtDonGia.Text) * int.Parse(txtSL.Text)).ToString();
            }
        }
        private void Loadcmbmanv()
        {
            NhanVienCtrl khctr = new NhanVienCtrl();
            cmbmanv.DataSource = khctr.GetData();
            cmbmanv.DisplayMember = "TenNV";
            cmbmanv.ValueMember = "MaNV";
            cmbmanv.SelectedIndex = 0;
            cmbmanv.Text = "";
            
        }
        //private void LoadcmbKhachHang()
        //{
        //    KhachhangCtrl khctr = new KhachhangCtrl();
        //    cmbKhachHang.DataSource = khctr.GetData();
        //    cmbKhachHang.DisplayMember = "TenKH";
        //    cmbKhachHang.ValueMember = "MaKH";
        //    cmbKhachHang.SelectedIndex = 0;
        //}
        private void LoadcmbHH()
        {
            hanghoaCtrl hhctr = new hanghoaCtrl();
            cmbHH.DataSource = hhctr.GetData();
            cmbHH.DisplayMember = "SDTSim";
            cmbHH.ValueMember = "MaSim";
            cmbHH.SelectedIndex = 0;
            cmbHH.Text = "";
            

        }

        private void clearData()
        {
            txtMa.Text = "";            
            txtNgayLap.Text = DateTime.Now.Date.ToShortDateString();
           // LoadcmbKhachHang();
            Loadcmbmanv();
            cmbHH.Text = "";
            txtmakh.Text = "";
        }
        private void addData(ClassHoaDon hd)
        {
            hd.MaHoaDon = txtMa.Text.Trim();
            hd.NgayLap = txtNgayLap.Text.Trim();
            hd.NguoiLap= cmbmanv.SelectedValue.ToString();
            hd.KhachHang = txtmakh.Text.Trim();
           // hd.KhachHang = cmbKhachHang.SelectedValue.ToString();
        }
        private bool checktrung(string mahh)
        {
            for (int i = 0; i < dtDSCT.Rows.Count; i++)
                if (dtDSCT.Rows[i][1].ToString() == mahh)
                    return true;
            return false;
        }
        private void capnhatSL(string mahh, int SL)
        {
            for (int i = 0; i < dtDSCT.Rows.Count; i++)
                if (dtDSCT.Rows[i][1].ToString() == mahh)
                {
                    int soluong = int.Parse(dtDSCT.Rows[i][3].ToString()) + SL;
                    dtDSCT.Rows[i][3] = soluong;
                    double dongia = double.Parse(dtDSCT.Rows[i][2].ToString());
                    dtDSCT.Rows[i][4] = (dongia * soluong).ToString();
                    break;
                }
        }
        private bool kiemtraSL(string mahh, int sl)
        {
            DataTable dt = new DataTable();
            dt = hhctr.getData("Where MaSim = '" + cmbHH.SelectedValue.ToString() + "' and SoLuong>= " + sl);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        private void dtgvDSHH_DataSourceChanged(object sender, EventArgs e)
        {
            //bingding1();
        }
        private void them2 ()
        {
            dtDSCT.Columns.Clear();
            dtDSCT.Columns.Add("MaHD");
            dtDSCT.Columns.Add("SDTSim");
            dtDSCT.Columns.Add("DonGia");
            dtDSCT.Columns.Add("SoLuongMua");
            dtDSCT.Columns.Add("ThanhTien");
            dtDSCT.Rows.Clear();
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Dis_Enl(true);
            clearData();
            LoadcmbHH();
            //LoadcmbKhachHang();
            Loadcmbmanv();
            txtMa.Focus();
            them2();
           
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (hdCtr.DelData(txtMa.Text.Trim()))
                   
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmhoadon_Load(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ClassHoaDon hdObj = new ClassHoaDon();
            addData(hdObj);
           
            if (hdCtr.AddData(hdObj))
            {
                DataTable dt = new System.Data.DataTable();
                dt = (DataTable)dtgvDSHH.DataSource;
                if (ctCtr.AddData(dtDSCT))
                    MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm chi tiết không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmhoadon_Load(sender, e);
                clearData(); 
            }
            else
                MessageBox.Show("Vui lòng kiểm tra lại thông tin nhập đã chính xác chưa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmhoadon_Load(sender, e);
            else
                return;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMa.Text))
            {


                if (!checktrung(cmbHH.SelectedValue.ToString()))
                {
                    DataRow dr = dtDSCT.NewRow();
                    dr[0] = txtMa.Text.Trim();
                    dr[1] = cmbHH.SelectedValue.ToString();
                    dr[2] = txtDonGia.Text;
                    dr[3] = txtSL.Text;
                    if (txtDonGia.Text == "")
                        MessageBox.Show("Chua chon sim");
                    
                      else
                        { dr[4] = (double.Parse(txtDonGia.Text) * int.Parse(txtSL.Text)).ToString();
                            dtDSCT.Rows.Add(dr);
                        }
                   
                }
                
                else
                {
                    capnhatSL(cmbHH.SelectedValue.ToString(), int.Parse(txtSL.Text));
                }
                dtgvDSHH.DataSource = dtDSCT;


            }
            else
            {
                MessageBox.Show("Mã hóa đơn không được trống", "Lỗi");
                txtMa.Focus();
            }
        }

        private void btnBot_Click(object sender, EventArgs e)
        {
            if (vitriclick < dtDSCT.Rows.Count)
            {
                dtDSCT.Rows.RemoveAt(vitriclick);
                dtgvDSHH.DataSource = dtDSCT;
            }
        }

        private void txtMa_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new System.Data.DataTable();
                dt = ctCtr.GetData(txtMa.Text.Trim());
                dtgvDSHH.DataSource = dt;

            }
            catch
            {
                dtgvDSHH.DataSource = null;
            }
            //bingding1();
        }

        private void dtgvDSHH_DataSourceChanged_1(object sender, EventArgs e)
        {
            //bingding1();
        }

        private void lbThanhTien_Click(object sender, EventArgs e)
        {
            lbThanhTien.Text = (double.Parse(txtDonGia.Text) * int.Parse(txtSL.Text)).ToString();
        }

      

        private void cmbHH_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = hhctr.getData("Where MaSim = '" + cmbHH.SelectedValue.ToString() + "'");
            if (dt.Rows.Count > 0)
            {
                double gia = double.Parse(dt.Rows[0][4].ToString());

                txtDonGia.Text = (gia * 1.0).ToString();

                lbThanhTien.Text = (double.Parse(txtDonGia.Text) * int.Parse(txtSL.Text)).ToString();
            }
        }

       

        private void txtNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (hdCtr.DelData(txtMa.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công! Bạn phải xóa dữ liệu bên CTHD trước", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmhoadon_Load(sender, e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

      
    }
}
