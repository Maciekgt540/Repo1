using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int n = 2147483640;
            
            for (i = 1; i < n; i++)
            {
                Console.WriteLine(n);
                n = n + 1 ;

            }
            Console.WriteLine(Int64.MaxValue);
            Console.WriteLine(float.MinValue);

            Console.ReadKey();

            Console.WriteLine(Int64.MaxValue);
            Console.WriteLine(Int32.MinValue);
        }
    }
}
