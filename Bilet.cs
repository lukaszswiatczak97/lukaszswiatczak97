using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bilet
    {
        private string nazwaFilmu;
        private int sala;
        private DateTime data;
        private DateTime godzina;
        private int rząd;
        private int miejsce;

        public string NazwaFilmu { get => nazwaFilmu; set => nazwaFilmu = value; }
        public int Sala { get => sala; set => sala = value; }
        public DateTime Data { get => data; set => data = value; }
        public DateTime Godzina { get => godzina; set => godzina = value; }
        public int Rząd { get => rząd; set => rząd = value; }
        public int Miejsce { get => miejsce; set => miejsce = value; }
        
    }
}
