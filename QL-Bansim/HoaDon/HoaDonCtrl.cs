using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace QL_Bansim
{
    class HoaDonCtrl
    {

        HoaDonconect hdMod = new HoaDonconect();
        public DataTable getData()
        {
            return hdMod.GetData();
        }
        public bool AddData(ClassHoaDon hd)
        {
            return hdMod.AddData(hd);
        }
        public bool DelData(string ma)
        {
            return hdMod.DelData(ma);
        }
    }
}
