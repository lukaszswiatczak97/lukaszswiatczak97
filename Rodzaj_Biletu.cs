using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rodzaj_Biletu
    {
        private string nazwa;
        private double procentZnizki;

        public string Nazwa { get => nazwa; set => nazwa = value; }
        public double ProcentZnizki { get => procentZnizki; set => procentZnizki = value; }
         
         public void ZmienZnizke(double nowaZnizka)
        { }
    }
}
