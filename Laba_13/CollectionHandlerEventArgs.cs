using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_13
{
    public class CollectionHandlerEventArgs : System.EventArgs
    {
        public CollectionHandlerEventArgs(string name, string chName, object item)
        {
            Name = name;
            changedName = chName;
            Item = item;
        }

        public string Name { get; }
        public string changedName { get; }
        public object Item { get; }

        public override string ToString()
        {
            string res = $"В коллекции: {Name} произошло событие: {changedName} ";
            if (Item != null) res += $"\nПодробности : {Item.ToString()}";
            return res;
        }
    }   
}
