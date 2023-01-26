using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    internal class OracleDB : ICRUD
    {
        public void Ekle(Personel personel)
        {
            throw new NotImplementedException();
        }

        public List<Personel> Tumpersoneller()
        {
            return new List<Personel>
            {
                new Personel{PersonelID=1, Ad="Cevdet", Soyad="Korkmaz"},
                new Personel{PersonelID=2, Ad="Selami", Soyad="Korkmaz"},
                new Personel{PersonelID=3, Ad="Dursun", Soyad="Durmasın"},
            };
        }
    }
}
