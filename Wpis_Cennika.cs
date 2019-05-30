using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Wpis_Cennika
    {
        private string nazwaProduktu;
        private double cena;

        public string NazwaProduktu { get => nazwaProduktu; set => nazwaProduktu = value; }
        public double Cena { get => cena; set => cena = value; }

        public void ZmienCene(double nowaCena)
        {}
    }
}
