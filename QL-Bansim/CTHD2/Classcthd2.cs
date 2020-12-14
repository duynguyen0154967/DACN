using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Bansim.CTHD2
{
    class Classcthd2
    {
        class ClassKhachhang
        {
            string ma, MaSim;
            int DonGia, SoLuongMua;

            public int dongia
            {
                get
                {
                    return DonGia;
                }

                set
                {
                    DonGia = value;
                }
            }

            public int soluongmua
            {
                get
                {
                    return SoLuongMua;
                }

                set
                {
                    SoLuongMua = value;
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



            public string masim
            {
                get
                {
                    return MaSim;
                }

                set
                {
                    MaSim = value;
                }
            }
            public ClassKhachhang() { }
            public ClassKhachhang(string ma, string MaSim, int DonGia, int SoLuongMua)
            {
                this.ma = ma;
                this.MaSim = MaSim;
                this.DonGia = DonGia;
                this.SoLuongMua = SoLuongMua;

            }
        }
    }
}
