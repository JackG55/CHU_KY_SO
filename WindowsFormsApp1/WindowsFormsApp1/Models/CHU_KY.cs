using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class CHU_KY
    {

        int ma_chu_ky;
        int ma_user;

        DateTime Thoi_gian_cap;
        DateTime Thoi_gin_het_han;

        string Duong_dan_chu_ky;

        string ten_chu_ky;

        string Duong_dan_anh;

        int Kieu_chu_ky;

        public int Ma_chu_ky { get => ma_chu_ky; set => ma_chu_ky = value; }
        public int Ma_user { get => ma_user; set => ma_user = value; }
        public DateTime Thoi_gian_cap1 { get => Thoi_gian_cap; set => Thoi_gian_cap = value; }
        public DateTime Thoi_gin_het_han1 { get => Thoi_gin_het_han; set => Thoi_gin_het_han = value; }
        public string Duong_dan_chu_ky1 { get => Duong_dan_chu_ky; set => Duong_dan_chu_ky = value; }
        public string Ten_chu_ky { get => ten_chu_ky; set => ten_chu_ky = value; }
        public string Duong_dan_anh1 { get => Duong_dan_anh; set => Duong_dan_anh = value; }
        public int Kieu_chu_ky1 { get => Kieu_chu_ky; set => Kieu_chu_ky = value; }

        public CHU_KY()
        {


        }

        public CHU_KY(int ma_chu_ky, int ma_user, DateTime thoi_gian_cap, DateTime thoi_gin_het_han, string duong_dan_chu_ky, string ten_chu_ky, string duong_dan_anh, int kieu_chu_ky)
        {
            this.Ma_chu_ky = ma_chu_ky;
            this.Ma_user = ma_user;
            Thoi_gian_cap1 = thoi_gian_cap;
            Thoi_gin_het_han1 = thoi_gin_het_han;
            Duong_dan_chu_ky1 = duong_dan_chu_ky;
            this.Ten_chu_ky = ten_chu_ky;
            Duong_dan_anh1 = duong_dan_anh;
            Kieu_chu_ky1 = kieu_chu_ky;
        }

        public CHU_KY(int ma_chu_ky, string ten_chu_ky)
        {
            this.Ma_chu_ky = ma_chu_ky;
            this.Ten_chu_ky = ten_chu_ky;
        }
    }
}
