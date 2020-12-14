using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Bansim
{
    class ClassNhanVien
    {
        string ma, ten, gioitinh, diachi, sdt;
        

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public string Gioitinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
            }
        }

        public string Ma
        {
            get
            {
                return ma;
            }

            set
            {
                ma = value;
            }
        }

        public string Sdt
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }
        public ClassNhanVien() { }
        public ClassNhanVien(string ma, string ten,string gioitinh,string diachi,string sdt)
        {
            this.ma = ma;
            this.ten = ten;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.sdt = sdt;
        }
    }
}
