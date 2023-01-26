using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    internal class SqlDB : ICRUD
    {
        public void Ekle(Personel personel)
        {
            throw new NotImplementedException();
        }

        public List<Personel> Tumpersoneller()
        {
            return new List<Personel>
            {
                new Personel{PersonelID=1, Ad="Deniz", Soyad="Derya"},
                new Personel{PersonelID=2, Ad="Zafer", Soyad="Muzaffer"}
            };
        }
    }
}
