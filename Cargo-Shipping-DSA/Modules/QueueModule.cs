using System;

namespace CargoShippingDSA.Modules
{
    public class QueueModule
    {
        private int front = 0;
        private int rear = -1;
        private int size = 5;
        private int[] queue;

        public QueueModule()
        {
            queue = new int[size];
        }


        public void Enqueue(int cargo)
        {
            if (rear == size - 1)
            {
                Console.WriteLine("Queue is full!");
                return;
            }

            queue[++rear] = cargo;
            Console.WriteLine($"Cargo {cargo} enqueued.");
        }


        // Remove cargo from the queue
        public void Dequeue()
        {
            if (front > rear)
            {
                Console.WriteLine("Queue is empty!");
                return;
            }

            Console.WriteLine($"Cargo {queue[front++]} removed from queue.");
        }

        // Peek front cargo
        public void Peek()
        {
            if (front > rear)
            {
                Console.WriteLine("Queue is empty!");
                return;
            }

            Console.WriteLine($"Front cargo: {queue[front]}");
        }

        // Display all cargos in queue
        public void Display()
        {
            if (front > rear)
            {
                Console.WriteLine("Queue is empty!");
                return;
            }

            Console.WriteLine("\nQueue contents:");
            for (int i = front; i <= rear; i++)
            {
                Console.WriteLine($"- {queue[i]}");
            }
        }

        // Count cargos in queue
        public int Count()
        {
            return (rear >= front) ? (rear - front + 1) : 0;
        }
    }
}
