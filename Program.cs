using System;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // TestStack test = new TestStack();

            // test.testStack();
           
            ReverseSentence sentence = new ReverseSentence();
       }
    }

    class Stack 
    {
        // Create array to form base of stack
        private string[] stack;

        // Creates front pointer
        private int front;

        public Stack(int length) 
        {
            // Create array to form base of stack
            stack = new string[length];

            // Creates front pointer
            front = length;
            // Console.WriteLine(Convert.ToString(length));
        }

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
            if (front >= stack.Length)
                return true;

            return false;
        }
    }

    class TestStack
    {
        public void testStack() 
        {
            // Create new instance of Stack
            Stack st = new Stack(8);

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

    class ReverseSentence 
    {
        public ReverseSentence() 
        {
            Console.WriteLine("Enter a sentence you would like to reverse: ");
            string sentence = Console.ReadLine();

            string[] temp = sentence.Split(' ');

            int length = temp.Length;
            Stack stack = new Stack(length);

            foreach (string str in temp) {
                stack.push(str);
                // Console.WriteLine(str);
            }

            // stack.pop();
            // stack.peek();

            sentence = "";

            for (int i = 0; i <= length; i++) {
                sentence += stack.pop() + " ";
            }

            Console.WriteLine($"The reversed sentence is\n{sentence}");
        }
    }
}
