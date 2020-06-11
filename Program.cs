using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Abstraction.AbstractClass;
using Abstraction.Interface;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Kosmetik kosmetik1;

              kosmetik1 = new Foundation();
              kosmetik1.JenisBenda();

              Console.WriteLine();
              kosmetik1 = new Concealer();
              kosmetik1.JenisBenda();

              Console.WriteLine();
              kosmetik1 = new Babypowder();
              kosmetik1.JenisBenda();*/

            IKosmetik kosmetik1;

            kosmetik1 = new Foundation();
            kosmetik1.JenisBenda();

            Console.WriteLine();
            kosmetik1 = new Concealer();
            kosmetik1.JenisBenda();

            Console.WriteLine();
            kosmetik1 = new BabyPowder();
            kosmetik1.JenisBenda();

            Console.ReadKey();
        }
    }
}
