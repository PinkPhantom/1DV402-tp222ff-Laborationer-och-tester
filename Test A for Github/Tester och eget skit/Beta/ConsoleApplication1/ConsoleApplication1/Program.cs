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
            int vinst = 0;
            // Lotter bestämmer hur högt den kan räkna till, lottpris bestämmer vad den ska hoppa mellan varje räkning

            int lotter;
            int lottpris;
            Console.Write("Vad är den högsta summan?: ");
            lotter = int.Parse(Console.ReadLine());

            Console.Write("Vad är mellanskillnaden mellan varje lott?: ");
            lottpris = int.Parse(Console.ReadLine());
            for (int i = 0; i <=(lotter); i += (lottpris))

                vinst += i;

            Console.WriteLine(vinst);

            Console.ReadKey();

        }
    }
}
