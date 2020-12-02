using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        public enum boja
        {
            crvena = 1,
            plava=2

        }
        static void Main(string[] args)
        {
            Console.WriteLine(boja.crvena.GetHashCode());
        }
    }
}
