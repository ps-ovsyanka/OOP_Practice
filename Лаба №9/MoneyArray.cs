using System;
using static Laba9.Program;

namespace Laba9
{
    public class MoneyArray
    {
        Money[] arr = null;
        static Random rand = new Random(1);
        public int Length { get { return arr.Length; } }

        public MoneyArray()
        {
            arr = new Money[0];
        }
        /// <summary>
        /// Создание массива со случайными значениями
        /// </summary>
        /// <param name="size">Размер массива</param>
        public MoneyArray(int size, int max)
        {
            arr = new Money[size];
            for (int i = 0; i < size; i++)
            {
                this[i] = new Money(0, rand.Next(100 * max + 1));
            }
        }
        /// <summary>
        /// Создание массива с заданными элементами
        /// </summary>
        /// <param name="size">Размер массива</param>
        public MoneyArray(int size)
        {
            arr = new Money[size];
            for (int i = 0; i < size; i++)
            {
                int rub = ReadValue("Введите рубли\n", "Ошибка ввода числа", 0);
                int cop = ReadValue("Введите копейки\n", "Ошибка ввода числа", 0);
                arr[i] = new Money(rub, cop);
            }
        }
        /// <summary>
        /// Доступ по индексу
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Money this[int index]
        {
            get
            {
                if (index >= 0 & index <= arr.Length) return arr[index];
                else return null;
            }
            set
            {
                if (index >= 0 & index <= arr.Length) arr[index] = value;
            }
        }
        /// <summary>
        /// Поиск максимального элементa
        /// </summary>
        /// <returns></returns>
        public Money Max()
        {
            Money max = this[0];
            for (int i = 0; i < this.Length; i++)
            {
                if (this[i] > max) max = this[i];
            }
            return max;
        }
        /// <summary>
        /// Преобразование в строку
        /// </summary>
        public override string ToString()
        {
            if (Length == 0)
            {
                return "Массив не создан";
            }
            else
            {
                string res = "";
                for (int i = 0; i < arr.Length; i++)
                {
                    res += arr[i].ToString() + "; ";
                }
                res.Remove(res.Length - 2, 2);
                return res;
            }
            
        }
    }
}
