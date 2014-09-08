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
            const int password = 9846;
            int enter;


            Console.Write("Please enter the password: ");
            enter = int.Parse(Console.ReadLine());

            if (enter == password)
            {
                Console.WriteLine("Correct password has been entered.");
            }
            else
            {
                Console.WriteLine("Wrong password try again.");
            }
            Console.WriteLine("Ending simulation");
            Console.ReadKey();
            

        }
    }
}
