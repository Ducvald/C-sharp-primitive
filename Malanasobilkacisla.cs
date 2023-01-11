using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyklyCviceni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int b = 1;
            int cislo;
            Console.WriteLine("napiš libovolné číslo a já ti vypíšu jeho násobky do 10");
            Console.WriteLine("----------------------------------------------------------");
            cislo = Convert.ToInt32(Console.ReadLine());
            do
            {
                i = b * cislo;
                Console.WriteLine(i);
                b++;
            }
            while (i < (cislo * 10));
            Console.WriteLine("Celá malá násobilka" + " " + cislo);
        }
    }
}