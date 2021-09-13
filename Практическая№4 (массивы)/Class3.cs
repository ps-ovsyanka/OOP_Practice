using System;
using static System.Console;


namespace Практическая_4__массивы_
{
    class Class3
    {
        static void Mai4n()
        {
            int a, b;
            
            a = Int32.Parse(ReadLine());
            b = Int32.Parse(ReadLine());

            if (a == 3 && b == 3)
            {
                WriteLine("yes");
            } else
            {
                WriteLine("no");
            }
        }
    }
}
