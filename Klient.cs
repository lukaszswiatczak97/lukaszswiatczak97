using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Klient
    {
        private string imie;
        private string nazwisko;
        private string numerTelefonu;
        Bilet bilet;

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string NumerTelefonu { get => numerTelefonu; set => numerTelefonu = value; }
        internal Bilet Bilet { get => bilet; set => bilet = value; }
    }
}
