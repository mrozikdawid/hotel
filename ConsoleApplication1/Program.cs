using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static Hotel hotelik = new Hotel();
        private static char klawisz;
        public static void Legenda()
        {
            Console.WriteLine("Co chcesz zrobić");
            Console.WriteLine("A - Ustaw Date");
            Console.WriteLine("B - dodaj rezerwacje");
            Console.WriteLine("C - usuń rezerwacje");
            Console.WriteLine("D - wypisz rezerwacje");
            Console.WriteLine("X - wyjscie z aplikacji");

        }

        public static void Wczytajklawisz()
        {
            klawisz = Convert.ToChar(Console.ReadLine());
        }

        public static void Dzialanie()
        {
            if (klawisz == 'A' || klawisz == 'a')
            {
                Console.WriteLine("Podaj date rezeerwacji w formacie yyyy-MM-dd: ");
                string wejscie = Console.ReadLine();
                DateTime data;
                while (!DateTime.TryParse(wejscie, out data))
                {
                    Console.WriteLine("błedna data , podaj date w formacie yyyy-MM-dd , i większa od daty dzisiejszej ");
                    wejscie = Console.ReadLine();
                }


            }
            else if (klawisz == 'B' || klawisz == 'b')
            {
                int numer = 0;
                string wej2 = "";
                while(numer <= 0)
                {
                    Console.WriteLine("Podaj numer pokoju ");
                    wej2 = Console.ReadLine();
                    Int32.TryParse(wej2, out numer);
                }

                double cena = 0;
                while (cena <=0)
                {
                    Console.WriteLine("Podaj cene za dzień: ");
                    wej2 = Console.ReadLine();
                    Double.TryParse(wej2, out cena);

                }
            }
        }
        static void Main(string[] args)
        {
            Legenda();
            Wczytajklawisz();

            Dzialanie();

            Console.ReadKey();
        }
    }
}
