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
            //Variabler
            
            int betalamed;
            int tillbaka;            
            int attbetala2;

            int femhundra;
            int hundra;
            int femtio;
            int tjugo;
            int tio;
            int fem;
            int enkrona;

            double efteravrudning;
            double attbetala;
            double avrundning;
            
            



            ReadPositiveDouble(out betalamed, out attbetala2, out attbetala, out avrundning);


            efteravrudning = ReadUint(attbetala, avrundning);





            tillbaka = ReadConsole(betalamed, efteravrudning, attbetala, avrundning);

            tillbaka = SplitIntodenominations(tillbaka, out femhundra, out hundra, out femtio, out tjugo, out tio, out fem, out enkrona);

            



            Console.ReadKey();













        }

        private static int SplitIntodenominations(int tillbaka, out int femhundra, out int hundra, out int femtio, out int tjugo, out int tio, out int fem, out int enkrona)
        {
            femhundra = tillbaka / 500;
            tillbaka %= 500;

            Console.WriteLine("500-lappar  : {0}st ", femhundra);

            hundra = tillbaka / 100;
            tillbaka %= 100;

            Console.WriteLine("100-lappar  : {0}st ", hundra);

            femtio = tillbaka / 50;
            tillbaka %= 50;

            Console.WriteLine("50-lappar  : {0}st ", femtio);

            tjugo = tillbaka / 20;
            tillbaka %= 20;

            Console.WriteLine("20-lappar  : {0}st ", tjugo);

            tio = tillbaka / 10;
            tillbaka %= 10;

            Console.WriteLine("10-kronor  : {0}st ", tio);

            fem = tillbaka / 5;
            tillbaka %= 5;

            Console.WriteLine("5-kronor  : {0}st ", fem);

            enkrona = tillbaka / 1;
            tillbaka %= 1;

            Console.WriteLine("1-kronor  : {0}st ", enkrona);
            return tillbaka;
        }

        private static int ReadConsole(int betalamed, double efteravrudning, double attbetala, double avrundning)
        {
            int tillbaka;
            tillbaka = betalamed - (int)efteravrudning;

            Console.WriteLine("Kvitto");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Totalt          : {0:f2}kr", attbetala);
            Console.WriteLine("Öresavrunding   : {0:f2}kr", avrundning);
            Console.WriteLine("Att betala      : {0}kr", efteravrudning);
            Console.WriteLine("Kontant         : {0}kr", betalamed);
            Console.WriteLine("Tillbaka        : {0}kr", tillbaka);
            Console.WriteLine("--------------------------");
            return tillbaka;
        }

        private static double ReadUint(double attbetala, double avrundning)
        {
            double efteravrudning;

            if (avrundning < 0.5)
            {
                efteravrudning = attbetala - avrundning;
            }
            else
            {
                efteravrudning = attbetala - avrundning + 1;
            }
            return efteravrudning;
        }

        private static void ReadPositiveDouble(out int betalamed, out int attbetala2, out double attbetala, out double avrundning)
        {




            Console.Write("Ange total summa    : ");
            attbetala = double.Parse(Console.ReadLine());
            Console.Write("Ange erhållet belopp: ");



            betalamed = int.Parse(Console.ReadLine());
            attbetala2 = (int)attbetala;
            avrundning = (double)attbetala - attbetala2;
        }
    }
}
