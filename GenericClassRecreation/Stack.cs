using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECREATE_GENERIC_COLLECTION
{
    public class Stack<T>
    {
        private LinkedList<T> list = new LinkedList<T>();

        public bool IsEmpty()
        {
            return list.IsEmpty();
        }

        public void Push(T item)
        {
            list.AddFirst(item);
        }

        public void Traverse()
        {
            list.Traverse();
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            T item = list.tail.value;
            list.Remove();
            return item;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return list.tail.value;
        }

        public int Size()
        {
            return list.Size();
        }


    }

}
