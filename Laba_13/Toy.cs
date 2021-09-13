using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Laba_13
{
    public class Toy : Goods
    {
        
        private string manufacturer;

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public Goods BaseGoods
        {
            get
            {
                return new Goods(name, price);//возвращает объект базового класса
            }
        }


        public Toy(): base()
        {
            manufacturer = "Не указано";
        }
        public Toy(string n, int p, string m): base(n, p)
        {            
            manufacturer = m;
        }



        public static Toy CreateRandom()
        {
            string[] arrName = { "Кукла", "Машинка", "Пазл", "Кубик Рубика", "Конструктор", "Робот", "Скакалка", "Кастрюля", "Лего", "Пирамидка", "Юла", "Книга", "Погремушка", "Краски", "Карандаши", "Зеркало", "Кукольный дом", "Медведь", "Крокодил", "Телефон", "Раскраска", "Шашки", "Шахматы", "Фотоальбом", "Паравозик" };
            string[] arrManufact = { "Россия", "Корея", "Китай", "Япония", "США", "Канада", "Индонезия", "Франция", "Австрия", "Венгрия", "Германия", "Швейцария", "Сингапур", "Италия", "Испания", "Азербайджан", "Беларусь", "Украина", "Латвия", "Польша", "Афганистан", "Норвегия", "Финляндия", "Мексика", "Монголия", "Турция" };
            string name = arrName[rand.Next(arrName.Length - 1)];
            string manufacturer = arrManufact[rand.Next(arrManufact.Length - 1)];
            int price = rand.Next(100, 5000);
            return new Toy(name, price, manufacturer);
        }

        public int CompareTo(Object obj)
        {
            if (name.CompareTo(((Toy)obj).Name) != 0) return name.CompareTo(((Goods)obj).Name);
            else if (price != ((Toy)obj).price) return price.CompareTo(((Goods)obj).price);
            else return manufacturer.CompareTo(((Toy)obj).Manufacturer);
        }

        public override bool Equals(object obj)
        {
            return name == ((Toy)obj).Name & price == ((Toy)obj).price & manufacturer == ((Toy)obj).manufacturer;
        }

        public void Show()
        {
            base.Show();
            Write("\nПроизводитель: " + manufacturer);
        }
        public override void ShowVirtual()
        {
            base.ShowVirtual();
            Write("\nПроизводитель: " + manufacturer);
        }

        public object Clone()
        {
            return new Toy(name, price, manufacturer);
        }

        public override string ToString()
        {
            return base.ToString() + "\tПроизводитель: " + manufacturer;
        }
    }
}
