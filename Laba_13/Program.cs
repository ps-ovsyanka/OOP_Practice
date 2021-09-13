using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PsOvsyankaLibrary.Output;
using static PsOvsyankaLibrary.Input;
using static System.Console;

namespace Laba_13
{
    public delegate void CollectionHandler(object source, CollectionHandlerEventArgs args);
    class Program
    {
        static void Main(string[] args)
        {
            NewQueue<Goods> firstQueue = new NewQueue<Goods>();
            NewQueue<Goods> secondQueue = new NewQueue<Goods>();


            Journal joun1 = new Journal();
            firstQueue.CollectionCountChanged += new CollectionHandler(joun1.CollectionCountChanged);
            firstQueue.CollectionReferenceChanged += new CollectionHandler(joun1.CollectionReferenceChanged);

            Journal joun2 = new Journal();
            firstQueue.CollectionReferenceChanged += new CollectionHandler(joun2.CollectionReferenceChanged);
            secondQueue.CollectionReferenceChanged += new CollectionHandler(joun2.CollectionReferenceChanged);


            string[] menu = {"Работа с первой коллецией", 
                            "Работа со второй коллецией",
                            "Посмотреть журнал изменения первой коллекции",
                            "Посмотреть журнал общих изменений"};
            int key = 1;
            while (key != 0)
            {
                Clear();
                key = SelectMenuItem(menu);
                switch (key)
                {
                    case 1:
                        ActionWithCollection(firstQueue);
                        break;
                    case 2:
                        ActionWithCollection(secondQueue);
                        break;
                    case 3:
                        joun1.Show();
                        WriteMessage("");
                        break;
                    case 4:
                        joun2.Show();
                        WriteMessage("");
                        break;
                }
            }

        }


        private static void ActionWithCollection(NewQueue<Goods> que)
        {

            string[] menu = {"Распечатать элементы",
                            "Добавить в конец",
                            "Удалить из начала",
                            "Изменить первый элемент",
                            "Очистить коллекцию"};
            int key = 1;
            while (key != 0)
            {
                Clear();
                if (que.Name == null)
                {
                    que.Name = InputLine("Введите имя коллекции: ");
                    Clear();
                }
                WriteLine($"Коллекция: {que.Name}\n--------------------------");

                key = SelectMenuItem(menu);
                switch (key)
                {
                    case 1:
                        Write($"\nСодержимое коллекции:\n{que}");
                        WriteMessage("");
                        break;
                    case 2:
                        que.AddLast(ChengeItem());
                        WriteMessage("Добавлен элемент");
                        break;
                    case 3:
                        if (que.DeleteFirst()) WriteMessage($"Элемент удален");
                        else WriteErrorMessage("Коллекция пуста. Удаление невозможно.");
                        break;
                    case 4:
                        if (que.Length > 0)
                        {
                            que.Begin = new Point<Goods>(ChengeItem());
                            WriteMessage("Первый элемент изменен");
                        }
                        else WriteMessage("Коллекция пуста. Изменение  невозможно.");
                        break;
                    case 5:
                        if (que.Clear()) WriteMessage("Коллекция очищена");
                        else WriteErrorMessage("Коллекция пуста, очистка не выполнена");
                        break;
                }
            }
        }
       

        public static Goods ChengeItem ()
        {
            Clear();
            WriteLine("1. Товар\n2. Игрушка");
            int key = InputInt("=>", "Нет такого варианта", 1, 2);
            if (key == 1)
            {
                return Goods.CreateRandom();
            }
            else
            { 
                return Toy.CreateRandom();
            }
        }
        private static bool SearchCollection(Queue<Goods> que, Goods search)
        {
            foreach (Goods temp in que)
            {
                if (temp.ToString() == search.ToString()) return true;
            }
            return false;
        }
    }
}


