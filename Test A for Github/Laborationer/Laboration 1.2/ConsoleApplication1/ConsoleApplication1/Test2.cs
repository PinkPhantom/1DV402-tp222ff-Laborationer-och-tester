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

            int femhundra;
            int hundra;
            int femtio;
            int tjugo;
            int tio;
            int fem;
            int enkrona;


            Console.WriteLine("Kvitto");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Totalt        : {0:f2}kr", total2);
            Console.WriteLine("Öresavrunding : {0:f2}kr", avrundning);
            Console.WriteLine("Att betala    : {0}kr", total);
            Console.WriteLine("Kontant       : {0}kr", topay);
            Console.WriteLine("Tillbaka      : {0}kr", back);
            Console.WriteLine("--------------------------");


            back = SplitintoDenominations(back, out femhundra, out hundra, out femtio, out tjugo, out tio, out fem, out enkrona);





        }

        private static double Roundoff(double total, int topay, out double avrundning, out double total2, out int back)
        {

            total2 = total;
            total = (uint)Math.Round(total2);
            avrundning = (int)total - total2;
            back = topay - (int)total;
            return total;
        }

        private static int SplitintoDenominations(int back, out int femhundra, out int hundra, out int femtio, out int tjugo, out int tio, out int fem, out int enkrona)
        {
            femhundra = back / 500;
            back %= 500;
            Console.WriteLine("500-lappar : {0}st ", femhundra);
            hundra = back / 100;
            back %= 100;
            Console.WriteLine("100-lappar : {0}st ", hundra);
            femtio = back / 50;
            back %= 50;
            Console.WriteLine("50-lappar : {0}st ", femtio);
            tjugo = back / 20;
            back %= 20;
            Console.WriteLine("20-lappar : {0}st ", tjugo);
            tio = back / 10;
            back %= 10;
            Console.WriteLine("10-kronor : {0}st ", tio);
            fem = back / 5;
            back %= 5;
            Console.WriteLine("5-kronor : {0}st ", fem);
            enkrona = back / 1;
            back %= 1;
            Console.WriteLine("1-kronor : {0}st ", enkrona);
            return back;
        }
    }
}
