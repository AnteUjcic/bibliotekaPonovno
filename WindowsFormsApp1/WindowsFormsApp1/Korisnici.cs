using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Korisnici
    {
        int OIB;
        string Ime, prezime;

        public Korisnici(int oIB, string ime, string prezime)
        {
            OIB = oIB;
            Ime = ime;
            this.prezime = prezime;
        }

        public int OIB1 { get => OIB; set => OIB = value; }
        public string Ime1 { get => Ime; set => Ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
    }
}
