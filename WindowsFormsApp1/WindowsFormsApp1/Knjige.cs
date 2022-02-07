using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Knjige
    {
        int OSBN;
        string nazivKnjige, nazivAutora;

        public Knjige(int oSBN, string nazivKnjige, string nazivAutora)
        {
            OSBN = oSBN;
            this.nazivKnjige = nazivKnjige;
            this.nazivAutora = nazivAutora;
        }

        public int OSBN1 { get => OSBN; set => OSBN = value; }
        public string NazivKnjige { get => nazivKnjige; set => nazivKnjige = value; }
        public string NazivAutora { get => nazivAutora; set => nazivAutora = value; }
    }
}
