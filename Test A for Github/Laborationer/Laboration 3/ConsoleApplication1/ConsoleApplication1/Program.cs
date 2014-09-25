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
            bool exit = false;

            int Salaries = 0;

            do
            {

                while (Salaries < 2)
                {

                    Console.Write("Ange total summa : ");
                    Salaries = int.Parse(Console.ReadLine());


                    if (Salaries < 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Du måste ange en Summa som är högre än erhållet belopp.");
                        Console.ResetColor();
                    }
                    else
                    {
                        break;
                    }
                }

                Answer(Salaries);

                Console.WriteLine();

                Console.BackgroundColor = ConsoleColor.DarkGreen;

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Tryck på valfri tangent för att göra en ny beräkning - Escape avslutar programmet.");

                Console.ResetColor();

                ConsoleKeyInfo end;

                end = Console.ReadKey(true);

                if (end.Key == ConsoleKey.Escape)

                {
                    return;
                }
                Salaries = 0;

            }
            while (!exit);
        }

        private static void Answer(int Salaries)
        {


            int numberof;

            int total;

            int highest;

            int lowest;

            int spread;

            int average;

            int median1;

            int median2;

            total = 0;


            int[] paychecks = new int[Salaries];
            int[] sorted = new int[Salaries];


            for (int i = 0; i < Salaries; i++)
            {


                Console.Write("Var god skriv in lön {0}: ", i + 1);
                paychecks[i] = int.Parse(Console.ReadLine());

                total += paychecks[i];

                sorted[i] = paychecks[i];


            }

            Array.Sort(sorted);

            highest = sorted.Max();
            lowest = sorted.Min();
            spread = highest - lowest;
            average = total / Salaries;

            median1 = Salaries / 2;

            median2 = sorted[median1];


            Console.WriteLine("Kvitto");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Highest paycheck was: {0} ", highest);
            Console.WriteLine("Lowest paycheck was: {0} " ,lowest);
            Console.WriteLine("Average paycheck was: {0} ", average);
            Console.WriteLine("The Median paycheck was: {0} ", median2);
            Console.WriteLine("The salary spread was: {0} ", spread);
            Console.WriteLine("--------------------------");

            for (int i = 0; i < sorted.Length; i += 3)
            {
                for (int j = 0; i + j < sorted.Length && j < 3; j++)
                {

                    Console.Write("{0,7}", sorted[i + j]);
                }
            }
     
        }


      
        
    }
}
