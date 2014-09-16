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
            int salaries;

            salaries = 0;

            do
            {
                while (salaries < 2)

                {
                salaries = ReadInt();

                if (salaries < 2)
                {
                    Console.BackgroundColor = ConsoleColor.Red;

                }
                }

            }

        }
    }
}
