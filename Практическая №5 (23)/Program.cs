using System;

using static System.Console;
namespace Практическая__5__23_
{
    class Program
    {
        static int ReadInt(int min = int.MinValue, int max = int.MaxValue)
        {
            int number = 0;
            bool ok;

            do
            {
                ok = true;
                try
                {
                    number = Convert.ToInt32(ReadLine());
                    if (number <= max && number >= min)
                    {
                        ok = true;
                    }
                    else throw new Exception();
                    
                }
                catch
                {
                    WriteLine("Неверно введено число. Введите еще раз");
                    ok = false;
                }
            } while (!ok);

            return number;
        }
        /// <summary>
        /// Печать одномерный массив
        /// </summary>
        static void PrintArray (int[] array)
        {
            foreach(int i in array)
            {
                Write(i + " ");
            }
            Write("\n");
        }

        /// <summary>
        /// Печать двумерный массив
        /// </summary>
        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++) Write(array[i,j] + " ");
                Write("\n");
            }
        }

        /// <summary>
        /// Печать рваный массив
        /// </summary>
        static void PrintArray(int[][] array)
        {
            foreach (int[] a in array)
            {
                foreach (int i in a) Write($"{i,3} ");
                Write("\n");
            }
        }

        /// <summary>
        /// Создание одномерного массива
        /// </summary>
        static int[] CreateOneArray()
        {
            Clear();
            WriteLine("1. Создать вручную\n" +
                            "2. Создать автоматически\n" +
                            "0. Назад");
            int key = ReadInt(0, 2);
            Write("Введите количество элементов (1..50): ");            
            int size = ReadInt(1, 50);
            int[] array = new int[size];
            switch (key)
            {
                case 1:
                    WriteLine("Введите элементы");
                    for (int i = 0; i < size; i++)
                    {
                        array[i] = ReadInt();
                    }
                    break;
                case 2:
                    Random rand = new Random();
                    for (int i = 0; i < size; i++)
                    {
                        array[i] = rand.Next(0, 99);
                    }
                    break;
                case 0:
                    break;
            }
            return array;
        }

        /// <summary>
        /// Создание двумерного массива
        /// </summary>
        static int[,] CreateTwoArray()
        { 
            Clear();
            WriteLine("1. Создать вручную\n" +
                            "2. Создать автоматически\n" +
                            "0. Назад");
            int key = ReadInt(0, 2);
            int rows, columns;
            Write("Введите количество строк: ");
            rows = ReadInt(1, 50);
            Write("Введите количество столбцов: ");
            columns = ReadInt(1, 50);  
            int[,] array = new int[rows,columns];
            switch (key)
            {
                case 1:
                    WriteLine("Введите элементы");
                    
                    for (int i = 0; i < rows; i++)
                    {
                        WriteLine($"Строка {i + 1}");
                        for (int j = 0; j < columns; j++)
                        {
                            array[i, j] = ReadInt();
                        }
                    }
                    break;
                case 2:
                    Random rand = new Random();
                    
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            array[i, j] = rand.Next(0, 99);
                        }
                    }
                    break;
                case 0:
                    break;
            }
            return array;
        }

        /// <summary>
        /// Создание рваного массива
        /// </summary>
        static int[][] CreateRaggedArray()
        {
            Clear();
            WriteLine("1. Создать вручную\n" +
                            "2. Создать автоматически\n" +
                            "0. Назад");
            int key = ReadInt(0, 2);
            int rows, columns;
            int[][] array = new int[0][];
            switch (key)
            {
                case 1:
                    Write("Введите количество строк: ");
                    rows = ReadInt(1, 50);
                    array = new int[rows][];
                    for (int i = 0; i < rows; i++)
                    {
                        Write("Введите количество столбцов: ");
                        columns = ReadInt(1, 50);
                        array[i] = new int[columns];
                        for (int j = 0; j < columns; j++)
                            array[i][j] = ReadInt();
                    }
                    break;
                case 2:
                    Random rand = new Random();

                    Write("Введите количество строк: ");
                    rows = ReadInt(1, 50);
                    array = new int[rows][];
                    for (int i = 0; i < rows; i++)
                    {
                        Write($"Введите количество столбцов для сроки {i+1}: "); ; ;
                        columns = ReadInt(1, 50);
                        array[i] = new int[columns];
                        for (int j = 0; j < columns; j++)
                            array[i][j] = rand.Next(0, 99);
                    }
                    break;
                case 0:
                    break;
            }
            return array;
        }

        /// <summary>
        /// Проверка массива на пустоту
        /// </summary>
        static bool isEmpty(object arr)
        {
            return ((Array)arr).Length <= 0;
        }
        static void DeleteEvenIndex (ref int[] array)
        {
            int[] temp;
            if (array.Length%2 == 0) temp = new int[array.Length/ 2];
            else temp = new int[(array.Length + 1) / 2];

            for (int i = 0; i < temp.Length; i ++)
            {
                temp[i] = array[i*2];
            }
            array = temp;
        }
        /// <summary>
        /// Добавление столбцов
        /// </summary>
        /// <param name="array">массив</param>
        /// <param name="k">с какой позиции добавить</param>
        /// <param name="columns">Сколько столбцов</param>
        static void AddColumn(ref int[,] array, int k, int columns)
        {
            int[,] temp = new int[array.GetLength(0), array.GetLength(1) + columns];
                         
            for (int j = 0; j < k-1; j++)
            {
                for (int i =0;i<temp.GetLength(0);i++) temp[i, j] = array[i,j];
            }             
            for (int j = k-1; j < k + columns - 1; j++)
            {
                WriteLine($"Введите элементы {j - k + 2} столбца");
                for (int i = 0; i < temp.GetLength(0); i++)
                {
                    temp[i, j] = ReadInt();                    
                }
            }
            for (int j = k-1 + columns; j < temp.GetLength(1); j++)
            {
                for (int i = 0; i < temp.GetLength(0); i++)  temp[i, j] = array[i, j - columns];
            }
            
            array = temp;
        }
        static void AddRow(ref int[][] array, int k, int[] row)
        {
            int[][] temp = new int[array.Length + 1][];
            for (int i = 0; i < k; i++)
            {
                temp[i] = new int[array[i].Length];
                for (int j = 0; j < temp[i].Length; j++)
                {
                    temp[i][j] = array[i][j];
                }

            }
            temp[k] = new int[row.Length];
            for (int j = 0; j < temp[k].Length; j++)
            {
                temp[k][j] = row[j];
            }
            for (int i = k + 1; i < array.Length+1; i++)
            {
                temp[i] = new int[array[i-1].Length];
                for (int j = 0; j < temp[i].Length; j++)
                {
                    temp[i][j] = array[i-1][j];
                }

            }
            array = temp;
        }


        static void Main(string[] args)
        {
            int mainKey = 1;
            int key = 1;
            while (mainKey != 0)
            {
                Clear();
                Write("1. Одномерный массив\n" +
                            "2. Двумерный массив\n" +
                            "3. Рваный массив\n" +
                            "0. Назад\n" +
                            "=> ");
                mainKey = ReadInt(0, 3);
                Clear();
                switch (mainKey)
                {
                    case 1://одномерный массив
                        int[] array1 = new int[0];
                        key = 1;
                        while (key != 0)
                        {
                            Clear();                            
                            if (!isEmpty(array1)) PrintArray(array1);
                            Write("------------------------------\n" +
                                "1. Создать новый массив\n" +
                                "2. Удалить элементы на четных позициях\n" +
                                "0. Выход\n" +
                                "=> ");
                            key = ReadInt(0, 2);
                            switch (key)
                            {
                                case 1:                                    
                                    array1 = CreateOneArray();
                                    break;
                                case 2:
                                    DeleteEvenIndex(ref array1);
                                    break;
                                case 0:
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case 2://двумерный массив
                        int[,] array2 = new int[0, 0];
                        key = 1;
                        while (key != 0)
                        {
                            Clear();
                            if (!isEmpty(array2)) PrintArray(array2);
                            Write("------------------------------\n" +
                                "1. Создать новый массив\n" +
                                "2. Добавить столбцы\n" +
                                "0. Назад\n" +
                                "=> ");
                            key = ReadInt(0, 2);
                            switch (key)
                            {
                                case 1:
                                    array2 = CreateTwoArray();
                                    break;
                                case 2:
                                    if(array2.Length != 0)
                                    {
                                        WriteLine("Сколько столбцов добавить?");
                                        int columns = ReadInt(1, 50 - array2.GetLength(1));
                                        WriteLine("С какой позиции добавить?");
                                        int k = ReadInt(1, array2.GetLength(1) + 1);
                                        AddColumn(ref array2, k, columns);
                                    }
                                    else
                                    {
                                        WriteLine("Массив не создан!!!");
                                        WriteLine("Для продолжения нажмите любую клавишу");
                                        ReadKey();
                                    }                                   
                                    break;
                                case 0:
                                    break;
                            }
                        }
                        break;
                    case 3://рваный массив
                        int[][] array3 = new int[0][];
                        key = 1;
                        while (key != 0)
                        {
                            Clear();
                            if (!isEmpty(array3)) PrintArray(array3);
                            Write("------------------------------\n" +
                                "1. Создать новый массив\n" +
                                "2. Добавить строку\n" +
                                "0. Назад\n" +
                                "=> ");
                            key = ReadInt(0, 2);
                            switch (key)
                            {
                                case 1:
                                    array3 = CreateRaggedArray();
                                    break;
                                case 2:
                                    Write("Добавить строку на позицию: ");
                                    int k = ReadInt(1, array3.GetLength(0)+1);
                                    int[] row = CreateOneArray();
                                    AddRow(ref array3, k-1, row);
                                    break;
                                case 0:
                                    break;
                            }
                        }
                        break;
                    case 0:
                        break;
                    default:
                        break;
                }

            }
        }
    }
}