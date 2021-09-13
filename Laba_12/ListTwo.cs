using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_12
{
    class ListTwo<T>
    {
        public PointTwo<T> beg;
        public PointTwo<T> last;
        public int Length
        {
            get
            {
                if (beg == null) return 0;
                int l = 0;
                PointTwo<T> current = beg;
                while (current != null)
                {
                    l++;
                    current = current.next;
                }
                return l;
            }
        }
        public ListTwo()//конструктор без параметров
        {
            beg = null;
            last = null;
        }
        public ListTwo(int size)//конструктор с параметрами
        {
            beg = new PointTwo<T>();
            PointTwo<T> current = beg;
            for (int i = 1; i < size; i++)
            {
                current.next = new PointTwo<T>();//добавление следующего
                current.next.prev = current;//определение предыдущего, для нового
            }
        }
        public override string ToString()
        {
            PointTwo<T> current = beg;
            string res = "";
            while (current != null)
            {
                res += current.data.ToString() + "\n\n";
                current = current.next;
            }
            if (res == "") return "Список пуст"; else return res.Remove(res.Length - 2, 2);//удаление лишних пробелов;
        }

        //Добавление в конец
        public void AddLast(T t)
        {
            if (beg == null) beg = new PointTwo<T>(t);
            else
            {
                PointTwo<T> current = beg;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = new PointTwo<T>(t);//добавление следующего
                current.next.prev = current;//определение предыдущего, для нового
            }
        }

        //добавление по индексу
        public void Add(T t, int index)
        {
            PointTwo<T> temp = new PointTwo<T>(t);
            if (beg == null) beg = new PointTwo<T>(t);
            else if (index == 1)
            {
                beg.prev = temp;
                temp.next = beg;
                beg = temp;
            }
            else if (index == Length + 1)
            {
                AddLast(t);
            }
            else
            {
                PointTwo<T> current = beg;
                for (int i = 1; i < index - 1; i++)
                {
                    current = current.next;
                }

                temp.prev = current;//связь с предыдущим
                temp.next = current.next;//связь со следующим

                current.next.prev = temp;//переназначение предыдущего
                current.next = temp;//переназначение следующего               

            }

        }

        public void Delete(int index)
        {

            //если удаляется первый элемент
            if (index == 1)
                beg = beg.next;
            //удаление не первых элементов
            else
            {
                PointTwo<T> current = beg;
                for (int i = 1; i < index - 1; i++)//поиск эл, перед удаляемым
                {
                    current = current.next;
                }

                if (current.next.next == null) current.next = null;//если удаляемый эл последний, то просто забываем его
                else
                {
                    current.next.next.prev = current;//переназначение предыдущего
                    current.next = current.next.next;//переназначение следующего
                }
            }
        }


    }
}
