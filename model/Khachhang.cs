using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.model
{
    internal class Khachhang
    {
        private string id_khachhang {  get; set; }
        private string hoten {  get; set; }
        private string ngaysinh { get; set; }
        private string diachi { get; set; }
        private string gioitinh { get; set; }
        private string sodienthoai { get;set; }

        public Khachhang(string id_khachhang, string hoten, string ngaysinh, string diachi, string gioitinh, string sodienthoai)
        {
            this.id_khachhang = id_khachhang;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.diachi = diachi;
            this.gioitinh = gioitinh;
            this.sodienthoai = sodienthoai;
        }

        public Khachhang()
        {
        }
    }
}
