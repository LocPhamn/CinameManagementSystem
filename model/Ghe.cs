using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Project.model
{
    internal class Ghe
    {
        private string id_ghe {  get; set; }
        private string id_phong { get; set; }
        private string tenghe { get; set; }
        private int giaghe { get; set; }
        private bool trangthai { get; set; }

        public Ghe(string id_ghe, string id_phong, string tenghe, int giaghe, bool trangthai)
        {
            this.id_ghe = id_ghe;
            this.id_phong = id_phong;
            this.tenghe = tenghe;
            this.giaghe = giaghe;
            this.trangthai = trangthai;
        }

        public Ghe()
        {
        }
    }
}
