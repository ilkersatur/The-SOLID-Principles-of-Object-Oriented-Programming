﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    internal interface ICRUD
    {
        List<Personel> Tumpersoneller();
        void Ekle(Personel personel);
    }
}
