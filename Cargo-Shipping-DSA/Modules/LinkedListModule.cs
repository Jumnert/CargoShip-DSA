using System;
namespace CargoShippingDSA.Modules
{
    public class LinkedListNode
    {
        public string CargoName { get; set; }
        public LinkedListNode? Next { get; set; }

        public LinkedListNode(string cargo)
        {
            CargoName = cargo;
            Next = null;
        }
    }

    public class LinkedListModule
    {
        private LinkedListNode? head;

        // Add cargo at the beginning
        public void AddFirst(string cargo)
        {
            LinkedListNode newNode = new LinkedListNode(cargo);
            newNode.Next = head;
            head = newNode;
        }

        // Add cargo at the end
        public void AddLast(string cargo)
        {
            LinkedListNode newNode = new LinkedListNode(cargo);

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

        // Remove cargo by name
        public bool Remove(string cargo)
        {
            if (head == null) return false;

            if (head.CargoName == cargo)
            {
                head = head.Next;
                return true;
            }

            LinkedListNode current = head;
            LinkedListNode? prev = null;

            while (current != null && current.CargoName != cargo)
            {
                prev = current;
                current = current.Next;
            }

            if (current == null) return false;

            prev!.Next = current.Next;
            return true;
        }

        // Search
        public bool Search(string cargo)
        {
            LinkedListNode? temp = head;

            while (temp != null)
            {
                if (temp.CargoName == cargo)
                    return true;

                temp = temp.Next;
            }

            return false;
        }

        // Display
        public string Display()
        {
            if (head == null)
                return "No cargo in the list.";

            LinkedListNode current = head;
            string output = "Cargo List:\n";

            while (current != null)
            {
                output += "- " + current.CargoName + "\n";
                current = current.Next;
            }

            return output;
        }

        // Count nodes
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
