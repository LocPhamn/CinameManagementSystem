using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.model
{
    internal class Phim
    {
        private string id_phim {  get; set; }
        private string tenphim { get;set; }
        private string nhan_phim { get; set; }

        private string quocgia { get; set; }
        private string theloai { get; set; }
        private int sove {  get; set; }
        private int thoiluong { get; set; }
        private string hanglamphim { get; set; }
        private string ngayramat {  get; set; }

        public Phim(string id_phim, string tenphim,string nhan_phim, string quocgia, string theloai, int sove, int thoiluong, string hanglamphim, string ngayramat)
        {
            this.id_phim = id_phim;
            this.tenphim = tenphim;
            this.nhan_phim = nhan_phim;
            this.quocgia = quocgia;
            this.theloai = theloai;
            this.sove = sove;
            this.thoiluong = thoiluong;
            this.hanglamphim = hanglamphim;
            this.ngayramat = ngayramat;
        }

        public Phim()
        {
        }
    }
}
