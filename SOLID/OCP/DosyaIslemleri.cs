using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class DosyaIslemleri
    {
        public string Oku(IDosya dosya)
        {
            return dosya.DosyadanOku();
        }
    }
}

//Projede hiyerarşik yapı var ise Abstract Metod, yok ise Interface kullanılır.