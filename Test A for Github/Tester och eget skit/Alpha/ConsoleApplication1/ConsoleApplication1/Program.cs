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
            int points;
            int students;
            double average;


            Console.Write("Please enter the total score: ");
            points = int.Parse(Console.ReadLine());

            Console.Write("Please enter the total number of students: ");
            students = int.Parse(Console.ReadLine());

            average = (double)points / students;

            Console.WriteLine("The average score of the class is {0:f1}.", average);

            Console.ReadKey();
        }
    }
}
