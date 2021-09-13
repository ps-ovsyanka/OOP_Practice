using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_12
{
    class ListOne<T>
    {
        public PointOne<T> beg;
        public int Length
        {
            get
            {
                if (beg == null) return 0;
                int l = 0;
                PointOne<T> current = beg;
                while (current != null)
                {
                    l++;
                    current = current.next;
                }
                return l;
            }
        }
        public ListOne()//конструктор без параметров
        {
            beg = null;
        }
        public ListOne(int size)//конструктор с параметрами
        {
            beg = new PointOne<T>();
            PointOne<T> current = beg;
            for(int i=1; i < size; i++)
            {
                current.next = new PointOne<T>();
                current = current.next;
            }
        }
        public override string ToString()
        {
            PointOne<T> current = beg;
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
            if (beg == null) beg = new PointOne<T>(t);
            else
            {
                PointOne<T> current = beg;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = new PointOne<T>(t);
            }            
        }

        //добавление по индексу
        public void Add(T t, int index)
        {
            PointOne<T> temp = new PointOne<T>(t);
            
            if (index == 1)
            {
                temp.next = beg;
                beg = temp;
            }
            else
            {
                PointOne<T> current = beg;
                for(int i = 1; i < index - 1; i++)
                {
                    current = current.next;
                }
                
                temp.next = current.next;
                current.next = temp;
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
                PointOne<T> current = beg;
                for (int i = 1; i < index-1; i++)
                {
                    current = current.next;
                }

                current.next = current.next.next;
            }

        }
       
    }
}
