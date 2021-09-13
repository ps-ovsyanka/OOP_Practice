using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_12
{
    public class Goods : IExecutable, IComparable, ICloneable
    {
        static string[] randName = { "Cтол", "Стул", "Телевизор", "Чайник", "Шарф", "Фонарик", "Рюкзак" };
        static Random rand = new Random((int)System.DateTime.Now.Ticks);
        protected string name;
        public int price;

        public Goods()
        {
            name = "Не указано";
            price = 0;
        }
        public Goods (string n, int p)
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
            if (price == ((Goods)obj).price) return 0;
            else if (price < ((Goods)obj).price) return -1;
            else return 1;            
        }


    


        public void Show()
        {
            Console.Write($"Товар: {name} \nСтоимость: {price}");
        }

        public virtual void ShowVirtual()
        {
            Console.Write($"Товар: {name} \nСтоимость: {price}" );
        }

        public override string ToString()
        {
            return $"Товар: {name} \nСтоимость: {price}";
        }

        public static Goods RandGoods()
        {
            string name = randName[rand.Next(7)];
            int price = rand.Next(5000);
            return new Goods(name, price);
        }




    }
}
