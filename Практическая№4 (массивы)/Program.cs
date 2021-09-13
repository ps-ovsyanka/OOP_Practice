using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_4__массивы_
{
    class Program
    {
        public static void WriteErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void WriteInviteToEnter(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
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

        static int ReadValue()
        {
            int number = 0;
            bool ok;

            do
            {
                ok = true;
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    ok = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Неверно введено число. Введите еще раз");
                    ok = false;
                }
            } while (!ok);

            return number;
        }

        static bool isEmpty(int[] arr)
        {
            return arr.Length <= 0;
        }

        static void PrintArray (int[] arr)
        {
            if(!isEmpty(arr))
            {
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }
                Console.Write("\n");
            }  
            else
            {
                Console.WriteLine("Массив не создан");
            }
        }

        static int[] CreateRandomArray (int n)
        {
            Random rand = new Random();
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(99);
            }
            return array;
        }
        static int[] CreateArray(int n)
        {
            int[] arr = new int[n];
            Console.WriteLine($"Введите элементы массива");
            for(int i =0;i< n; i++)
            {
                arr[i] = ReadValue("", default);
            }
            return arr;
        }

        static void PrintMenu()
        {
            Console.Write("1. Создать массив\n" +
                "2. Удалить четные элементы\n" +
                "3. Добавить элементы\n" +
                "4. Сдвиг вправо\n" +
                "5. Найти элемент по значению\n" +
                "6. Сортировка методом простого выбора\n" +
                "7. Бинарный поиск\n" +
                "0. Выход\n");
        }

        static int[] Delete (int[] arr)
        {
            int[] temp = new int[0];
            //вычисление кол-ва нечетных
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                temp = new int[count];

                //копирование нечетных элементов
                for (int i = 0, j = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        temp[j] = arr[i];
                        j++;
                    }
                }
                return temp;
            } else
            {
                return new int[0];
            }
            
        }

        static int[] Add (int[] arr, int k, int[] values)
        {
            int m = values.Length;
            int[] temp;

            //проверка на границу массива
            if (k <= arr.Length + 1 && k > 0 && m >= 0)
            {
                temp = new int[arr.Length + m];//создание вспомогательного массива
                for (int i = 0; i < k - 1; i++)//копирование до k
                {
                    temp[i] = arr[i];
                }
                //Вставка новых элементов
                for (int i = k - 1, j = 0; i < k - 1 + m; i++, j++)
                {
                    temp[i] = values[j];
                }
                //вставка остальных
                for (int i = k - 1 + m; i < arr.Length + m; i++)
                {
                    temp[i] = arr[i - m];
                }
                return temp;
            }
            else
            {
                Console.WriteLine("Номер позиции выходит за границы массива");
                Console.WriteLine("Для продолжения нажмите Enter");
                Console.Read();
                return arr;
            }
        }

        static int[] ShiftToRight (int[] arr, int n)
        {
            int[] temp;
            
            temp = new int[arr.Length];
            if (n > 0)
            {
                //проверка на размер
                if (n >= arr.Length)
                {
                    n %= arr.Length;
                }
                //копирование из конца в начало
                for (int i =  arr.Length - n; i < arr.Length; i++)
                {
                    temp[i - (arr.Length - n)] = arr[i];
                }
                //копирование остальной части
                for (int i = 0; i < arr.Length - n; i++)
                {
                    temp[i + n] = arr[i];
                }
                return temp;
            }
            else
            {
                n = Math.Abs(n);
                if (n >= arr.Length)
                {
                    n %= arr.Length;
                }
                //копирование начиная с элемента N
                for (int i = n; i < arr.Length; i++)
                {
                    temp[i - n] = arr[i];
                }
                //копирование из начала в конец
                for (int i = 0; i < n; i++)
                {
                    temp[arr.Length - n] = arr[i];
                }
                return temp;
            }
            
            return temp;
        }

        static void RunFind(int[] array, int f)
        {
            int index = Find(array, f);
            if (index >= 0)
            {
                Console.WriteLine($"Элемент {f} найден на позиции {index}");
                Console.WriteLine($"Сравнений: {index + 1}");
                Console.WriteLine("Искать дальше (нажмите enter)? (для отмены нажмите любую клавишу)");
                while (index != -1 && Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    index = Find(array, f, index);
                    if (index != -1)
                    {
                        Console.WriteLine($"Элемент {f} найден на позиции {index}");
                        Console.WriteLine("Искать дальше (нажмите enter)? (для отмены нажмите любую клавишу)");
                    }
                    else
                    {
                        index = -1;
                        Console.WriteLine($"Больше элементов со значением {f} не найдено");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Элементов со значением {f} не найдено");
            }
        }

        static int Find(int [] arr, int f, int start = 0)
        {
            bool find = true;
            int n = -1;
            for (int i = start; i < arr.Length && find; i++)
            {
                if (arr[i] == f)
                {                   
                    n = i + 1;
                    find = false;
                }
            }
            return n;
        }

        static int FindBinary(int[] arr, int f, ref int count)
        {
            int l = 0, r = arr.Length - 1, c = 0;
            bool flag = false;
            count = 0;
            while (l <= r & !flag)
            {
                count++; 

                c = (r + l) / 2;
                if (f == arr[c])
                {
                    flag = true;
                } else if (f < arr[c])
                {
                    r = c - 1;
                } else if (f > arr[c])
                {
                    l = c + 1;
                }                
            }
            if (flag)
            {
                return l;
            } else
            {
                return -1;
            }
        }

        static int[] Sort (int[] arr)
        {
            int size = arr.Length;
            for (int i = 0; i < size - 1; i++)
            {
                int index = i, min = arr[i];

                for (int j = i + 1; j < size; j++)
                {
                    if (arr[j] <= min)
                    {
                        min = arr[j];
                        index = j;
                    }
                    
                }
                arr[index] = arr[i];
                arr[i] = min;
            }
            return arr;
        }

        static void Main(string[] args) 
        {
            int[] array = new int[0];
            bool sort = false;
            int n;
            int key;
            do
            {
                Console.Clear();                
                PrintArray(array);
                Console.WriteLine("================================");
                PrintMenu();
                key = ReadValue("=> ", "Для выбора команд используйте клавиши от 0 до 7", 0, 7);
                switch (key)
                {
                    case 1://создание массива 
                        Console.Clear();
                        Console.WriteLine("1. Случайная генерация\n" +
                                            "2. Ручной ввод\n" +
                                            "0. Назад");
                        key = ReadValue("=> ", "Для выбора команд используйте клавиши от 0 до 2", 0,2);
                        switch (key)
                        {
                            case 1:
                                n = ReadValue("Введите количество элементов массива (1..50): ", "Требуется ввести число от 1 до 50", 1, 50);
                                array = CreateRandomArray(n);//рандомное заполнение                                 
                                break;
                            case 2:
                                n = ReadValue("Введите количество элементов массива (1..50): ", "Требуется ввести число от 1 до 50", 1, 50);
                                array = CreateArray(n);// заполнение
                                break;
                        }
                        Console.WriteLine("Массив создан");
                        sort = false;
                        break;

                    case 2://удаление четных
                        if(!isEmpty(array))
                        {
                            if(array.Length == Delete(array).Length)
                            {
                                Console.WriteLine("В массиве нет четных элементов");
                            } 
                            else
                            {
                                array = Delete(array);
                                Console.WriteLine("Элементы успешно удалены");
                            }                            
                        }
                        else
                        {
                            Console.WriteLine("Массив не создан!!!");
                        }
                        break;
                    case 3://добавление элементов
                        if(!isEmpty(array))
                        {
                            Console.WriteLine("Сколько элементов добавить?");
                            int m = ReadValue("=> ", "Количество элементов должно быть больше 0", 1);
                            Console.WriteLine("Начать с позиции: ");
                            int k = ReadValue("=> ", "Выход за границы массива", 1, array.Length+1);
                            int[] values = CreateArray(m);

                            array = Add(array, k, values);          
                        }
                        else
                        {
                            Console.WriteLine("Массив не создан!!!");
                        }
                        sort = false;
                        break;

                    case 4://циклический сдвиг вправо
                        if (!isEmpty(array))
                        {
                            Console.WriteLine("\nНа сколько элементов сдвинуть?");
                            int f = ReadValue();
                            array = ShiftToRight(array, f);
                            Console.WriteLine("Сдвиг выполнен");
                        }
                        else
                        {
                            Console.WriteLine("Массив не создан!!!");
                        }
                        sort = false;
                        break;

                    case 5://поиск по значению
                        if (!isEmpty(array))
                        {
                            int f = ReadValue("найти элемент со значением: ");
                            RunFind(array, f);
                        }
                        else
                        {
                            Console.WriteLine("Массив не создан!!!");
                        }
                        break;

                    case 6://сортировка простым выбором
                        if (!isEmpty(array))
                        {
                            if (!sort)
                            {
                                array = Sort(array);
                                sort = true;
                                Console.WriteLine("Массив отсортрован");
                            }
                            else
                            {
                                Console.WriteLine("Массив уже отсортирован!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Массив не создан!!!");

                        }
                        break;
                    case 7://бинарный поиск
                        if (!isEmpty(array))
                        {
                            if (sort)
                            {
                                Console.Write("\nЗначение элемента: ");
                                int f = ReadValue();
                                int count = 0;
                                int index = FindBinary(array, f, ref count);
                                if (index != -1)
                                {
                                    Console.WriteLine($"Элемент {f} найден на позиции {index + 1}");
                                    Console.WriteLine($"Сравнений: {count+1}");
                                } else
                                {
                                    Console.WriteLine($"Элемент {f} не найден");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Массив не отсортирован!!!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Массив не создан!!!");
                        }
                        break;

                    case 0:
                        break;

                }
                Console.WriteLine("Для продолжения нажмите любую клавишу");
                Console.ReadKey();
            } while (key != 0);

        }
    
    }
}