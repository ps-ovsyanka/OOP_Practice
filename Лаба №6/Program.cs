using System;
using static System.Console;

namespace Лаба__6
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

        public static char ReadChar(string inviteMsg = "Введите символ", string errMsg = "Ошибка ввода символа, повторите попытку")
        {
            char symbol = ' '; bool ok;
            do
            {
                ok = true;
                WriteInviteToEnter(inviteMsg);
                try
                {
                    symbol = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception e)
                {
                    WriteErrorMessage(e.Message);
                    ok = false;
                }
            } while (!ok);
            return symbol;
        }

        /// <summary>
        /// Работа с массивом
        /// </summary>
        static void taskArray()
        {
            string mainMenu = "1. Создать массив\n" +
                            "2. Удалить строки, в которых нет цифр\n" +
                            "0. Назад";
            int key = 1;
            char[][] array = new char[0][];
            int row, col;
            while (key != 0)
            {
                Clear();
                if (array.Length != 0) PrintArray(array);
                key = PrintMenu(mainMenu, 2);
                switch (key)
                {
                    case 1:
                        string menu = "Максимальный размер массива 10х10\n"+
                                        "1. Создать автоматически\n" +
                                        "2. Создать вручную\n" +
                                        "0. Назад";
                        Clear();
                        key = PrintMenu(menu, 2);
                        row = ReadValue("Количество строк: ", "Ошибка ввода. Введите число от 1 до 10", 1, 10);
                        col = ReadValue("Количество столбцов: ", "Ошибка ввода. Введите число от 1 до 10", 1, 10);
                        switch (key)
                        {
                            case 1:
                                array = CreateRandomArray(row, col);
                                WriteLine("Массив создан");
                                WriteLine("Для продолжения нажмите любую клавишу");
                                ReadKey();
                                break;
                            case 2:
                                array = CreateArray(row, col);
                                WriteLine("Массив создан");
                                WriteLine("Для продолжения нажмите любую клавишу");
                                ReadKey();
                                break;
                            default:
                                break;
                        }                        
                        break;
                    case 2:
                        if (array.Length != 0)
                        {
                            int len = array.Length;
                            array = DeleteRowsWithNoDigit(array);
                            if (len == array.Length)
                            {
                                WriteLine("Удаление не выполнено. В каждой строке есть цифра");
                            }
                            else
                            {
                                WriteLine("Удаление выполнено");
                            }
                        }
                        else
                        {
                            WriteErrorMessage("Массив не создан!");
                        }
                        WriteLine("Для продолжения нажмите любую клавишу");
                        ReadKey();
                        break;
                    case 0:
                        break;
                }
                
            }
        }

        /// <summary>
        /// Создание массива
        /// </summary>
        /// <returns></returns>
        static char[][] CreateArray(int row, int col)
        {
            char[][] arr = new char[row][];

            for (int i = 0; i < row; i++)
            {
                WriteInviteToEnter($"Строка {i + 1}\n");
                arr[i] = new char[col];
                for (int j = 0; j < col; j++)
                {
                    arr[i][j] = ReadChar("");
                }
            }
            return arr;
        }
        static char[][] CreateRandomArray(int row, int col)
        {
            char[][] arr = new char[row][];

            Random rand = new Random();
            for (int i = 0; i < row; i++)
            {
                arr[i] = new char[col];
                for (int j = 0; j < col; j++)
                {
                    arr[i][j] = (char)(rand.Next(0x0021, 0x007A));
                }
            }
            return arr;
        }

        /// <summary>
        /// Печать массива
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static void PrintArray(char[][] arr)
        {
            if (arr.Length == 0)
            {
                WriteLine("Пустой массив");
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        Write(" " + arr[i][j]);
                    }
                    Write("\n");
                }
            }
            
        }

        static char[][] DeleteRowsWithNoDigit(char[][] arr)
        {
            char[][] temp = new char[arr.Length][];
            for (int i = 0; i < arr.Length; i++)
            {
                bool digit = false;
                int j = 0;
                while (!digit && j < arr[i].Length)
                {
                    if (Char.IsDigit(arr[i][j])) digit = true;
                    else j++;
                }
                if (j == arr[i].Length)
                {
                    Array.Copy(arr, 0, temp, 0, i);
                    Array.Copy(arr, i + 1, temp, i, arr.Length - i - 1);
                    Array.Resize(ref temp, temp.Length - 1);
                    arr = temp;
                    i--;
                }
            }
            if (temp.Length != arr.Length) return temp;
            else return arr;
        }


        /// <summary>
        /// Работа со строкой
        /// </summary>
        static void taskString()
        {
            string Menu = "1. Ввести строку\n" +
                            "2. Выбрать строку из массива\n" +
                            "3. Перевернуть все слова в предложении и отсортировать\n" +
                            "0. Назад";
            string[] strArr = new string[] { "Два дня ходил он по лесам и по горам, а на третий день зашел в топкое болото. Пришел он домой невеселый...",
                                            "Было то     в     середине зимы,,, падали снежинки, точно пух с неба!?",
                                            "       Смеркалось",
                                            "Не следует, однако забывать, что и реализации позиций, занимаемых поставленных задач. Идейные соображения: а также реализация; способствует."};
            string mainString = "";
            int key = 1;
            while (key != 0)
            {
                Clear();
                if(mainString != "") WriteLine(mainString + "\n===============================");
                key = PrintMenu(Menu, 3);
                switch (key)
                {
                    case 1:
                        WriteLine("Введите строку");
                        mainString = ReadLine();
                        break;
                    case 2:
                        foreach(string s in strArr)//вывод массива строк
                        {
                            WriteLine((Array.IndexOf(strArr, s) + 1).ToString() +". "+ s);
                        }
                        int k = ReadValue("номер строки\n", "неверный номер", 1, 3);
                        mainString = strArr[k-1];
                        break;
                    case 3:
                        mainString = ReversWords(mainString);
                        break;
                    case 0:
                        break;
                }
            }
        }

        static string ReversWords (string str)
        {
            char[] setPunctuationWord = {' ', ',',';',':' };
            char[] setPunctuationSentence = { '.','!','?'};

            string[] sentences = str.Split(setPunctuationSentence, StringSplitOptions.RemoveEmptyEntries);
            string[] punctuationSentence = str.Split(sentences, StringSplitOptions.None);

            for(int i = 0; i < sentences.Length; i++)//перебор предложений
            {
                string[] words = sentences[i].Split(setPunctuationWord, StringSplitOptions.RemoveEmptyEntries);
                Array.Sort(words, new Comparator());
                string[] punctuationWords = sentences[i].Split(words, StringSplitOptions.None);
                for (int j = 0; j < words.Length; j++)//перебор слов
                {
                    char[] word = words[j].ToCharArray();
                    Array.Reverse(word);//реверс слова
                    words[j] = new string(word);
                }
                Array.Sort(words);//сортировка в массиве слов
                sentences[i] = punctuationWords[0];
                for (int j = 0; j < words.Length; j++)//соединение слов и пунктуации в предложение
                {
                    sentences[i] += words[j] + punctuationWords[j+1];
                }
                sentences[i] += punctuationSentence[i+1];//добавление пунктуации
            }
            return String.Join(" ", sentences);
        }

        /// <summary>
        /// Вывод меню
        /// </summary>
        /// <param name="textMenu">Текст меню</param>
        /// <param name="count">Количество пунктов меню начиная с нуля</param>
        /// <returns></returns>
        static int PrintMenu(string textMenu, int count)
        {
            WriteLine(textMenu);
            int key = ReadValue("=> ", $"Для выбора команды введите число от 0 до {count}", 0, count);
            return key;
        }

        static void Main(string[] args)
        {
            string tasksMenu = "1. Работа с массивом\n" +
                            "2. Работа со строкой\n" +
                            "0. Выход";
            int key = 1;
            while (key != 0)
            {
                Clear();
                key = PrintMenu(tasksMenu, 2);
                switch (key)
                {
                    case 1:
                        taskArray();
                        break;
                    case 2:
                        taskString();
                        break;
                    case 0:
                        break;
                }
            }

        }
    }
}
