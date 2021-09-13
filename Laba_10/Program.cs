using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Laba_10
{
    public class Program
    {
        public static Random rand = new Random();

        public static string[] namesGoods = {"Cтол", "Стул", "Телевизор", "Чайник", "Шарф", "Фонарик", "Рюкзак" };
        public static string[] namesToys = { "Кукла", "Юла", "Конструктор", "Робот", "Машинка", "Мяч", "Пазл"};
        public static string[] makersToys = { "Россия", "Китай", "Индонезия", "Канада", "Италия", "Франция", "Япония" };
        public static string[] namesProducts = { "Колбаса", "Хлеб", "Морковь", "Сок", "Шоколадка", "Консервы", "Котлеты" };
        public static string[] namesMilk = { "Молоко", "Сыр", "Йогурт", "Творог", "Кефир", "Ряженка", "Масло" };
        public static int InputInt(string invite = "", string error = "Ошибка ввода", int min = Int32.MinValue, int max = Int32.MaxValue)
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
                else if (res < min | res > max)
                {
                    WriteLine("Ошибка. Введите число от " + min + " до " + max);
                    flag = false;
                }
            }
            return res;     
        }

        public static void WriteMessage(string msg = "")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            WriteLine(msg);
            WriteLine("Для продолжения нажмите любую клавишу...");
            ResetColor();
            ReadKey();
        }
        /// <summary>
        /// Выбор пункта меню. Пункты по порядку начиная с нуля.
        /// </summary>
        /// <param name="menu">Текст меню</param>
        /// <param name="countItem">Количество пунктов</param>
        /// <returns></returns>
        public static int SelectMenuItem (string menu, int countItem)
        {
            Write(menu);
            int current = InputInt("=>", default, 0, countItem - 1);
            return current;
        }

        //-------------------Создание случайных объектов----------------------

        public static Goods CreateRandGoods()
        {
            string name = namesGoods[rand.Next(7)];
            int price = rand.Next(5000);
            return new Goods(name, price);
        }
        public static Toy CreateRandToy()
        {
            string name = namesToys[rand.Next(7)];
            int price = rand.Next(2000);
            string maker = makersToys[rand.Next(7)];
            return new Toy(name, price, maker);
        }
        public static Product CreateRandProduct()
        {
            while (true)
            {
                string name = namesProducts[rand.Next(7)];
                int price = rand.Next(500);
                Product p = new Product(name, price, rand.Next(1, 30) + 1, rand.Next(1, 12), rand.Next(2019, 2021));
                return p;
            }

        }
        public static Milk CreateRandMilk()
        {
            string name = namesMilk[rand.Next(7)];
            int price = rand.Next(500);
            return new Milk(name, price, rand.Next(30), rand.Next(12), rand.Next(2019, 2021), rand.Next(70));
        }

        //------------------Вывод информации об оьъектах в списке------------
        public static void ShowInfo(List<IExecutable> bascket)
        {
            if (bascket.Count > 0)
            {
                foreach (IExecutable i in bascket)
                {
                    i.Show();
                    WriteLine("\n--------------------------------");
                }
            }
            else WriteLine("Корзина пуста");
        }
        public static void ShowlInfoVirtualMethod(List<IExecutable> bascket)
        {
            if (bascket.Count > 0)
            {
                foreach (IExecutable i in bascket)
                {
                    i.ShowVirtual();
                    WriteLine("\n--------------------------------");
                }
            }
            else WriteLine("Корзина пуста");
        }

        //-----------------------Запросы--------------------------------------

        public static void CountToys(List<IExecutable> basket)
        {
            int count = 0;
            foreach(Goods i in basket)
            {
                if (i is Toy) count++;
            }
            WriteLine("Игрушек в корзине: " + count);
        }  
        public static void CountProduct(List<IExecutable> basket)
        {
            int count = 0;
            int maxPrice = InputInt("Найти продукты дешевле: "); 
            foreach (Goods i in basket)
            {
                if (i is Product & i.price < maxPrice)
                {
                    i.ShowVirtual();
                    WriteLine("\n-------------------------------");
                }
            }
        }
        public static void FindMostExpensiveToy(List<IExecutable> basket)
        {
            int index = -1;
            int maxPrice = 0;
            for (int i = 0; i < basket.Count; i++) 
            {
                if (basket[i] is Toy && ((Toy)basket[i]).price > maxPrice)
                {
                    index = i;
                    maxPrice = ((Toy)basket[i]).price;
                }
            }
            if (index != -1)
            {
                WriteLine("-------------------------------");
                WriteLine("Самая дорогая игрушка");
                WriteLine("-------------------------------");
                basket[index].ShowVirtual();
                WriteLine();
            }
            else
            {
                WriteLine("В корзине игрушек нет");
            }
        }
        public static void FindMostCheapsetToy(List<IExecutable> basket)
        {
            int index = 0;
            int minPrice = Int32.MaxValue;

            for (int i = 0; i < basket.Count; i++)
            {
                if (basket[i] is Toy && ((Toy)basket[i]).price < minPrice)
                {
                    index = i;
                    minPrice = ((Toy)basket[i]).price;
                }
            }
            if (index != -1)
            {
                WriteLine("-------------------------------");
                WriteLine("Самая дешевая игрушка");
                WriteLine("-------------------------------");
                basket[index].ShowVirtual();
                WriteLine();
            }
            else
            {
                WriteLine("В корзине игрушек нет");
            }
            
        }

        //-------------------------------------------------------------------

        public static void ClonGoods(List<IExecutable> basket)
        {
            if(basket.Count != 0)
            {
                int index = InputInt("Индекс клонируемого объекта: ", default, 1, basket.Count) - 1;
                IExecutable current = basket[index];


                if (current is Milk milk) basket.Add((Milk)milk.Clone());
                else if (current is Product prod) basket.Add((Product)prod.Clone());
                else if (current is Toy toy) basket.Add((Toy)toy.Clone());
                else if (current is Goods goods) basket.Add((Goods)goods.Clone());
                WriteLine("Клон добавлен");
            }
            else
            {
                WriteLine("Корзина пуста");
            }
            
        }

        public static void Sort(ref List<IExecutable> basket)
        {
            if(basket.Count != 0)
            {
                IExecutable[] mas = basket.ToArray();
                Array.Sort(mas);
                basket = new List<IExecutable>(mas);
                WriteMessage("Массив отсортирован");
            }
            else
            {
                WriteMessage("Массив пустой");
            }
        }
        public static void FindAndSort(ref List<IExecutable> basket)
        {
            if (basket.Count != 0)
            {
                WriteLine("Найти товар с именем: ");
                string findName = ReadLine();
                int count = 0;
                WriteLine("Результаты поиска:");
                foreach (IExecutable i in basket)
                {
                    if (i.Name == findName)
                    {
                        count++;
                        i.ShowVirtual();
                    }
                }
                if (count == 0) WriteLine("Ничего не найдено");

                IExecutable[] mas = basket.ToArray();
                Array.Sort(mas, new SortByName());
                basket = new List<IExecutable>(mas);
                WriteMessage("\nМассив отсортрован");
            }
            else
            {
                WriteMessage("Массив пустой");
            }            
        }

        //-------------------------------------------------------------------
        static void Main(string[] args)
        {
            List<IExecutable> basket = new List<IExecutable>();
            string menu = "1. Добавить товар\n" +
                            "2. Добавить продукт\n" +
                            "3. Добавить молочный продукт\n" +
                            "4. Добавить игрушку\n" +
                            "5. Очистить корзину\n" +
                            "6. Вывод информации с помощью виртуальных методов\n" +
                            "7. Вывод информации без виртуальных методов\n" +
                            "----------------------------------------------------\n" +
                            "8. Посчитать количество игрушек в корзине\n" +
                            "9. Показать продукты, дешевле заданной стоимости\n" +
                            "10. Найти самую дешевую и самую дорогую игрушку\n" +
                            "----------------------------------------------------\n" +
                            "11. Отсортировать товары по цене\n" +
                            "12. Создать и добавить клон\n" +
                            "13. Найти элемент и отсортировать по названию\n" +
                            "----------------------------------------------------\n" +
                            "0. Выход\n";
            int key = 1;
            while (key != 0)
            {
                key = SelectMenuItem(menu, 14);
                switch (key)
                {
                    case 1:
                        basket.Add(CreateRandGoods());
                        WriteMessage("Товар добавлен");
                        break;
                    case 2:
                        basket.Add(CreateRandProduct());
                        WriteMessage("Продукт добавлен");
                        break;
                    case 3:
                        basket.Add(CreateRandMilk());
                        WriteMessage("Продукт добавлен");
                        break;
                    case 4:
                        basket.Add(CreateRandToy());
                        WriteMessage("Игрушка добавлена");
                        break;
                    case 5:
                        basket.Clear();
                        WriteMessage("Корзина очищена");
                        break;
                    case 6:
                        ShowlInfoVirtualMethod(basket);
                        WriteMessage();
                        break;
                    case 7:
                        ShowInfo(basket);
                        WriteMessage();
                        break;
                    case 8:
                        CountToys(basket);
                        WriteMessage();
                        break;
                    case 9:
                        CountProduct(basket);
                        WriteMessage();
                        break;
                    case 10:
                        if (basket.Count != 0)
                        {
                            FindMostExpensiveToy(basket);
                            FindMostCheapsetToy(basket);
                            WriteMessage();
                        }
                        else
                        {
                            WriteMessage("Корзина пуста");
                        }
                        break;
                    case 11:
                        Sort(ref basket);
                        break;
                    case 12:
                        ClonGoods(basket);
                        WriteMessage();
                        break;
                    case 13:
                        FindAndSort(ref basket);
                        break;
                    case 0:
                        break;
                }
                Clear();
            }
        }
    }
}



































































/*
 
        public static Goods CreateGoods()
        {
            string name;
            int price;
            Write("Название товара: ");
            name = ReadLine();
            price = InputInt("Стоимость товара: ");
            return new Goods(name, price);
        }
        public static Toy CreateToy()
        {
            string name;
            int price;
            string maker;
            Write("Название игрушки: ");
            name = ReadLine();
            price = InputInt("Стоимость игрушки: ");
            Write("Производитель: ");
            maker = ReadLine();
            return new Toy(name, price, maker);
        }
        public static Product CreateProduct()
        {
            while (true)
            {
                string name;
                int price;
                string date;
                Write("Название продукта: ");
                name = ReadLine();
                price = InputInt("Стоимость продукта: ");
                Write("Срок годности в формате ДД/ММ/ГГГГ: ");
                date = ReadLine();
                Product p = new Product();
                try
                {
                    p = new Product(name, price, Int32.Parse(date.Split('/')[0]), Int32.Parse(date.Split('/')[1]), Int32.Parse(date.Split('/')[2]));
                }
                catch
                {
                    WriteLine("Неверно введена дата");
                }               
                return p;
            }
            
        } 
        public static Milk CreateMilk()
        {
            while (true)
            {
                string name;
                int price;
                string date;
                int fat;
                Write("Название продукта: ");
                name = ReadLine();
                price = InputInt("Стоимость продукта: ");
                fat = InputInt("Жирность продукта: ");
                Write("Срок годности в формате ДД/ММ/ГГГГ: ");
                date = ReadLine();
                Milk p = new Milk();
                try
                {
                    p = new Milk (name, price, Int32.Parse(date.Split('/')[0]), Int32.Parse(date.Split('/')[1]), Int32.Parse(date.Split('/')[2]), fat);
                }
                catch
                {
                    WriteLine("Неверно введена дата");
                }
                return p;
            }

        }
 */