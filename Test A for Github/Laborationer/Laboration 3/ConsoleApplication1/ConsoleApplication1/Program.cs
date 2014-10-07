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


           // Console.Write("Ange total summa : ");
           // Salaries = int.Parse(Console.ReadLine());

            bool exit = false;

            int Salaries = 0;





















            do
            {

                while (Salaries < 2)
                {

                    Salaries = ReadInt();

                    if (Salaries < 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Du måste Skriva in mer än 2 löner!");
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

        private static int ReadInt()
        {
            string line;
            int readint;

            do
            {
                Console.Write("Ange antal löner som du vill skriva in: ");
                line = Console.ReadLine();

                try
                {
                    readint = Int32.Parse(line);
                    break;
                }
                catch (FormatException)
                {

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Fel! '{0}' kan inte tolkas som ett heltal.", line);
                    Console.ResetColor();


                }
                catch (OverflowException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Fel! '{0}' kan inte tolkas som ett heltal.", line);
                    Console.ResetColor();
                }


            }
            while (true);
            return readint;
        }

        private static void Answer(int Salaries)
        {

            int total;

            int highest;

            int lowest;

            int spread;

            int average;

            int median1;

            int median2;

            int median3;

            int median;

            total = 0;


            int[] paychecks = new int[Salaries];
            int[] sorted = new int[Salaries];

            for (int i = 0; i < Salaries; i++)
            {

                Console.Write("Var god skriv in lön {0}: ", i + 1);
                paychecks[i] = ReadInt();

                total += paychecks[i];

                sorted[i] = paychecks[i];

            }



            Array.Sort(sorted);

            highest = sorted.Max();
            lowest = sorted.Min();
            spread = highest - lowest;
            average = total / Salaries;


            if (Salaries % 2 == 0)
            {

                median2 = Salaries / 2;
                median3 = Salaries / 2;
                --median3;
                median = sorted[median2] + sorted[median3];
                median1 = median / 2;

            }
            else
            {

                median = Salaries / 2;
                median1 = sorted[median];
            }


           

            Console.WriteLine("Kvitto");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Highest paycheck was: {0} ", highest);
            Console.WriteLine("Lowest paycheck was: {0} " ,lowest);
            Console.WriteLine("Average paycheck was: {0} ", average);
            Console.WriteLine("The Median paycheck was: {0} ", median1);
            Console.WriteLine("The salary spread was: {0} ", spread);
            Console.WriteLine("--------------------------");

            for (int i = 0; i < paychecks.Length; i += 3)
            {
                for (int j = 0; i + j < paychecks.Length && j < 3; j++)
                {

                    Console.Write("{0,3}", paychecks[i + j]);
                }
            }
     
        }


      
        
    }
}
