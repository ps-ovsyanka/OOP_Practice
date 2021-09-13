using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_13
{
    public class NewQueue<T>: Queue<T>
    {
        public string Name { get; set; }

        public override Point<T> Begin
        {
            get => base.Begin;
            set
            {
                this.Begin.data = value.data;
                OnCollectionReferenceChanged(this, new CollectionHandlerEventArgs(this.Name, "changedFirst", Begin));
            }
        }



        public event CollectionHandler CollectionCountChanged;
        public event CollectionHandler CollectionReferenceChanged;

        //обработчик события CollectionCountChanged
        public virtual void OnCollectionCountChanged(object source, CollectionHandlerEventArgs args)
        {
            if (CollectionCountChanged != null)
                CollectionCountChanged(source, args);
        }
        //обработчик события OnCollectionReferenceChanged
        public virtual void OnCollectionReferenceChanged(object source, CollectionHandlerEventArgs args)
        {
            if (CollectionReferenceChanged != null)
                CollectionReferenceChanged(source, args);
        }

        public override void AddLast(T item)
        {
            OnCollectionCountChanged(this, new CollectionHandlerEventArgs(this.Name, "AddLast", item));
            base.AddLast(item);
        }

        public override bool DeleteFirst()
        {
            object item = Begin;
            if (base.DeleteFirst())
            {
                OnCollectionCountChanged(this, new CollectionHandlerEventArgs(this.Name, "DeleteFirst", item));
                return true;
            }
            else return false;            
        }

    }
}
