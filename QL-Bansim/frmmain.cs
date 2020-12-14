using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_Bansim.khachhang;
using QL_Bansim.CTHD2;
namespace QL_Bansim
{
    public partial class frmmain : Form
    {
        
        public frmmain()
        {
            InitializeComponent();
        }

        private void quảnLýHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhanghoa frmhh = new frmhanghoa();
            frmhh.MdiParent = this;
            frmhh.Show();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
            
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frmnv = new frmNhanVien();
            frmnv.MdiParent = this;
            frmnv.Show();
            
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmkhachhang frmkh = new frmkhachhang();
            frmkh.MdiParent = this;
            frmkh.Show();

        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhoadon frmkh = new frmhoadon();
            frmkh.MdiParent = this;
            frmkh.Show();
        }

        private void quảnLýCTHDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCTHD frmkh = new frmCTHD();
            frmkh.MdiParent = this;
            
            frmkh.Show();
        }
    }
}
