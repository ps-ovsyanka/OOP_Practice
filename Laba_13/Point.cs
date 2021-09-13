using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_13
{
    public class Point<T> //элемент списка
    {
        public T data;//информационное поле
        public Point<T> next;//следующий
        public Point<T> prev;//предыдущий

        public Point()
        {
            data = default(T);
            next = null;
            prev = null;
        }

        public Point(T t)
        {
            data = t;
            next = null;
            prev = null;
        }

        public override string ToString()
        {
            return data.ToString();
        }
    }
}
