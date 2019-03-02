using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomQueue Q = new CustomQueue(5);

            Q.enqueue(10);
            Q.enqueue(20);
            Q.enqueue(30);
            Q.enqueue(40);
            Q.printQueue();

            Console.WriteLine();

            Q.dequeue();
            Q.dequeue();
            Q.printQueue();

            Console.WriteLine();
            Console.WriteLine("****************");            

            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);
            PrintValues(q);
            Console.WriteLine();  
            q.Dequeue();
            q.Dequeue();
            PrintValues(q);

            Console.ReadLine();
        }

        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
            {
                Console.WriteLine("{0}", obj);
            }
        }
    }

    class CustomQueue
    {
        private int[] ele;
        private int front;
        private int rear;
        private int max;

        public CustomQueue(int size)
        {
            ele = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }

        public void enqueue(int item)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                ele[++rear] = item;
            }

        }

        public int dequeue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                int p = ele[front++];
                return p;
            }

        }

        public void printQueue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine(ele[i]);
                }
            }

        }
    } 
}
