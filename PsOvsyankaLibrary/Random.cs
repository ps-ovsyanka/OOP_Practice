using System;
using static System.Console;


namespace PsOvsyankaLibrary
{
    public class Randomizer
    {
        public static Random rand = new Random();
        public static int GetRandInt(int min = Int32.MinValue, int max = Int32.MaxValue)
        {
            return rand.Next(min, max);
        }


        /// <summary>
        /// Возвращает случайный объект иерархии
        /// </summary>
        /// <returns></returns>
        public static Goods GetRandomGoods()
        {
            if (rand.Next(2) == 0)
            {
                return Goods.CreateRandom();
            }
            else
            {
                return Toy.CreateRandom();
            }
        }
    }
}
