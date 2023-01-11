using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsahaObvodkruhu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napiš mi poloměr kruhu a já vypíšu jeho obsah a obvod");
            double r = Convert.ToDouble(Console.ReadLine());
            double S = 3.14 * r * r;
            double O = 2 * 3.14 * r;
            Console.WriteLine("Obvod kruhu je přibližně " + O);
            Console.WriteLine("Obsah kruhu je přibližně " + S);
        }
    }
}
