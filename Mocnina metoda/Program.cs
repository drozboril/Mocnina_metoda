using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocnina_metoda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mocnina čísla\nZadejte číslo");
            double cislo = double.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte mocninu");
            double mocnina = double.Parse(Console.ReadLine());
            Console.WriteLine("Výsledek umocnění je {0}", Mocnina(cislo, mocnina));
            Console.ReadLine();
        }
        static double Mocnina(double cislo, double mocnina)
        {
            double vypocet = Math.Pow(cislo, mocnina);
            return vypocet;
        }
    }
}