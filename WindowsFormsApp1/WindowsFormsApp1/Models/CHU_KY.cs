using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class CHU_KY
    {
        string ma_chu_ky { get; set; }
        string ma_user { get; set; }

        DateTime Thoi_gian_cap { get; set;  }
        DateTime Thoi_gin_het_han { get; set;  }

        string Duong_dan_chu_ky { get; set; }

        string ten_chu_ky { get; set; }

        string Duong_dan_anh { get; set;  }

        int Kieu_chu_ky { get; set; }

        public CHU_KY()
        {


        }

        public CHU_KY(string ma_chu_ky, string ma_user, DateTime thoi_gian_cap, DateTime thoi_gin_het_han, string duong_dan_chu_ky, string ten_chu_ky, string duong_dan_anh, int kieu_chu_ky)
        {
            this.ma_chu_ky = ma_chu_ky;
            this.ma_user = ma_user;
            Thoi_gian_cap = thoi_gian_cap;
            Thoi_gin_het_han = thoi_gin_het_han;
            Duong_dan_chu_ky = duong_dan_chu_ky;
            this.ten_chu_ky = ten_chu_ky;
            Duong_dan_anh = duong_dan_anh;
            Kieu_chu_ky = kieu_chu_ky;
        }

        public CHU_KY(string ma_chu_ky, string ten_chu_ky)
        {
            this.ma_chu_ky = ma_chu_ky;
            this.ten_chu_ky = ten_chu_ky;
        }
    }
}
