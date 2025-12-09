using System;

namespace CargoShippingDSA.Modules
{
    public class StackModule
    {
        private int top = -1;
        private int size = 5;
        private int[] stack;

        public StackModule()
        {
            stack = new int[size];
        }

        // Add cargo to the stack
        public void Push(int cargo)
        {
            if (top == size - 1)
            {
                Console.WriteLine("Stack is full!");
                return;
            }

            stack[++top] = cargo;
            Console.Write("Cargo " + cargo + " pushed to stack.\n");

        }


        // Remove cargo from the stack
        public void Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty!");
                return;
            }

            Console.WriteLine($"Cargo {stack[top--]} popped from stack.");
        }

        // Peek top cargo
        public void Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty!");
                return;
            }

            Console.WriteLine($"Top cargo: {stack[top]}");
        }

        // Display all cargos
        public void Display()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty!");
                return;
            }

            Console.WriteLine("\nStack contents (top to bottom):");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine("- " + stack[i]);

            }
        }

        // Count cargos
        public int Count()
        {
            return top + 1;
        }
    }
}
