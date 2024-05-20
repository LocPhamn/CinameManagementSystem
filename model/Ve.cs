using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.model
{
    internal class Ve
    {
        private string id_ve {  get; set; } 
        private string id_phim { get; set;}
        private string id_ghe { get; set;}
        private string id_khachhang { get; set;}    
        private string id_nhanvien { get; set; } 
        private string id_cachieu { get; set; } 
        private string ngaychieu { get; set; }  
        private int giave { get; set; }

        public Ve(string id_ve, string id_phim, string id_ghe, string id_khachhang, string id_nhanvien, string id_cachieu, string ngaychieu, int giave)
        {
            this.id_ve = id_ve;
            this.id_phim = id_phim;
            this.id_ghe = id_ghe;
            this.id_khachhang = id_khachhang;
            this.id_nhanvien = id_nhanvien;
            this.id_cachieu = id_cachieu;
            this.ngaychieu = ngaychieu;
            this.giave = giave;
        }

        public Ve()
        {
        }
    }
}
