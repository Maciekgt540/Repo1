using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOverload
{
    class Program
    {
        static void Main(string[] args)
        {

            Overload Over = new Overload();
            Overload Over2 = new Overload(4, 10, 30);

            Console.WriteLine("a*b*c:");



            Console.WriteLine(Over2.Multiply());
            Console.WriteLine(Over.Multiply());

            Console.WriteLine(Overload.Add(1, 2, 3, 4));


            Console.ReadKey();


        }
    }
}
