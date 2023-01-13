using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Váhanaměsíci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj, napiš mi tvou váhu a já ti řeknu kolik vážíš na ¨planetě či na měsíci podle tvého výběru.");
            double vaha = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Teď vyber z planet:");
            Console.WriteLine("Merkur");
            Console.WriteLine("Venuše");
            Console.WriteLine("Měsíc");
            Console.WriteLine("Mars");
            Console.WriteLine("Jupiter");
            Console.WriteLine("Saturn");
            Console.WriteLine("Uran");
            Console.WriteLine("Neptun");
            Console.WriteLine("Pluto");
            string odpověď = Console.ReadLine();

            if (odpověď == "Merkur")
            {
                double vahanamerkuru = 0.37 * vaha;
                Console.WriteLine(vahanamerkuru + " je tvoje váha na Merkuru.");
            }
            if (odpověď == "Venuše")
            {
                double vahanavenusi = 0.91 * vaha;
                Console.WriteLine(vahanavenusi + " je tvoje váha na Venuši.");
            }
            if (odpověď == "Měsíc")
            {
                double vahanamesici = 0.17 * vaha;
                Console.WriteLine(vahanamesici + " je tvoje váha na Měsíci.");
            }
            if (odpověď == "Mars")
            {
                double vahanamarsu = 0.37 * vaha;
                Console.WriteLine(vahanamarsu + " je tvoje váha na Marsu.");
            }
            if (odpověď == "Jupiter")
            {
                double vahanajupiteru = 2.36 * vaha;
                Console.WriteLine(vahanajupiteru + " je tvoje váha na Jupiteru.");
            }
            if (odpověď == "Saturn")
            {
                double vahanasaturnu = 1.07 * vaha;
                Console.WriteLine(vahanasaturnu + " je tvoje váha na Merkuru.");
            }
            if (odpověď == "Uran")
            {
                double vahanauranu = 0.89 * vaha;
                Console.WriteLine(vahanauranu + " je tvoje váha na Uranu.");
            }
            if (odpověď == "Neptunu")
            {
                double vahananeptunu = 1.12 * vaha;
                Console.WriteLine(vahananeptunu + " je tvoje váha na Neptunu.");
            }
            if (odpověď == "Pluto")
            {
                double vahanamerkuru = 0.06 * vaha;
                Console.WriteLine(vahanamerkuru + " je tvoje váha na Plutu.");
            }
        }
    }
}
