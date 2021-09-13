using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_12
{
    class PointOne<T> //элемент списка
    {
        public T data;//информационное поле
        public PointOne<T> next;//адресное поле

        public PointOne()
        {
            data = default(T);
            next = null;
        }

        public PointOne(T t)
        {
            data = t;
            next = null;
        }

        public override string ToString()
        {
            return data.ToString();
        }
    }
}
