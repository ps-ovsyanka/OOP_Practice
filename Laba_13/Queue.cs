using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_13
{
    public class Queue<T>
    {
        Point<T> beg;
        Point<T> end;

        public int Length
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
        public virtual Point<T> Begin { get { return beg; } set { beg = value; } }


        public virtual Point<T> End { get { return end; } }


        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Queue()
        {
            beg = null;
            end = null;
        }


        /// <summary>
        /// Конструктор с начальной емкостью, заданной параметром
        /// </summary>
        /// <param name="size">размер коллекции</param>
        public Queue(int size)
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
        public Queue(Queue<T> queue)
        {
            //пустая коллекция с заданным кол-во элементов
            beg = new Point<T>(default(T));
            Point<T> current = beg;
            for (int i = 1; i < queue.Length; i++)
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
        /// Добавление в конец
        /// </summary>
        /// <param name="item"></param>
        virtual public void AddLast(T item)
        {
            if(Length == 0)
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
        /// Удаление первого
        /// </summary>
        virtual public bool DeleteFirst()
        {
            if (beg == null) return false;
            if (Length == 1)
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


        public Queue<T> Copy (Queue<T> q)
        {
            Queue<T> copyQ = new Queue<T>(q.Length);
            copyQ.beg = q.beg;
            copyQ.end = q.end;
            return copyQ;
        }

        

        /// <summary>
        /// Функция очистки коллекции, удаляет все ссылки между элементами
        /// </summary>
        /// <returns>false, если коллекция пуста</returns>
        public bool Clear()
        {
            if (Length == 0) return false;
            else
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
                return true;
            }            
        }

        public override string ToString()
        {
            if (beg == null) return "Список пуст";
            string res = "";
            foreach (T t in this)
            {
                res += t.ToString() + "\n\n";
            }
            return res.Remove(res.Length - 2, 2);//удаление лишних пробелов;
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


    }   

}
