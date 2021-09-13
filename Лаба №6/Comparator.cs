using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба__6
{
    class Comparator : IComparer<string> {
    public int Compare(string o1, string o2)
    {
        if (o1.Length == o2.Length) return 0;
        else if (o1.Length > o2.Length) return -1;
        else return 1;
    }
}
}
