using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.model
{
    internal class Hoadon
    {
        private string id_hoadon {get;set;}
        private string id_doan { get;set;}
        private string id_khach { get;set;}
        private string id_thanhvien { get;set;}
        private int soluong { get;set;}
        private int tonggia { get;set;}
        private string ngayban {  get;set;}

        public Hoadon(string id_hoadon, string id_doan, string id_khach, string id_thanhvien, int soluong, int tonggia, string ngayban)
        {
            this.id_hoadon = id_hoadon;
            this.id_doan = id_doan;
            this.id_khach = id_khach;
            this.id_thanhvien = id_thanhvien;
            this.soluong = soluong;
            this.tonggia = tonggia;
            this.ngayban = ngayban;
        }

        public Hoadon()
        {
        }
    }
}
