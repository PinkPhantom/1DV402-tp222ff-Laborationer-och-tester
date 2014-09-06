using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_A_for_Github
{
    class Program
    {
        static void Main(string[] args)
        {

            int domo;
            int arigato;
            int roboto;

            string mr;

            Console.Write("Skriv det första heltalet : ");
            mr = Console.ReadLine();
            domo = int.Parse(mr);

            Console.Write("Skriv det andra heltalet : ");
            mr = Console.ReadLine();
            arigato = int.Parse(mr);

            roboto = domo + arigato;

            Console.Write("Svaret är : {0}", roboto);

            Console.ReadKey();

        }
    }
}
