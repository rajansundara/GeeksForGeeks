using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomStack p = new CustomStack(3);

            p.push(10);
            p.push(20);
            p.push(30);
            p.printStack();
            Console.WriteLine();
            p.pop();
            p.pop();
            p.printStack();

            

            Console.WriteLine();
            Console.WriteLine("****************");            

            Stack q = new Stack();
            q.Push(10);
            q.Push(20);
            q.Push(30);            
            PrintValues(q);
            Console.WriteLine();
            q.Pop();
            q.Pop();
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

    class CustomStack
    {
        private int[] ele; 
        private int top; 
        private int max;
        public CustomStack(int size) 
        { 
            ele = new int[size];
            top = -1; 
            max = size; 
        } 
  
        public void push(int item) 
        { 
            if (top == max-1) 
            { 
                Console.WriteLine("Stack Overflow"); 
                return; 
            } 
            else
            { 
                ele[++top] = item; 
            } 
        } 
  
        public int pop() 
        {  
            if(top == -1) 
            { 
                Console.WriteLine("Stack is Empty"); 
                return -1; 
            } 
            else
            {
                return ele[top--]; 
            } 
        } 
  
        public void printStack() 
        { 
            if (top == -1) 
            { 
                Console.WriteLine("Stack is Empty"); 
                return; 
            } 
            else
            { 
                for (int i = top; i >= 0; i--) 
                { 
                    Console.WriteLine("{0}", ele[i]); 
                } 
            } 
        } 
    } 
}
