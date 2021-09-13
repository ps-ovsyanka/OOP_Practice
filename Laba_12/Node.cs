using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_12
{
    class Node<T>
    {
        public T data;

        public Node<T> left;
        public Node<T> right;
        public Node<T> root;

        public Node()
        {
            data = default(T);
            left = null;
            right = null;
            root = null;
        }

        public Node(T t)
        {
            data = t;
            left = null;
            right = null;
            root = null;
        }

        public override string ToString()
        {
            return data.ToString();
        }
    }
}
