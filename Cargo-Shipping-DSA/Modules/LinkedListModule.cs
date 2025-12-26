using System;

namespace CargoShippingDSA.Modules
{
    public class LinkedListNode
    {
        public string Task { get; set; }
        public LinkedListNode? Next { get; set; }

        public LinkedListNode(string task)
        {
            Task = task;
            Next = null;
        }
    }

    public class LinkedListModule
    {
        private LinkedListNode? head;

        // Add task at the beginning
        public void AddFirst(string task)
        {
            LinkedListNode newNode = new LinkedListNode(task);
            newNode.Next = head;
            head = newNode;
        }

        // Add task at the end
        public void AddLast(string task)
        {
            LinkedListNode newNode = new LinkedListNode(task);

            if (head == null)
            {
                head = newNode;
                return;
            }

            LinkedListNode current = head;
            while (current.Next != null)
                current = current.Next;

            current.Next = newNode;
        }

        // Remove task
        public bool Remove(string task)
        {
            if (head == null) return false;

            if (head.Task == task)
            {
                head = head.Next;
                return true;
            }

            LinkedListNode current = head;
            LinkedListNode? prev = null;

            while (current != null && current.Task != task)
            {
                prev = current;
                current = current.Next;
            }

            if (current == null) return false;

            prev!.Next = current.Next;
            return true;
        }

        // Search task
        public bool Search(string task)
        {
            LinkedListNode? temp = head;

            while (temp != null)
            {
                if (temp.Task == task)
                    return true;

                temp = temp.Next;
            }

            return false;
        }

        // Display tasks
        public string Display()
        {
            if (head == null)
                return "No tasks assigned.";

            LinkedListNode current = head;
            string output = "Captain Tasks:\n";

            while (current != null)
            {
                output += "- " + current.Task + "\n";
                current = current.Next;
            }

            return output;
        }

        // Count tasks
        public int Count()
        {
            int count = 0;
            LinkedListNode? temp = head;

            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }

            return count;
        }
    }
}
