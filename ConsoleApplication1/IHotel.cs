using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface IHotel
    {
        void Dodajrezerwacje(string imie, string nazwisko, int nrPokoju, double cenaZaDzien);
        void Odwolajrezerwacje();
    }
}
