using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procvicovani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo1;
            int cislo2;
            Console.WriteLine("Ahoj já jsem primitivní kalkulačka, napíšeš mi 2 čísla a ja ti provedu veškeré matematické operace!");
            Console.WriteLine("napiš mi první číslo");
            cislo1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("napiš mi druhé číslo");
            cislo2 = Convert.ToInt32(Console.ReadLine());
            int soucet = cislo1 + cislo2;
            int odcitani = cislo1 - cislo2;
            float deleni = cislo1 / (float)cislo2;
            int nasobeni = cislo1 * cislo2;
            int modulo = cislo1 % cislo2;
            Console.WriteLine("___________________________");
            Console.WriteLine(cislo1 + " + " + cislo2 + " = " + soucet);
            Console.WriteLine(cislo1 + " - " + cislo2 + " = " + odcitani);
            Console.WriteLine(cislo1 + " / " + cislo2 + " = " + deleni);
            Console.WriteLine(cislo1 + " * " + cislo2 + " = " + nasobeni);
            Console.WriteLine(cislo1 + " % " + cislo2 + " = " + modulo);
        }
    }
}
