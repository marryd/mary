using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MaryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            showStartMenu();

            var function = new ConsoleKeyInfo();

            while (true)
            {
                function = Console.ReadKey();

                if (function.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("\n.....BYE, BYE......");
                    Thread.Sleep(3000);
                    return;
                }

                Console.WriteLine(string.Format("\nYou pressed '{0}' button.", function.KeyChar));
            }

         
        }

        private static void showStartMenu()
        {
            Console.WriteLine("*********** Welcome Menu ***********");
            Console.WriteLine("\tA\t\t - Add");
            Console.WriteLine("\tD\t\t - Delete");
            Console.WriteLine("\tEsc\t\t - Quit");
            Console.WriteLine();

        }
    }
}
