using System;
using System.Collections.Generic;
using System.Linq;
using static PsOvsyankaLibrary.Input;
using static System.Console;

namespace Laba_11
{
    public class TestCollections
    {

        public static Random rand = new Random();

        public List<Goods> listG = new List<Goods>();
        public List<string> listS = new List<string>();
        
        public SortedDictionary<Goods, Toy> sortDG = new SortedDictionary<Goods, Toy>();
        public SortedDictionary<string, Toy> sortDS = new SortedDictionary<string, Toy>();

        public TestCollections(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Toy t = Toy.CreateRandom();
                Goods gd = t.BaseGoods;

                bool flag = true;

                while (flag)
                {
                    t = Toy.CreateRandom();
                    gd = t.BaseGoods;

                    flag = false; //предполагаем, что все сгенерируется нормально и повторять не нужно
                    try
                    {
                        sortDS.Add(gd.ToString(), t);
                        sortDG.Add(new Goods(gd.Name, gd.price), new Toy(t.Name, t.price, t.Manufacturer));
                    }
                    catch (Exception e)
                    {
                        flag = true;//если исключение — повторить генерацию
                    }
                }

                listG.Add(gd);
                listS.Add(gd.ToString());
            }
        }



        public void AddFirst(Toy t)
        {
            if (sortDG.ContainsKey(t)) throw new Exception("Такой ключ уже существует");
            Goods gd = t.BaseGoods;

            listG.Add(gd);
            listS.Add(gd.ToString());
            sortDS.Add(gd.ToString(), t);
            sortDG.Add(new Goods(gd.Name, gd.price), new Toy(t.Name, t.price, t.Manufacturer));
        }
        public void DeleteLast()
        {
            Goods gd = listG.Last();
            sortDG.Remove(gd);
            sortDS.Remove(gd.ToString());
            listG.Remove(gd);
            listS.Remove(gd.ToString());
        }


    }
}
