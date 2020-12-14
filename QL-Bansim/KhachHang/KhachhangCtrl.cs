using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QL_Bansim
{
    class KhachhangCtrl
    {
        Khachhangconect khMod = new Khachhangconect();
        public DataTable GetData()
        {
            return khMod.GetData();
        }
        public bool AddData(ClassKhachhang kh)
        {
            return khMod.AddData(kh);
        }
        public bool UpdData(ClassKhachhang kh)
        {
            return khMod.UpdateData(kh);
        }

        public bool DelData(string ma)
        {
            return khMod.DelData(ma);
        }
    }
}
