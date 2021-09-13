using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PsOvsyankaLibrary.Output;
using static PsOvsyankaLibrary.Input;
using static System.Console;

namespace Laba_12
{
    class Program
    {

        static void Main(string[] args)
        {
            string menu =   "1. Односвязный список\n" +
                            "2. Двусвязный список\n" +
                            "3. Бинарное дерево\n" +
                            "4. Коллекция (Очередь на базе двунаправленного списка)\n" +
                            "0. Выход\n" +
                            "--------------------------\n";
            int key = 1;
            while(key != 0)
            {
                Clear();
                key = SelectMenuItem(menu, 5);
                switch (key)
                {
                    case 1:
                        ActionListOne();
                        break;
                    case 2:
                        ActionListTwo();
                        break;
                    case 3:
                        break;
                    case 4:
                        ActionQueue();
                        break;


                }
            }

        }


        private static void ActionListOne()
        {
            ListOne<Goods> listOne = new ListOne<Goods>();
            string menu =   "Односвязный список\n" +
                            "--------------------------\n" +
                            "1. Распечатать список\n" +
                            "2. Добавить в конец\n" +
                            "3. Добавить по индексу (по заданию)\n" +
                            "4. Удалить по индексу\n" +
                            "0. Назад\n" +
                            "--------------------------\n";
            int key = 1;
            while (key != 0)
            {
                Clear();
                key = SelectMenuItem(menu, 5);
                switch (key)
                {
                    case 1:                       
                        Write($"\nСодержимое списка:\n{listOne}");
                        WriteMessage("");                        
                        break;
                    case 2:
                        Goods temp_1 = Goods.RandGoods();
                        listOne.AddLast(temp_1);
                        WriteMessage($"Добавлен элемент:\n{temp_1}");
                        break;
                    case 3:
                        int index = InputInt("Индекс добавляемого элемента: ", $"Ошибка. Индекс должен быть в пределах от 1 до {listOne.Length + 1}", 1, listOne.Length + 1);
                        Goods temp_2 = Goods.RandGoods(); 
                        listOne.Add(temp_2, index);
                        WriteMessage($"На позицию {index} добавлен элемент:\n{temp_2}");
                        break;
                    case 4:
                        if (listOne.Length == 0) WriteErrorMessage("Список пуст. Удаление невозможно.");
                        else
                        {
                            int indexDel = InputInt("Индекс удаляемого элемента: ", $"Ошибка. Индекс должен быть в пределах от 1 до {listOne.Length + 1}", 1, listOne.Length);
                            listOne.Delete(indexDel);
                            WriteMessage($"С позиции {indexDel} удален элемент.");
                        }                       
                        break;


                }
            }
        }
        private static void ActionListTwo()
        {
            ListTwo<Goods> listTwo = new ListTwo<Goods>();
            string menu =   "Двусвязный список\n" +
                            "--------------------------\n" +
                            "1. Распечатать список\n" +
                            "2. Добавить в конец\n" +
                            "3. Добавить по индексу\n" +
                            "4. Удалить по индексу\n" +
                            "5. Удалить элементы с четными номерами(по заданию)\n" +
                            "0. Назад\n" +
                            "--------------------------\n";
            int key = 1;
            while (key != 0)
            {
                Clear();
                key = SelectMenuItem(menu, 6);
                switch (key)
                {
                    case 1:
                        Write($"\nСодержимое списка:\n{listTwo}");
                        WriteMessage("");
                        break;
                    case 2:
                        Goods temp_1 = Goods.RandGoods();
                        listTwo.AddLast(temp_1);
                        WriteMessage($"Добавлен элемент:\n{temp_1}");
                        break;
                    case 3:
                        int index = InputInt("Индекс добавляемого элемента: ", $"Ошибка. Индекс должен быть в пределах от 1 до {listTwo.Length + 1}", 1, listTwo.Length + 1);
                        Goods temp_2 = Goods.RandGoods();
                        listTwo.Add(temp_2, index);
                        WriteMessage($"На позицию {index} добавлен элемент:\n{temp_2}");
                        break;
                    case 4:
                        if (listTwo.Length == 0) WriteErrorMessage("Список пуст. Удаление невозможно.");
                        else
                        {
                            int indexDel = InputInt("Индекс удалаяемого элемента: ", $"Ошибка. Индекс должен быть в пределах от 1 до {listTwo.Length + 1}", 1, listTwo.Length);
                            listTwo.Delete(indexDel);
                            WriteMessage($"С позиции {indexDel} удален элемент.");
                        }                        
                        break;
                    case 5:
                        string res = DeleteEvenElement(listTwo) ? "Элементы удалены" : "Удаление невозмножно. В списке меньше двух элементов.";
                        WriteMessage(res);                        
                        break;
                }
            }
        }

        /// <summary>
        /// Удаление элементов на с четными индексами из двусвязного списка
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool DeleteEvenElement(ListTwo<Goods> list)
        {
            if (list.Length == 0 | list.Length == 1) return false;
            int index = 2;
            while (index <= list.Length)
            {
                list.Delete(index);
                index++;
            }
            return true;
        }
        private static void ActionQueue()
        {
            Queue<Goods> myCollection = new Queue<Goods>();
            string menu = "Очередь на основе двусвязного списка\n" +
                            "--------------------------\n" +
                            "1. Распечатать элементы\n" +
                            "2. Добавить в конец\n" +
                            "3. Удалить из начала\n" +
                            "4. Поиск по значению\n" +
                            "5. Удалить коллекцию\n" +
                            "6. Создать и распечатать копию\n" +
                            "0. Назад\n" +
                            "--------------------------\n";
            int key = 1;
            while (key != 0)
            {
                Clear();
                key = SelectMenuItem(menu, 7);
                switch (key)
                {
                    case 1:
                        Write($"\nСодержимое коллекции:\n{myCollection}");                        
                        WriteMessage("");
                        break;
                    case 2:
                        Goods temp_1 = Goods.RandGoods();
                        myCollection.AddLast(temp_1);
                        WriteMessage($"Добавлен элемент:\n{temp_1}");
                        break;
                    case 3:
                        
                        if (myCollection.Count == 0) WriteErrorMessage("Коллекция пуста. Удаление невозможно.");
                        else
                        {
                            myCollection.DeleteFirst();
                            WriteMessage($"Элемент удален");
                        }
                        break;
                    case 4:
                        if (myCollection.Count == 0) WriteErrorMessage("Коллекция пуста. Поикс невозможен.");
                        else
                        {
                            Write("Название:");
                            string name = ReadLine();
                            int price = InputInt("Стоимость:");
                            Goods search = new Goods(name, price);
  
                            if (SearchCollection(myCollection, search)) WriteMessage("Элемент найден");
                            else WriteMessage("Элемент не найден");
                        }
                        break;
                    case 5:
                        myCollection.Clear();
                        WriteMessage("Коллекция удалена");
                        break;
                    case 6:
                        if (myCollection.Count == 0) WriteErrorMessage("Коллекция пуста. Копирование невозможно.");
                        else
                        {
                            Queue<Goods> cloneQ = new Queue<Goods>(myCollection);
                            WriteLine("Скопированная коллекция:");
                            WriteLine(cloneQ);
                            WriteMessage("");
                        }                        
                        break;
                }
            }
        }

        private static bool SearchCollection(Queue<Goods> myCollection, Goods search)
        {
            foreach(Goods temp in myCollection)
            {
                if (temp.ToString() == search.ToString()) return true;
            }
            return false;
        }
    }
}

