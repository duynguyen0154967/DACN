using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_Bansim.CTHD2;

namespace QL_Bansim.CTHD2
{
    public partial class frmCTHD : Form
    {
        cthd2Ctrl CThdctrl = new cthd2Ctrl();
        int flag = 0;
        public frmCTHD()
        {
            InitializeComponent();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (CThdctrl.DelData(txtMaHD.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmCTHD_Load(sender, e);
        }

        private void frmCTHD_Load(object sender, EventArgs e)
        {
            DataTable tbkhachhang = new DataTable();
            tbkhachhang = CThdctrl.GetData();
            dataGridView1.DataSource = tbkhachhang;
            bingding();
        }
        void bingding()
        {
            txtMaHD.DataBindings.Clear();
            txtMaHD.DataBindings.Add("Text", dataGridView1.DataSource, "MaHD");
           

        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (CThdctrl.DelData(txtMaHD.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmCTHD_Load(sender, e);
        }

       
    }
}
