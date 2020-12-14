using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QL_Bansim.CTHD2
{
    class cthd2Ctrl
    {
        cthd2conect khMod = new cthd2conect();
        public DataTable GetData()
        {
            return khMod.GetData();
        }
        public bool DelData(string ma)
        {
            return khMod.DelData(ma);
        }
        
    }
}
