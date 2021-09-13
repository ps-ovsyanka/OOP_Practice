using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9
{    
    public class Money
    {
        private static int count;
        private int rub, cop;
        public int Rub
        {
            get { return rub; }
            set
            {
                if (value >= 0) { rub = value; }
                else throw new Exception("Отрицательная денежная сумма");
            }
        }
        public int Cop
        {
            get { return cop; }
            set
            {
                if (value >= 0)
                {
                    rub += value / 100;
                    cop = value % 100;
                }
                else throw new Exception("Отрицательная денежная сумма");
            }
        }
        public static int Count
        {
            get { return count; }
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="rb">Рубли</param>
        /// <param name="cp">Копейки</param>
        public Money(int rb = 0, int cp = 0) 
        { 
            count++;  
            this.Rub = rb; 
            this.Cop = cp; 
        }
        /// <summary>
        /// Статическое ычитание
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Money Difference(Money a, Money b)
        {
            Money c = new Money(a.Rub, a.Cop);
            if (a.Rub >= b.Rub)
            {
                if (b.Cop > a.Cop)
                {
                    c.Rub --;
                    c.Cop = 100 + c.Cop - b.Cop;
                }
                else
                {
                    c.Cop = a.Cop - b.Cop;
                }
                c.Rub -= b.Rub;
                return c;
            }
            else
            {
                throw new Exception("Невозможно вычислить");
            }
        }
        /// <summary>
        /// Метод класса вычитание
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public Money Difference(Money m) {return Difference(this, m);}
        /// <summary>
        /// Вычитание объктов
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Money operator -(Money a, Money b) { return Difference(a, b); }
        /// <summary>
        /// Вычитание из объекта целого числа
        /// </summary>
        /// <param name="a">Объект Money</param>
        /// <param name="b">Целое число</param>
        /// <returns></returns>
        public static Money operator -(Money a, int b)
        {
            Money c = new Money();
            if (b > a.Rub) throw new Exception("Невозможно вычислить");
            c.Rub = a.Rub - b;
            c.Cop = a.Cop;
            return c;
        }
        /// <summary>
        /// Вычитание из целого числа
        /// </summary>
        /// <param name="a">Целое число</param>
        /// <param name="b">Объект</param>
        /// <returns></returns>
        public static Money operator -(int a, Money b)
        {
            Money c = new Money();
            c.Rub = a - b.Rub - 1;
            c.Cop = 100 - b.Cop;
            return c;
        }
        /// <summary>
        /// Вычитание копейки
        /// </summary>
        /// <param name="a"></param>
        public static Money operator --(Money a)
        {
            if (a.cop == 0)
            {
                a.Rub--;
                a.Cop = 99;
            }
            else a.Cop -= 1;
            return a;
        }

        /// <summary>
        /// Прибавление копейки
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Money operator ++(Money a)
        {
            a.Cop++;
            return a;
        }
        public static bool operator ==(Money a, Money b)
        {
            if (a.Rub == b.Rub && a.Cop == b.Cop) return true;
            else return false;
        }
        public static bool operator !=(Money a, Money b)
        {
            if (a.Rub == b.Rub && a.Cop == b.Cop) return false;
            else return true;
        }

        public static bool operator >(Money a, Money b)
        {
            if (a.Rub*100 + a.Cop > b.Rub*100+b.Cop) return true;
            else return false;
        }
        public static bool operator <(Money a, Money b)
        {
            if (a.Rub * 100 + a.Cop < b.Rub * 100 + b.Cop) return true;
            else return false;
        }
        /// <summary>
        /// Явное приведение к int
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator int(Money a)
        {
            return a.Rub;
        }
        /// <summary>
        /// Явное приведение к double
        /// </summary>
        /// <param name="a"></param>
        public static implicit operator double(Money a)
        {
            return a.Cop / 100.0;
        }
        /// <summary>
        /// Вывод информации об объекте
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Rub} р. {Cop} коп.";
        }

    }
}
