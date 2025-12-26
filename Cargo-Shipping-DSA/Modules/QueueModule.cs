using System;

namespace CargoShippingDSA.Modules
{
    public class QueueModule
    {
        private int front = 0;
        private int rear = -1;
        private int size = 5;
        private string[] queue;

        public QueueModule()
        {
            queue = new string[size];
        }

        // Add container to the queue
        public void Enqueue(string containerID)
        {
            if (rear == size - 1)
            {
                Console.WriteLine("Queue is full!");
                return;
            }

            queue[++rear] = containerID;
            Console.WriteLine($"Container {containerID} enqueued.");
        }

        // Remove container from the queue
        public void Dequeue()
        {
            if (front > rear)
            {
                Console.WriteLine("Queue is empty!");
                return;
            }

            Console.WriteLine($"Container {queue[front++]} removed from queue.");
        }

        // Peek front container
        public void Peek()
        {
            if (front > rear)
            {
                Console.WriteLine("Queue is empty!");
                return;
            }

            Console.WriteLine($"Front container: {queue[front]}");
        }

        // Display all containers in queue
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

        // Count containers in queue
        public int Count()
        {
            return (rear >= front) ? (rear - front + 1) : 0;
        }
    }
}
