using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSV
{
    internal class Memur
    {
        public decimal Maas { get; set; }

        public virtual decimal MaasHesapla()
        {
            return Maas;
        }
    }
}
