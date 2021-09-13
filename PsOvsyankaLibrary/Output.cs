using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PsOvsyankaLibrary
{
    public class Output
    {
        public static void WriteErrorMessage(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine(msg);
            WriteLine("Для продолжения нажмите любую клавишу...");
            ResetColor();
            ReadKey();
        }
        public static void WriteMessage(string msg = "")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            WriteLine(msg);
            WriteLine("Для продолжения нажмите любую клавишу...");
            ResetColor();
            ReadKey();
        }
    }
}
