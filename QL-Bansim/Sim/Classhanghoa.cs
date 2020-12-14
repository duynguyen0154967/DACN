using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Bansim
{
    class Classhanghoa
    {
        string ma, ten, so, loai;
        
        float dongia;

        public string SO
        {
            get
            {
                return so;
            }

            set
            {
                so = value;
            }
        }

        public string LOAI
        {
            get
            {
                return loai;
            }

            set
            {
                loai = value;
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

        public float DONGIA
        {
            get
            {
                return dongia;
            }

            set
            {
               dongia = value;
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
        public Classhanghoa() { }
        public Classhanghoa(string ma, string ten, string so, string loai, float dongia)
        {
            this.ma = ma;
            this.ten = ten;
            this.so = so;
            this.loai = loai;
            this.dongia = dongia;
            
        }
    }
}
