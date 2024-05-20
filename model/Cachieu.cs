using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.model
{
    internal class Cachieu
    {
        private string id_cachieu { get; set; }
        private string tencachieu { get; set; }
        private string thoigian_batdau { get; set; }
        private string thoigian_kethuc { get; set; }

        public Cachieu()
        {
        }

        public Cachieu(string id_cachieu, string tencachieu, string thoigian_batdau, string thoigian_kethuc)
        {
            this.id_cachieu = id_cachieu;
            this.tencachieu = tencachieu;
            this.thoigian_batdau = thoigian_batdau;
            this.thoigian_kethuc = thoigian_kethuc;
        }
         
    }
}
