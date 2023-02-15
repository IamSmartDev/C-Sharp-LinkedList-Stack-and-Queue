using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECREATE_GENERIC_COLLECTION
{
    internal class Program
    {


        static void Main(string[] args)
        {
            LinkedList<int> myList = new LinkedList<int>();

            // add some elements to the list
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------LINKEDLIST--------------------------------------------");
            myList.AddLast(100);
            myList.AddLast(90);
            myList.AddLast(67);
            myList.AddFirst(89);

            // display the elements of the list
            Console.WriteLine("---------LinkedList Item---------");
            myList.Traverse();

            // check if an item exists in the list
            Console.WriteLine("\nCheck if an item exists");
            Console.WriteLine("Does 10 exist?  =>" + myList.Check(100));
            Console.WriteLine("Does 15 exist?  =>" + myList.Check(15));

            // get the index of an item
            Console.WriteLine("\nGet the index of an item:");
            Console.WriteLine("Index of 20 is  =>" + myList.IndexOf(90));
            Console.WriteLine("Index of 25 is => " + myList.IndexOf(25));

            // remove an item from the list
            Console.WriteLine("\nRemove an item from the list:");
            myList.Remove();
            Console.WriteLine("-------LinkedList elements after removing first element----------");
            myList.Traverse();

            // get the size of the list
            Console.WriteLine("-------\nGet the size of the list----------");
            Console.WriteLine("Size of the list is =>" + myList.Size());


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------QUEUE--------------------------------------------");
            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(50);
            myQueue.Enqueue(20);
            myQueue.Enqueue(80);
            myQueue.Enqueue(40);
            myQueue.Enqueue(60);

            Console.WriteLine("----------Queue elements --------");
            myQueue.Traverse();

            myQueue.Dequeue();
            myQueue.Dequeue();

            Console.WriteLine("------Queue elements  after Dequeue---------");
            myQueue.Traverse();


            // check for  the  size  of  the queue
            Console.WriteLine("\n-------Check for the  size of the queue--------");
            Console.WriteLine("Size of  the queue =>" + myQueue.Size());
            Console.WriteLine("Check if the  Queue is empty => " + myQueue.IsEmpty());



            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------STACK--------------------------------------------");
            Stack<int> myStack = new Stack<int>();
            myStack.Push(100);
            myStack.Push(250);
            myStack.Push(390);
            myStack.Push(410);
            myStack.Push(400);



            Console.WriteLine("------Stack elements------- ");
            myStack.Traverse();

            myStack.Pop();
            myStack.Pop();

            Console.WriteLine("--------Stack elements  after Pop--------- ");
            myStack.Traverse();


            // check for  the  size  of  the queue
            Console.WriteLine("\n-----------Check for the  size of the Stack--------");
            Console.WriteLine("Get  the element at  the top =>" + myStack.Peek());
            Console.WriteLine("Size of  the Stack =>" + myStack.Size());
            Console.WriteLine("Check if the  Stack is empty =>" + myQueue.IsEmpty());


            Console.ReadLine();
        }
    }



}






