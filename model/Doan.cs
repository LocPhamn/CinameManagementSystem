using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.model
{
    internal class Doan
    {
        private string id_doan {  get; set; }
        private string ten { get; set; }
        private string loai { get; set; }
        private int soluong { get; set; }
        private int gia { get; set; }

        public Doan(string id_doan, string ten, string loai, int soluong, int gia)
        {
            this.id_doan = id_doan;
            this.ten = ten;
            this.loai = loai;
            this.soluong = soluong;
            this.gia = gia;
        }

        public Doan()
        {
        }
    }
}
