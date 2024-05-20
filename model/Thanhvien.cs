using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.model
{
    internal class Thanhvien
    {
        private string id_thanhvien {  get; set; }  
        private string hoten { get; set; }
        private string ngaysinh { get; set; }
        private string diachi { get; set; }
        private string gioitinh { get; set; }
        private string sodienthoai { get; set; }
        private bool loai_taikhoan { get; set; }    
        private string taikhoan { get; set; }   
        private string matkhau { get; set; }

        public Thanhvien(string id_thanhvien, string hoten, string ngaysinh, string diachi, string gioitinh, string sodienthoai, bool loai_taikhoan, string taikhoan, string matkhau)
        {
            this.id_thanhvien = id_thanhvien;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.diachi = diachi;
            this.gioitinh = gioitinh;
            this.sodienthoai = sodienthoai;
            this.loai_taikhoan = loai_taikhoan;
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
        }

        public Thanhvien()
        {
        }
    }
}
