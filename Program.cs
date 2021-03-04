﻿using System;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            
            // Create new instance of Stack
            Stack st = new Stack();

            st.push("pog");
            st.push("pog");
            st.push("pog");
            st.push("pog");
            st.push("pog");
            st.push("pog");
            st.push("pog");
            st.push("pog");

            // This will not be pushed, as the stack is full
            st.push("pog");

            st.pop();
            st.pop();
            st.pop();
            st.pop();
            st.pop();
            st.pop();
            st.pop();
            st.pop();

            // This will not work, as the stack is empty
            st.pop();

            st.push("cool");
            st.pop();
        }
    }

    class Stack 
    {
        // Create array to form base of stack
        private string[] stack = new string[8];

        // Creates front pointer
        private int front = 8;

        public bool push(string item) 
        {
            // If the stack is full, the item will not be pushed, otherwise it will
            Console.WriteLine($"Pushing {item}. . .");

            if (!isFull()) {
                Console.WriteLine($"Successfully pushed {item}!");

                front--;
                stack[front] = item;
                return true;
            }

            Console.WriteLine($"Failed to push {item}, stack is already full! ");
            return false;
        }

        public string pop()
        {
            // If the stack is not empty, remove and return item on top of stack, otherwise don't
            Console.WriteLine("Popping top of stack. . . ");

            if (!isEmpty()) {
                string item = stack[front];

                Console.WriteLine($"Successfully popped {item}!");

                front++;
                return item;
            }
            
            Console.WriteLine("Could not pop, stack is already empty!");
            return null;
        }

        public string peek()
        {
            // If stack not empty, display item at top of stack, else don't

            if (!isEmpty()) {
                Console.WriteLine(stack[front]);
                return stack[front];
            }

            Console.WriteLine("Could not peek, stack is empty!");
            return null;
        }

        public bool isFull() 
        {
            // If the front pointer points to the front of the array, the stack is full
            if (front <= 0)
                return true;
            
            return false;
        }

        public bool isEmpty() 
        {
            // If the pointer points to the end of the array, the stack is empty
            if (front >= 8)
                return true;

            return false;
        }
    }
}
