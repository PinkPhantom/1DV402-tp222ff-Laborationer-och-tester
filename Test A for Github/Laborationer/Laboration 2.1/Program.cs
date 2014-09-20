using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int colour = 25;


            for (int rad = 0; rad < colour; rad++)
            {
                switch (rad % 3)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;

                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }   

                if (rad % 2 == 1)
                {

                    Console.Write(" ");


                }
                for (int col = 0; col < 39; col++)
                {

                    Console.Write("* ");


                }

                Console.WriteLine();
                
            }

            Console.ReadKey();
        }
    }
}
