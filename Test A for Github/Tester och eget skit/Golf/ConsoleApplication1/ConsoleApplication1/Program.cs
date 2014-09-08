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
            double attbetala;
            double betalamed;




            Console.Write("Ange total summa    : ");
            attbetala = int.Parse(Console.ReadLine());



            Console.Write("Ange erhållet belopp: ");
            betalamed = int.Parse(Console.ReadLine());


            Console.WriteLine("Kvitto");
            Console.WriteLine("--------------------------");

            Console.WriteLine("Totalt : {0}kr", attbetala);



            Console.WriteLine("Kontant : {0}kr", betalamed);







            Console.ReadKey();













        }
    }
}
