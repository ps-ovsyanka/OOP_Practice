using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_10
{
    public class Goods : IExecutable, IComparable, ICloneable
    {
        protected string name;
        public int price;
        protected static Random rand = new Random();

        public Goods()
        {
            name = "Не указано";
            price = 0;

        }
        public Goods(string n, int p)
        {
            name = n;
            price = p;
        }

        public string Name { get => name; set => name = value; }

        public object Clone()
        {
            return new Goods(name, price);
        }

        public int CompareTo(Object obj)
        {
            if (name.CompareTo(((Goods)obj).name) != 0) return name.CompareTo(((Goods)obj).name);
            else if (price == ((Goods)obj).price) return 0;
            else if (price < ((Goods)obj).price) return -1;
            else return 1;
        }

        public override bool Equals(object obj)
        {
            return name == ((Goods)obj).Name & price == ((Goods)obj).price;
        }



        public static Goods CreateRandom()
        {
            string[] arrName = { "Стул", "Стол", "Кружка", "Сервиз", "Наушники", "Лампа", "Телевизор", "Кастрюля", "Шторы", "Часы", "Камера", "Книга", "Журнал", "Краски", "Карандаши", "Зеркало", "Шкаф", "Куртка", "Сапоги", "Телнфон", "Корзина", "Картина", "Ковер", "Фотоальбом", "Роутер" };
            string name = arrName[rand.Next(arrName.Length - 1)];
            int price = rand.Next(1000, 10000);
            return new Goods(name, price);
        }


        public void Show()
        {
            Console.Write($"Товар: {name} \nСтоимость: {price}");
        }

        public virtual void ShowVirtual()
        {
            Console.Write($"Товар: {name} \nСтоимость: {price}");
        }

        public override string ToString()
        {
            return $"Товар: {name} \tСтоимость: {price}";
        }
    }
}
