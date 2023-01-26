using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class TextDosya : IDosya
    {
        public string DosyadanOku()
        {
            return "text";
        }
    }
}
