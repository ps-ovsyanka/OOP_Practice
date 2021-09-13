using System;
using System.Collections.Generic;
using System.Linq;
using PsOvsyankaLibrary;
using static PsOvsyankaLibrary.Input;
using static PsOvsyankaLibrary.Output;
using static PsOvsyankaLibrary.Randomizer;
using static System.Console;
using System.Text;
using System.Threading.Tasks;

namespace Laba_14
{
    class Program
    {
        
        static void Main(string[] args)
        {
            LinkedList<MyQueue<Goods>> myCollections = new LinkedList<MyQueue<Goods>>();

            myCollections.AddLast(GetRandomQueue(7));
            myCollections.Last.Value.Name = "Первая";
            myCollections.AddLast(GetRandomQueue(9));
            myCollections.Last.Value.Name = "Вторая";

            
            SelectGoodsMoreExpensiveThan(myCollections, InputInt("Показать товары дороже: "));
            WriteMessage();
            foreach (MyQueue<Goods> myQ in myCollections)
            {
                WriteLine($"-----Колллекция: {myQ.Name}------------------------------");
                WriteLine($"Количество игрушек: {CountToys(myQ)}");
            }
            CountToys(myCollections.First.Value);
            WriteMessage();
            AllToys(myCollections);
            WriteMessage();
            MaxMinToys(myCollections);
            WriteMessage();
            WriteLine("Сортировка по возрастанию цены:");
            AllGoodsSortByPrice(myCollections);
            WriteMessage();
            WriteLine("Группировка по названию:");
            GroupGoods(myCollections);
            WriteMessage();

        }

        public static MyQueue<Goods> GetRandomQueue(int size)
        {
            MyQueue<Goods> myQueue = new MyQueue<Goods>();
            for (int i = 0; i < size; i++)
            {
                myQueue.AddLast(GetRandomGoods());
            }
            return myQueue;
        }


        /// <summary>
        /// Вывод товаров, дороже заданной стоимости
        /// </summary>
        /// <param name="list"></param>
        /// <param name="minPrice"></param>
        public static void SelectGoodsMoreExpensiveThan(LinkedList<MyQueue<Goods>> list, int minPrice)
        {   
            foreach (MyQueue<Goods> myQ in list)
            {
                WriteLine($"-----Колллекция: {myQ.Name}------------------------------");
                var selectGoodsByPrice = from goods in myQ where goods.price > minPrice select goods; //С использованием LINQ запросов
                foreach (var s in selectGoodsByPrice) WriteLine(s);
            }

        }


        /// <summary>
        /// Подсчет игрушек в обеих коллекциях
        /// </summary>
        /// <param name="list"></param>
        public static int  CountToys (MyQueue<Goods> myQ)
        {          
            return (from goods in myQ where goods is Toy select goods).Count();//Метод расширения
        }


        /// <summary>
        /// Вывод всех игрушек с использованием 
        /// операции над множествами (объединение)
        /// </summary>
        /// <param name="list"></param>
        public static void AllToys(LinkedList<MyQueue<Goods>> list)
        {
            MyQueue<Goods>  myQ1 = list.First.Value;
            MyQueue<Goods> myQ2 = list.First.Next.Value;

            var goodsSum = myQ1.SelectMany(goods => myQ1).Union(myQ2.SelectMany(goods => myQ2));// Методы расширения
            var toys = goodsSum.Where(delegate (Goods g) { return g is Toy; })//Использование анонимного метода
                                    .Select(toy => toy);//Лямбда-выражение
            if (CountToys(list.First.Value) == 0 & CountToys(list.First.Next.Value) == 0) WriteLine("В коллекциях нет игрушек");
            else
            {
                WriteLine("Игрушки из обеих колллекций:");
                foreach (var toy in toys)
                    WriteLine(toy);
            }            
        }


        /// <summary>
        /// Поиск самой дорогой и самой дешевой игрушки
        /// </summary>
        /// <param name="list"></param>
        public static void MaxMinToys(LinkedList<MyQueue<Goods>> list)
        {
            foreach (MyQueue<Goods> myQ in list)
            {
                var toys = from goods in myQ where goods is Toy select goods;

                Func<Goods, Goods, Goods> max = delegate (Goods a, Goods b) { return a.price > b.price ? a : b; };
                Func<Goods, Goods, Goods> min = delegate (Goods a, Goods b) { return a.price < b.price ? a : b; };

                var maxPriceToy = toys.Aggregate(max);
                var minPriceToy = toys.Aggregate(min);

                WriteLine($"-----Колллекция: {myQ.Name}------------------------------");

                if (CountToys(myQ) == 0) WriteLine("В коллекции нет игрушек");
                else
                {
                    WriteLine($"Самая дорогая игрушка: {maxPriceToy.Name} Цена: {maxPriceToy.price}");
                    WriteLine($"Самая дешевая игрушка: {minPriceToy.Name} Цена: {minPriceToy.price}");
                }
            }
        }

        public static void AllGoodsSortByPrice(LinkedList<MyQueue<Goods>> list)
        {
            foreach (MyQueue<Goods> myQ in list)
            {                
                var selectGoods = from goods in myQ orderby goods.price select goods; //С использованием LINQ запросов

                WriteLine($"-----Колллекция: {myQ.Name}------------------------------");
                foreach (var s in selectGoods) WriteLine(s);
            }
        }

        public static void GroupGoods(LinkedList<MyQueue<Goods>> list)
        {
            MyQueue<Goods> myQ1 = list.First.Value;
            MyQueue<Goods> myQ2 = list.First.Next.Value;

            var groupsGoods = (from g1 in myQ1 select g1).Union(from g2 in myQ2 select g2).GroupBy(g => g.Name);

            foreach (IGrouping<string, Goods> g in groupsGoods)
            {
                WriteLine($"Товар: { g.Key} Количество: {g.Count()}");
                foreach (var t in g)
                {
                    if (t is Toy) WriteLine($"Цена: {t.price} | Производитель: {((Toy)t).Manufacturer}");
                    else WriteLine($"Цена: {t.price}");
                }                    
                WriteLine("*");
            }
            
        }


    }
}
