using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tab = new string[5];
            tab[0] = "Marc";
            tab[1] = "Rock";
            tab[2] = "Eyram";
            tab[3] = "Potus";
            tab[4] = "Toto";

            var c = tab.ToList();

            var r = c.Where(m => m == "Marc");

            var r1 = 


        }
    }
}
