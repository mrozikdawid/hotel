﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Gosc
    {
        private string imie;
        private string nazwisko;

        public Gosc(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public override string ToString() // przesłonięcie metody ToString (1b)
        {
            return "Gosc" + imie + nazwisko ;
        }
    }
}
