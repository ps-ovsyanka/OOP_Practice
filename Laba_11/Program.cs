using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static PsOvsyankaLibrary.Output;
using static PsOvsyankaLibrary.Input;
using static System.Console;

namespace Laba_11
{
    class Program
    {
        public static Random rand = new Random();
        public static Stopwatch sw = new Stopwatch();
        static void Main(string[] args)
        {
            TestCollections tc = CreateCollections();

            int command = 1;

            while(command != 0)
            {
                Clear();
                string menu =   "1. Создать новую коллекцию\n" +
                                "2. Поиск первого элемента\n" +
                                "3. Поиск центрального элемента\n" +
                                "4. Поиск последнего элемента\n" +
                                "5. Поиск в словарях по значению\n" +
                                "6. Добавить элемент в начало\n" +
                                "7. Удалить элемент с конца\n" +
                                "8. Получить кол-во элементов\n" +
                                "\n" +
                                "0. Выход\n";

                command = SelectMenuItem(menu, 9);
               
                switch (command)
                {
                    case 1:
                        tc = CreateCollections();
                        break;
                    case 2:

                        if (tc.listS.Count == 0) WriteErrorMessage("Коллекции пусты");
                        else
                        {
                            WriteLine("Поиск первого элемента");
                            MeasureSearchTime(tc, (Goods) tc.listG[0].Clone());
                        }
                        break;
                    case 3:
                        if (tc.listS.Count == 0) WriteErrorMessage("Коллекции пусты");
                        else
                        {
                            WriteLine("Поиск центрального элемента");
                            MeasureSearchTime(tc, (Goods) tc.listG[tc.listG.Count / 2].Clone());
                        }                        
                        break;
                    case 4:
                        if (tc.listS.Count == 0) WriteErrorMessage("Коллекции пусты");
                        else
                        {
                            WriteLine("Поиск последнего элемента");
                            MeasureSearchTime(tc, (Goods) tc.listG.Last().Clone());
                        }
                        break;
                    case 5:
                        if (tc.listS.Count == 0) WriteErrorMessage("Коллекции пусты");
                        else
                        {
                            SearchByValue(tc);
                        }
                        break;
                    case 6:
                        AddFirstToCollections(tc);
                        break;
                    case 7:
                        if (tc.listS.Count == 0) WriteErrorMessage("Коллекции пусты");
                        else
                        {
                            DeleteLastFromCollections(tc);
                        }
                        break;
                    case 8:
                        WriteMessage("Кол-во элементов: " + tc.listG.Count);
                        break;
                }
            } 

        }

        private static void DeleteLastFromCollections(TestCollections tc)
        {
            if (tc.listG.Count > 0) tc.DeleteLast();
            else WriteErrorMessage("Коллекции пусты");
        }

        private static void MeasureSearchTime(TestCollections tc, Goods find)
        {
                string res = "Результат времени поиска:\n\n";
                sw.Start();
                if (tc.listG.Contains(find)) res += "List<Goods>:\tНайдено. Тики:" + sw.ElapsedTicks + "\n";
                else   res += "List<Goods>:\tНе найдено. Тики:" + sw.ElapsedTicks + "\n";
                sw.Restart();
                if (tc.listS.Contains(find.ToString())) res += "List<String>:\tНайдено. Тики:" + sw.ElapsedTicks + "\n";
                else   res += "List<String>:\tНе найдено. Тики:" + sw.ElapsedTicks + "\n";
                sw.Restart();
                if (tc.sortDG.ContainsKey(find)) res += "SortedDictionary<Goods, Toy>:\tНайдено. Тики:" + sw.ElapsedTicks + "\n";
                else res += "SortedDictionary<Goods, Toy>:\tНе найдено. Тики:" + sw.ElapsedTicks + "\n";
                sw.Restart();
                if (tc.sortDS.ContainsKey(find.ToString())) res += "SortedDictionary<string, Toy>:\tНайдено. Тики:" + sw.ElapsedTicks + "\n";
                else res += "SortedDictionary<string, Toy>:\t Не найдено. Тики:" + sw.ElapsedTicks + "\n";
                sw.Stop();

                WriteMessage(res);
            
            
        }


        private static void AddFirstToCollections(TestCollections tc)
        {
            try
            {
                Toy t = new Toy();
                Write("Название товара:");
                t.Name = ReadLine();
                Write("Цена товара:");
                t.price = InputInt();
                Write("Страна производителя:");
                t.Manufacturer = ReadLine();

                tc.AddFirst(t);
            }
            catch (Exception e)
            {
                WriteMessage("Невозможно добавить" + e.Message);
            }
            
        }

        private static void SearchByValue(TestCollections tc)
        {
            Toy t = new Toy();
            Write("Название товара:");
            t.Name = ReadLine();
            Write("Цена товара:");
            t.price = InputInt();
            Write("Страна производителя:");
            t.Manufacturer = ReadLine();

            sw.Start();
            if (
                tc.sortDG.ContainsValue(t))
            {
                sw.Stop();
                WriteMessage("Элемент найден. Тики: " + sw.ElapsedTicks);
            }
            else WriteMessage("Элемент не найден. Тики: " + sw.ElapsedTicks);
               
        }

        private static TestCollections CreateCollections()
        {
            int size = InputInt("Количество элементов в коллекциях: ", default, 1);
            TestCollections tc = new TestCollections(size);
            WriteMessage("Коллекции созданы");
            return tc;
        }


    }
}
