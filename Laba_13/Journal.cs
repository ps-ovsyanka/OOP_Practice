using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_13
{
    public class Journal
    {
        public List<JournalEntry> journal;

        public Journal()
        {
            journal = new List<JournalEntry>();
        }

        public void CollectionCountChanged(object sourse, CollectionHandlerEventArgs e)
        {
            JournalEntry je = new JournalEntry(e.Name, e.changedName, e.Item.ToString());
            journal.Add(je);

        }
        public void CollectionReferenceChanged(object sourse, CollectionHandlerEventArgs e)
        {
            JournalEntry je = new JournalEntry(e.Name, e.changedName, e.Item.ToString());
            journal.Add(je);
        }

        public void Show()
        {
            int i = 1;
            foreach (JournalEntry je in journal) {
                Console.WriteLine(i + ")----------------------------");
                Console.WriteLine(je);
                i++;
            }
        }

    }
}
