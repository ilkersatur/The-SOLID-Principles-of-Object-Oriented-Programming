using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    internal class DatabaseManager
    {
        //ctor injection
        ICRUD _db;
        public DatabaseManager(ICRUD db)
        {
            _db=db;
        }
        public DatabaseManager()
        {

        }
        //Prop injection
        public ICRUD VeriTabani {
            get { return _db; }
            set { _db = value; }
        }

        //method injection
        public void MethodInjection(ICRUD db)
        {
            _db= db;
        }

        public List<Personel> VerileriGetir()
        {
            return _db.Tumpersoneller();
        }

        //public List<Personel> VerileriGetirProp()
        //{
        //    return _db.Tumpersoneller();
        //}

        //public List<Personel> VerileriGetirMethod()
        //{
        //    return _db.Tumpersoneller();
        //}
    }
}
