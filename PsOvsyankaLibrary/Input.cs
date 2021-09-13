using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PsOvsyankaLibrary
{
    public class Input
    {



        public static int InputInt(int min, int max, string invite = "", string error = "Ошибка ввода целого числа")
        {
            bool flag = false;
            int res = 0;
            while (!flag)
            {
                Write(invite);
                flag = Int32.TryParse(ReadLine(), out res);
                if (!flag)
                {
                    WriteLine(error);
                }
                else if (res < min)
                {
                    WriteLine("Ошибка. Минимум " + min);
                    flag = false;
                }
                else if (res > max)
                {
                    WriteLine("Ошибка. Максимум " + max);
                    flag = false;
                }
            }
            return res;
        }

        public static int InputInt(string invite = "", string error = "Ошибка ввода целого числа")
        {
            bool flag = false;
            int res = 0;
            while (!flag)
            {
                Write(invite);
                flag = Int32.TryParse(ReadLine(), out res);
                if (!flag)
                {
                    WriteLine(error);
                }
            }
            return res;
        }

        /// <summary>
        /// Выбор пункта меню. Пункты по порядку начиная с нуля.
        /// </summary>
        /// <param name="menu">Текст меню</param>
        /// <param name="countItem">Количество пунктов</param>
        /// <returns></returns>
        public static int SelectMenuItem(string[] menu)
        {
            for (int i=0; i < menu.Length; i++)
            {
                WriteLine((i + 1) + ". " + menu[i]);
            }
            WriteLine("0. Выход");
            int current = InputInt(0, menu.Length, "=>", "Ошибка ввода");
            return current;
        }

        public static string InputLine(string msg = "=>")
        {
            Write(msg);
            return ReadLine();
        }
    }
}
