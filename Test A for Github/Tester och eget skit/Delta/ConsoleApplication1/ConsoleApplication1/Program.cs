using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;


            value = int.Parse(Console.ReadLine());

            if (value < 10)
            {

                Console.WriteLine("Värdet {0} är mindre än 10", value);
            }
            
                else if (value == 10)
            {
                Console.WriteLine("Värdet {0} är lika med 10", value);
            }                

            else

             Console.WriteLine("Värdet {0} är större än 10", value);


            Console.ReadKey();



        }
    }
}
