using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QL_Bansim
{
    class hanghoaCtrl
    {
        hanghoaconect hhMod = new hanghoaconect();
        public DataTable GetData()
        {
            return hhMod.getData();
        }
        public DataTable getData(string dieukien)
        {
            return hhMod.GetData(dieukien);
        }
        public bool AddData(Classhanghoa hh)
        {
            return hhMod.AddData(hh);
        }
        public bool UpdData(Classhanghoa hh)
        {
            return hhMod.UpdateData(hh);
        }
        //public bool UpdSL(DataTable dt)
        //{
        //    DataTable dthh = new DataTable();
        //    dthh = hhMod.getData();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        for (int j = 0; j < dthh.Rows.Count; j++)
        //        {
        //            if (dt.Rows[i][1].ToString() == dthh.Rows[j][0].ToString())
        //            {
        //                int SLcu = int.Parse(dthh.Rows[j][3].ToString());
                        
        //                break;
        //            }
        //        }

        //    }
        //    return true;
        //}
        public bool DelData(string ma)
        {
            return hhMod.DelData(ma);
        }
       
    }
}
