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


            double total = 2;
            int topay = 0;


            do
            {
                while (total > topay)
                {

                    Console.Write("Ange total summa : ");
                    total = double.Parse(Console.ReadLine());

                    Console.Write("Ange erhållet belopp: ");
                    topay = int.Parse(Console.ReadLine());

                    if (total > topay)
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

                Answer(total, topay);

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

                total = 2;
                topay = 0;
            }
            while (!exit);



        }

        private static void Answer(double total, int topay)
        {

            //double total 
            double avrundning;
            double total2;
            //int topay
            int back;

            total = Roundoff(total, topay, out avrundning, out total2, out back);



            Console.WriteLine("Kvitto");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Totalt        : {0:f2}kr", total2);
            Console.WriteLine("Öresavrunding : {0:f2}kr", avrundning);
            Console.WriteLine("Att betala    : {0}kr", total);
            Console.WriteLine("Kontant       : {0}kr", topay);
            Console.WriteLine("Tillbaka      : {0}kr", back);
            Console.WriteLine("--------------------------");

            int[] money1 = new int[7] { 0, 0, 0, 0, 0, 0, 0};
            int[] money = new int[7] { 500, 100, 50, 20, 10, 5, 1 };
            string[] receive = new string[7] { "500-lappar", "100-lappar", "50-lappar", "20-lappar", "10-kronor", "5-kronor", "1-kronor" };

            back = SplitIntoDenominations(back, money1, money, receive);












        }

        private static int SplitIntoDenominations(int back, int[] money1, int[] money, string[] receive)
        {

            for (int i = 0; i < 7; i++)
            {

                money1[i] = back / money[i];
                back %= money[i];
                Console.WriteLine("{0} : {1}st ", receive[i], money1[i]);

            }

            return back;
        }


        private static double Roundoff(double total, int topay, out double avrundning, out double total2, out int back)
        {

            total2 = total;
            total = (uint)Math.Round(total2);
            avrundning = (int)total - total2;
            back = topay - (int)total;
            return total;
        }
    }
}
