using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace RECREATE_GENERIC_COLLECTION
{
    public class LinkedList<T>
    {
        public class Node<T>
        {
            public T value;
            public Node<T> next;

            public Node(T value)
            {
                this.value = value;
            }
        }

        public Node<T> head;
        public Node<T> tail;

        public void AddLast(T item)
        {
            Node<T> node = new Node<T>(item);
            node.value = item;

            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.next = node;
                tail = node;
            }
        }

        public bool IsEmpty()
        {
            return head == null;
        }
        public void Remove()
        {
            if (IsEmpty())
            {
                throw new KeyNotFoundException();
            }
            if (head == null)
            {
                head = null;
                tail = null;
            }
            var second = head.next;
            head.next = null;
            head = second;
        }

        public void AddFirst(T item)
        {
            Node<T> node = new Node<T>(item);
            node.value = item;

            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                node.next = head;
                head = node;
            }
        }



        public int IndexOf(T target)
        {
            int index = 0;
            Node<T> currentNode = head;
            while (currentNode != null)
            {
                if (currentNode.value.Equals(target))
                {
                    return index;
                }
                index++;
                currentNode = currentNode.next;
            }
            return -1;
        }

        public bool Check(T item)
        {
            return IndexOf(item) != -1;
        }

        public int Size()
        {
            int count = 0;
            Node<T> currentNode = head;
            while (currentNode != null)
            {
                count++;
                currentNode = currentNode.next;
            }
            return count;
        }


        //This method  is  used  to  loop  over the linkedlist
        public void Traverse()
        {
            Console.WriteLine($"First Item  {this.head.value}");
            Console.WriteLine($"Last  Item  {this.tail.value}");

            //This  is a  pointer  to  the  first  node
            Node<T> node = head;

            while (node.next != null)
            {
                Console.WriteLine(node.value);
                node = node.next;
            }
            Console.WriteLine(node.value);

        }

    }





}


