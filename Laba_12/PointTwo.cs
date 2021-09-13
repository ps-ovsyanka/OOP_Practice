using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_12
{
    class PointTwo<T> //элемент списка
    {
        public T data;//информационное поле
        public PointTwo<T> next;//следующий
        public PointTwo<T> prev;//предыдущий

        public PointTwo()
        {
            data = default(T);
            next = null;
            prev = null;
        }

        public PointTwo(T t)
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
