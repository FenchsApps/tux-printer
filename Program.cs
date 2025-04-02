using System;

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "--help")
            {
                Console.WriteLine("Usage: dino-print");
                Console.WriteLine("Prints a colorful ASCII Tux");
                return;
            }

            PrintColoredDino();
        }

        static void PrintColoredDino()
        {
            // ANSI color codes
            string black = "\x1b[37m";
            string yellow = "\x1b[33m";
            string reset = "\x1b[0m";

            Console.WriteLine();
            Console.WriteLine($"{black}       .888888:.{reset}");
            Console.WriteLine($"{black}      88888.888.{reset}");
            Console.WriteLine($"{yellow}    .88888888888{reset}");
            Console.WriteLine($"{yellow}    8' `88' `888{reset}");
            Console.WriteLine($"{yellow}    8 8 88 8 888{reset}");
            Console.WriteLine($"{yellow}    8:.,::,.:888{reset}");
            Console.WriteLine($"{black}   .8`::::::'888{reset}");
            Console.WriteLine($"{black}   88  `::'  888{reset}");
            Console.WriteLine($"{black}  .88        `888.{reset}");
            Console.WriteLine($"{black}.88'   .::.  .:8888.{reset}");
            Console.WriteLine($"{black}888.'   :'    `'88:88.{reset}");
            Console.WriteLine($"{black}8888'    '        88:88.{reset}");
            Console.WriteLine($"{black}8888'     .        88:888{reset}");
            Console.WriteLine($"{black}`88888     :        8:888'{reset}");
            Console.WriteLine($"{black} `.:.88    .       .::888'{reset}");
            Console.WriteLine($"{black}.:::::88   `      .:::::::.{reset}");
            Console.WriteLine($"{black}.::::::.8         .:::::::::{reset}");
            Console.WriteLine($"{black}::::::::..     .:::::::::'{reset}");
            Console.WriteLine($"{black} `:::::::::88888:::::::'{reset}");
            Console.WriteLine($"{black}      `:::'       `:'{reset}");
            Console.WriteLine();
            Console.WriteLine($"  {yellow}i use linux, btw{reset}");
            Console.WriteLine();
        }
    }
}
