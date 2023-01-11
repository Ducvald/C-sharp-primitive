using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctverecvypocty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napiš mi o jaký geometrický útvar se jedná- čtverec/trojuhelník/obdelník, trojuhelnik musí být rovnoramenný");
            string tvar = Console.ReadLine();

            if (tvar == "čtverec")
            {
                Console.WriteLine("napiš mi délku strany");
                double čtverecdelka = Convert.ToDouble(Console.ReadLine());
                double Octverec = 4 * čtverecdelka;
                double Sctverec = čtverecdelka * čtverecdelka;
                Console.WriteLine("Obvod je " + Octverec + " a Obsah je " + Sctverec);
                Environment.Exit(0);
            }
            if (tvar == "trojuhelník")
            {
                Console.WriteLine("napiš mi délku strany");
                double trojuhelnikdelka = Convert.ToDouble(Console.ReadLine());
                double Otrojuhelnik = 3 * trojuhelnikdelka;
                double steny = trojuhelnikdelka * trojuhelnikdelka;
                double Strojuhelnik = steny / 2;
                Console.WriteLine("Obvod je " + Otrojuhelnik + " a Obsah je " + Strojuhelnik);
                Environment.Exit(0);
            }
            if (tvar == "obdelník")
            {
                Console.WriteLine("napiš mi délku první strany");
                double obdelnikdelka1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("napiš mi délku druhé strany");
                double obdelnikdelka2 = Convert.ToDouble(Console.ReadLine());
                double Oobdelnik = obdelnikdelka1 * 2 + obdelnikdelka2 * 2;
                double Sobdelnik = obdelnikdelka1 * obdelnikdelka2;
                Console.WriteLine("Obvod je " + Oobdelnik + " a Obsah je " + Sobdelnik);
                Environment.Exit(0);
            }
        }
    }
}
