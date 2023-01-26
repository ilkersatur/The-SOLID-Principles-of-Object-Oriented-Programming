using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal class Karabatak : IYuruyebilir, IUcabilir, IYuzebilir
    {
        public void Uc()
        {
            throw new NotImplementedException();
        }

        public void Yuru()
        {
            throw new NotImplementedException();
        }

        public void Yuz()
        {
            throw new NotImplementedException();
        }
    }
}
