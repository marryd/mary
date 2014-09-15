using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            showStartMenu();

            var function = new ConsoleKeyInfo();

            do
            {
                function = Console.ReadKey();

                Console.WriteLine(string.Format("\nYou pressed '{0}' button.", function.KeyChar));

            }while(function.Key != ConsoleKey.Escape);
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
