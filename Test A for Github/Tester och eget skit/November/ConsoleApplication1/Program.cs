using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{      
    class Program
        {
            private static string _text;

            static void Main(string[] args)
            {
                Program.Text = "ABC";
                Program.Display();
            }

            public static string Text
            {
                get { return Program._text; }
                set { Program._text = value; }
            }

            private static void Display()
            {
                Console.WriteLine(_text);
            }
        
        }
   
}
