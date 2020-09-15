using System;

namespace TheSoundCollector
{
    class Program
    {
        static void Main()
        {
            /* The Sound Colloctor - exploring the world of sound.
          A library of found sounds and the tools used to find them.
        */
            string author = "T. Scott George";
            string appName = "The Sound Collector";
            string appVersion = "1.0";


            Console.WriteLine("{0} {1} {2}", author, appName, appVersion );
            
            //Making it pretty :)
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Collecting Sounds From Everywhere! ");

            Console.ResetColor();



        }
    }
}
