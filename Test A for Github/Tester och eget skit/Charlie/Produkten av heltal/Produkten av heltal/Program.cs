using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produkten_av_heltal
{
    class Program
    {
        static void Main(string[] args)
        {
           int max;
           int hopp;
           long product = 1;


            // int max ökar hur högt det gångar med sig själ int hopp bestämmer var den börjar mellan max och hopp


           Console.Write("Please enter the maximum multiplier: ");
          max = int.Parse(Console.ReadLine());

          Console.Write("Please enter the number to begin the multiplication: ");
          hopp = int.Parse(Console.ReadLine());



           for (int i = hopp; i <= max; i++)
               //Product* tar emot loopen alla gånger fram tills den avbryter sig (altså när max antalet har nåtts)
               product *= i;







             Console.WriteLine("The product of all the numbers from {0} to {1} is {2}",hopp ,max , product);
             Console.ReadKey();



        }
    }
}
