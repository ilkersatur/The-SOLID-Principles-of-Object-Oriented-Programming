using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSV
{
    internal class Mudur : Memur
    {
        public decimal Prim { get; set; }

        public override decimal MaasHesapla()
        {
            return Maas + Prim;
        }
    }
}
