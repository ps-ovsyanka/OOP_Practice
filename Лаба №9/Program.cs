using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Laba9
{
    public class Program
    {
        public static void WriteErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void WriteInviteToEnter(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(message);
            Console.ResetColor();
        }
        public static int ReadValue(string inviteMsg = "Введите число", string errMsg = "Произошла ошибка ввода, повторите попытку", int min = int.MinValue, int max = int.MaxValue)
        {
            int number = 0; bool ok;
            do
            {
                ok = true;
                WriteInviteToEnter(inviteMsg);
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number < min || number > max)
                    {
                        WriteErrorMessage(errMsg);
                        ok = false;
                    }
                }
                catch (Exception e)
                {
                    WriteErrorMessage(e.Message);
                    ok = false;
                }
            } while (!ok);
            return number;
        }
        
        public static void taskObj()
        {
            string menu = "1. Создать объект\n" +
                            "2. Добавить копейку\n" +
                            "3. Удалить копейку\n" +
                            "4. Вычесть объект\n" +
                            "5. Вычесть число\n" +
                            "6. Вычесть из числа\n" +
                            "7. Привести к int\n" +
                            "8. Привести к double\n" +
                            "0. Назад";

            int key = 1;
            Money sum = new Money();
            while (key != 0)
            {
                Clear();
                WriteLine(sum.ToString());
                WriteLine(menu);
                key = ReadValue("=> ", "Нет такого варианта", 0, 8);
                try
                {
                    switch (key)
                    {
                        case 1:
                            int rub = ReadValue("Введите рубли\n", "Ошибка ввода числа", 0);
                            int cop = ReadValue("Введите копейки\n", "Ошибка ввода числа", 0);
                            sum = new Money(rub, cop);
                            break;
                        case 2:
                            sum++;
                            break;
                        case 3:
                            sum--;
                            break;
                        case 4:
                            int rb = ReadValue("Введите рубли\n", "Ошибка ввода числа", 0);
                            int cp = ReadValue("Введите копейки\n", "Ошибка ввода числа", 0);
                            Money m = new Money(rb, cp);
                            sum = sum - m;
                            break;
                        case 5:
                            int k = ReadValue("Введите число\n", "Ошибка ввода числа.", 0);
                            sum = sum - k;
                            break;
                        case 6:
                            k = ReadValue("Введите число\n", "Ошибка ввода числа", 0);
                            sum = k - sum;
                            break;
                        case 7:
                            WriteLine((int)sum);
                            WriteErrorMessage("Для продолжения нажмите любую клавишу");
                            ReadKey();
                            break;
                        case 8:
                            WriteLine((double)sum);
                            WriteErrorMessage("Для продолжения нажмите любую клавишу");
                            ReadKey();
                            break;
                        case 0:
                            break;
                    }
                }
                catch (Exception e)
                {
                    WriteErrorMessage("Ошибка");
                    WriteErrorMessage(e.Message);
                    WriteErrorMessage("Для продолжения нажмите любую клавишу");
                    ReadKey();
                }

            }
        }

        public static void taskArray()
        {
            string menu_arr = "1. Создать массив автоматически\n" +
                                "2. Создать массив вручную\n" +
                                "3. Найти максимум\n" +
                                "4. Изменить элемент по индексу\n" +
                                "5. Получить количество созданных объектов\n" +
                                "0. Назад";
            int key = 1;
            int size;
            MoneyArray arr = new MoneyArray();
            while (key != 0)
            {
                Clear();
                WriteLine(arr.ToString());
                WriteLine(menu_arr);
                key = ReadValue("=> ", "Нет такого варианта", 0, 5);
                try
                {
                    switch (key)
                    {
                        case 1:
                            size = ReadValue("Введите размер массива(1..10)\n", "Размер должен быть от 1 до 10", 1, 10);
                            int max = ReadValue("Введите максимальное значение в рублях\n", default, 0);
                            arr = new MoneyArray(size, max);
                            break;
                        case 2:
                            size = ReadValue("Введите размер массива(1..10)\n", "Размер должен быть от 1 до 10", 1, 10);
                            arr = new MoneyArray(size);
                            break;
                        case 3:
                            if (arr.Length != 0)
                            {
                                WriteLine($"Максимальный элемент: {arr.Max()}");
                                WriteLine("Для продолжения нажмите любую клавишу");
                                ReadKey();
                            }
                            else
                            {
                                WriteErrorMessage("Массив не создан.\n Для продолжения нажмите любую клавишу");
                                ReadKey();
                            }
                            break;
                        case 4:
                            if (arr.Length != 0)
                            {
                                int index = ReadValue("Введите индекс\n", $"Ошибка. Индекс должен быть от 0 до {arr.Length - 1}", 0, arr.Length - 1);
                                int rub = ReadValue("Введите рубли\n", "Ошибка ввода числа", 0);
                                int cop = ReadValue("Введите копейки\n", "Ошибка ввода числа", 0);
                                arr[index-1] = new Money(rub, cop);
                                WriteLine("Значение изменено. Для продолжения нажмите любую клавишу.");
                                ReadKey();
                            }
                            else
                            {
                                WriteErrorMessage("Массив не создан.\n Для продолжения нажмите любую клавишу");
                                ReadKey();
                            }
                            break;
                        case 5:
                            WriteLine("Количество созданных элементов: " + Money.Count);
                            WriteErrorMessage("Для продолжения нажмите любую клавишу");
                            ReadKey();
                            break;                            
                        case 0:
                            break;
                    }
                }
                catch (Exception e)
                {
                    WriteErrorMessage("Ошибка\n" + e.Message + "\nДля продолжения нажмите любую клавишу");
                    ReadKey();
                }

            }
        }

        static void Main(string[] args)
        {
            string mainMenu = "1. Действия с объектом\n" +
                                "2. Действия с массивом\n" +
                                "0. Выход";
            int key = 1;

            while (key != 0)
            {
                Clear();
                WriteLine(mainMenu);
                key = ReadValue("=> ", "Нет такого варианта", 0, 2);
                switch (key)
                {
                    case 1:
                        taskObj();
                        break;
                    case 2:
                        taskArray();
                        break;
                    case 0:
                        break;
                }
            }            
        }
    }
}
