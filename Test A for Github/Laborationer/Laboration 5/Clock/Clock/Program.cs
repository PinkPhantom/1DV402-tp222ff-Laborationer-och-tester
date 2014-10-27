using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
        
            
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Initiating");
            Console.ResetColor();


           ViewTestHeader("Test 1. \nTest av standardkonstruktorn");
           AlarmClock alarmTest1 = new AlarmClock();
            if (alarmTest1.ToString() == "0:00")
            {
                Console.WriteLine(alarmTest1.ToString());
            } 
            else
            {
                Console.WriteLine(alarmTest1.ToString());
                ViewErrorMessage("Timmen är inte inte i intervallet 0-23");
            }




            ViewTestHeader("Test 2. \nTest av konstruktorn med två parametrar, <9, 42>.");
            AlarmClock alarmtest2 = new AlarmClock(9, 42);            
                if (alarmtest2.ToString() == "9:42")
                {
                    Console.WriteLine(alarmtest2.ToString());
                }
                else
                {
                    Console.WriteLine(alarmtest2.ToString());
                    ViewErrorMessage("fel");
                }
            



            ViewTestHeader("Test 3. \nTest av konstrukorn med fyra parametrar, <13, 24, 7, 35>");
            AlarmClock alarmtest3 = new AlarmClock (13, 24, 7, 35);           
                if(alarmtest3.ToString() == "13:24 <7:35>")
                {
                    Console.WriteLine(alarmtest3.ToString());
                }
                else
                {
                    ViewErrorMessage("Fel");
                }
        




            ViewTestHeader("Test 4. \nStäller befintligt AlarmClock-objekt till 23:58 och låter den gå 13 minuter");
            alarmtest3.Hour = 23;
            alarmtest3.Minute = 58;
            Run(alarmtest3, 13);



            ViewTestHeader("Test 5. \nStäller befintligt AlarmClock-objektet till tiden 6:12 och alarmtiden till 6:15 och låter den gå 6 minute.");
            alarmtest3.Hour = 6;
            alarmtest3.Minute = 12;
            alarmtest3.AlarmHour = 6;
            alarmtest3.AlarmMinute = 15;
            Run(alarmtest3, 6);




            ViewTestHeader("Test 6. \nTestar egenskaperna så att undantag kastas då tid och alarmtid tilldelas felaktiga värden");
            AlarmClock alarmtest6 = new AlarmClock();

            try
            {
                alarmtest6.Hour = 24;
                ViewErrorMessage("ERROR, Timmen är inte i intervallet 0-23");
            }
            catch (ArgumentException) { /* Boom */ }
            try
            {
                alarmtest6.Minute = 60;
                ViewErrorMessage("ERROR, Minuten är inte i intervallet 0-23");
            }
            catch (ArgumentException) { /* Boom */ }
            try
            {
                alarmtest6.AlarmHour = 24;
                ViewErrorMessage("ERROR, AlarmTimmen är inte i intervallet 0-23");
            }
            catch (ArgumentException) { /* Boom */ }
            try
            {
                alarmtest6.AlarmMinute = 60;
                ViewErrorMessage("ERROR, AlarmMinuten är inte i intervallet 0-23");
            }
            catch (ArgumentException) { /* Boom */ }


            ViewTestHeader("Test 7. \nTestar konstruktorer så att undantag kastas då tid och alarmtid tilldelas felaktiga värden");
            try
            {
                AlarmClock alarmtest7 = new AlarmClock(24, 00, 00, 00);
                ViewErrorMessage("Timmen är inte i intervallet 0-23");
            }
            catch (ArgumentException) { /*Boom*/}

            try
            {
                AlarmClock alarmtest7 = new AlarmClock(00, 60, 00, 00);
                ViewErrorMessage("Minuten är inte i intervallet 0-59");
            }
            catch (ArgumentException) { /*Boom*/}

            try
            {
                AlarmClock alarmtest7 = new AlarmClock(00, 00, 24, 00);
                ViewErrorMessage("AlarmTimmen är inte i intervallet 0-23");
            }
            catch (ArgumentException) { /*Boom*/}

            try
            {
                AlarmClock alarmtest7 = new AlarmClock(00, 00, 00, 60);
                ViewErrorMessage("AlarmMinuten är inte i intervallet 0-59");
            }
            catch (ArgumentException) { /*Boom*/}




            Console.ReadKey();








       }

        private static void Run(AlarmClock ac, int minutes)
            {
                for (int i = 0; i < minutes; i++)
                {
                    if(ac.TickTock())
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("ALARM!");
                        Console.WriteLine(ac.ToString());
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(ac.ToString());
                    }
                }
            }


        private static void ViewErrorMessage(string error)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(error);
            Console.ResetColor();
        }

        private static void ViewTestHeader(string header)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            string line = "\n";
            Console.WriteLine(line);
            Console.WriteLine(header);
            Console.ResetColor();
        }

        
             }
           }
        
    

