using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSV
{
    internal class PersonelIslemleri
    {
        public decimal MaasGoster(Memur calisan) 
        {
            return calisan.MaasHesapla();
        }
    }
}
