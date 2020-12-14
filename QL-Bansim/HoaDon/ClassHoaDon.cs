﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Bansim
{
    class ClassHoaDon
    {
        string ma, ngaylap, nguoilap, khachhang;

        public string KhachHang
        {
            get { return khachhang; }
            set { khachhang = value; }
        }

        public string NguoiLap
        {
            get { return nguoilap; }
            set { nguoilap = value; }
        }

        public string NgayLap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }

        public string MaHoaDon
        {
            get { return ma; }
            set { ma = value; }
        }

        public ClassHoaDon() { }

        public ClassHoaDon(string ma, string ngaylap, string nguoilap, string khachhang)
        {
            this.ma = ma;
            this.nguoilap = nguoilap;
            this.ngaylap = ngaylap;
            this.khachhang = khachhang;
        }
    }
}
