using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_12
{
    public class SortByName : System.Collections.IComparer
    {
        public int Compare(object x, object y)
        {
            IExecutable ie1 = (IExecutable)x;
            IExecutable ie2 = (IExecutable)y;

            return String.Compare(ie1.Name, ie2.Name);
        }
    }

}
