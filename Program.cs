using System;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            
            Stack st = new Stack();

            st.push("pog");

            Console.WriteLine(st.pop());
        }
    }

    class Stack 
    {
        private string[] stack = new string[8];

        private int front = 8;
        private int rear = 8;

        public bool push(string item) 
        {
            if (!isFull()) {
                front--;
                stack[front] = item;
                return true;
            }

            return false;
        }

        public string pop()
        {
            if (!isEmpty()) {
                string item = stack[front];
                front++;
                return item;
            }
            
            return null;
        }

        public bool isFull() 
        {
            if (front <= 0)
                return true;
            
            return false;
        }

        public bool isEmpty() 
        {
            if (front >= 8)
                return true;

            return false;
        }
    }
}
