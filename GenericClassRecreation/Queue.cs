using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RECREATE_GENERIC_COLLECTION
{

    public class Queue<T>
    {
        public LinkedList<T> linkedList;

        public Queue()
        {
            linkedList = new LinkedList<T>();
        }

        public void Enqueue(T item)
        {
            linkedList.AddLast(item);
        }

        public T Dequeue()
        {
            if (linkedList.IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }
            T item = linkedList.head.value;
            linkedList.Remove();
            return item;
        }

        public bool IsEmpty()
        {
            return linkedList.IsEmpty();
        }

        public int Size()
        {
            return linkedList.Size();
        }



        public void Traverse()
        {
            linkedList.Traverse();
        }
    }


}

