using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_13
{
    public class JournalEntry
    {
        public JournalEntry(string name, string changedName, string v)
        {
            Name = name;
            this.changedName = changedName;
            Item = v;
        }

        public string Name { get; }
        public string changedName { get; }
        public string Item { get; }

        public override string ToString()
        {
            string res = $"В коллекции: {Name} произошло событие: {changedName}";
            if (Item != null) res += $"\nПодробности: {Item}";
            return res;
        }
    }
}
