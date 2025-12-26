using System;

namespace CargoShippingDSA.Modules
{
    public class StackModule
    {
        private int top = -1;
        private int size = 5;
        private string[] stack;

        public StackModule()
        {
            stack = new string[size];
        }

        // Add container to the stack
        public void Push(string container)
        {
            if (top == size - 1)
            {
                Console.WriteLine("Stack is full!");
                return;
            }

            stack[++top] = container;
            Console.WriteLine($"Container pushed: {container}");
        }

        // Remove container from the stack
        public void Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty!");
                return;
            }

            Console.WriteLine($"Container popped: {stack[top--]}");
        }

        // Peek top container
        public void Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty!");
                return;
            }

            Console.WriteLine($"Top container: {stack[top]}");
        }

        // Display all containers visually
        public void Display()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty!");
                return;
            }

            Console.WriteLine("\n--- Stack (Top → Bottom) ---");

            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine("+-------+");
                Console.WriteLine($"| {stack[i],-5} |"); // left-align within 5 spaces
            }
            Console.WriteLine("+-------+");
        }

        // Count containers
        public int Count()
        {
            return top + 1;
        }
    }
}
