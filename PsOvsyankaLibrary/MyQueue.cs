using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsOvsyankaLibrary
{
    public class MyQueue<T> : IEnumerable<T>
    {
        Point<T> beg;
        Point<T> end;

        public string Name {get; set;}
        public int Count
        {
            get
            {
                int index = 0;
                Point<T> cur = beg;
                while (cur != null)
                {
                    index++;
                    cur = cur.next;
                }
                return index;
            }
        }
        public Point<T> Begin
        {
            get { return beg; }
        }

        public Point<T> End
        {
            get { return end; }
        }


        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public MyQueue()
        {
            beg = null;
            end = null;
        }


        /// <summary>
        /// Конструктор с начальной емкостью, заданной параметром
        /// </summary>
        /// <param name="size">размер коллекции</param>
        public MyQueue(int size)
        {
            beg = new Point<T>(default(T));
            Point<T> current = beg;
            for(int i = 1; i < size; i++)
            {
                current.next = new Point<T>(default(T));
                current.next.prev = current;
            }
            end = current.next;
        }


        /// <summary>
        /// Конструктор копирования
        /// </summary>
        /// <param name="queue"></param>
        public MyQueue(MyQueue<T> queue)
        {
            //пустая коллекция с заданным кол-во элементов
            beg = new Point<T>(default(T));
            Point<T> current = beg;
            for (int i = 1; i < queue.Count; i++)
            {
                current.next = new Point<T>(default(T));
                current.next.prev = current;
                current = current.next;
            }
            end = current;
            //копирование информационных полей
            current = beg;
            foreach(T t in queue)
            {
                current.data = t;
                current = current.next;
            }

        }


        /// <summary>
        /// Добавление в начало
        /// </summary>
        /// <param name="item"></param>
        public void AddLast(T item)
        {
            if(Count == 0)
            {
                beg = new Point<T>(item);
                end = beg;
            }
            else
            {
                end.next = new Point<T>(item);
                end.next.prev = end;
                end = end.next;
            }
            
        }

        /// <summary>
        /// Удаление последнего
        /// </summary>
        public bool DeleteFirst()
        {
            if (beg == null) return false;
            if (Count == 1)
            {
                beg = null;
                return true;
            }
            else
            {
                beg = beg.next;
                beg.prev = null;
                return true;
            }          
            
        }


        public MyQueue<T> Copy (MyQueue<T> q)
        {
            MyQueue<T> copyQ = new MyQueue<T>(q.Count);
            copyQ.beg = q.beg;
            copyQ.end = q.end;
            return copyQ;
        }

        public override string ToString()
        {
            if (beg == null) return "Список пуст";
            string res = "";
            foreach(T t in this)
            {
                res += t.ToString() + "\n\n";
            }
            return res.Remove(res.Length - 2, 2);//удаление лишних пробелов;
        }

        public void Clear()
        {
            Point<T> current = beg;
            while (current != null)
            {
                Point<T> temp = current.next;
                current.next = null;
                current = temp;
            }
            current = end;
            while (current != null)
            {
                Point<T> temp = current.prev;
                current.prev = null;
                current = temp;
            }
            beg = null;
            end = null;
        }


        public IEnumerator<T> GetEnumerator()
        {
            Point<T> current = beg;
            while (current != null)
            {
                yield return current.data;
                current = current.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }   

}
