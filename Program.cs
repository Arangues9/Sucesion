using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sucesion
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int n = 1;
            int p = 0;
            int i = 0;
            while (true)
         
            {
                if (n%2==0)
                {
                    a = a + 3;
                    p = p + a;
                    Console.WriteLine(a);
                    n++;
                }
                else
                {
                    a = a + 2;
                    i = i + a;
                    Console.WriteLine(a);
                    n++;
                }
                if (a >= 1800 || a >= 1800)
                {
                    break;
                }
        }
            int suma = p + i;
            Console.WriteLine("suma de la sucesion: " + suma);
            Console.ReadLine();
    }
}
}