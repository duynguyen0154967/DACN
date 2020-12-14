using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QL_Bansim
{
    class NhanVienCtrl
    {
        NhanVienConnect nvMod = new NhanVienConnect();
        public DataTable GetData()
        {
            return nvMod.GetData();
        }
       
        public bool AddData(ClassNhanVien nv)
        {
            return nvMod.AddData(nv);
        }
        public bool UpdData(ClassNhanVien nv)
        {
            return nvMod.UpdateData(nv);
        }
      
        public bool DelData(string ma)
        {
            return nvMod.DelData(ma);
        }
    }
}
