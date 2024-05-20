using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.model
{
    internal class Phong
    {
        private string id_phong {  get; set; }
        private string tenphong { get; set; }
        private int soghe {  get; set; }
        private bool trangthai { get; set; }

        public Phong(string id_phong, string tenphong, int soghe, bool trangthai)
        {
            this.id_phong = id_phong;
            this.tenphong = tenphong;
            this.soghe = soghe;
            this.trangthai = trangthai;
        }

        public Phong()
        {
        }
    }
}
