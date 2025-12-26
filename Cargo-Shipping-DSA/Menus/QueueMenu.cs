using System;
using CargoShippingDSA.Modules;

namespace CargoShippingDSA.Menus
{
    public class QueueMenu
    {
        private static QueueModule queue = new QueueModule();

        public static void Show()
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine(@"
 .d88888b.                                      
d88P"" ""Y88b                                     
888     888                                     
888     888 888  888  .d88b.  888  888  .d88b.  
888     888 888  888 d8P  Y8b 888  888 d8P  Y8b 
888 Y8b 888 888  888 88888888 888  888 88888888 
Y88b.Y8b88P Y88b 888 Y8b.     Y88b 888 Y8b.     
 ""Y888888""   ""Y88888  ""Y8888   ""Y88888  ""Y8888  
       Y8b                                      
                                                
                                                               
                ");
                Console.WriteLine("========== QUEUE MENU ==========");
                Console.WriteLine("1. Enqueue container");
                Console.WriteLine("2. Dequeue container");
                Console.WriteLine("3. Peek front container");
                Console.WriteLine("4. Display all containers");
                Console.WriteLine("5. Count containers");
                Console.WriteLine("6. Back");
                Console.WriteLine("================================");
                Console.Write("Choose an option: ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Container ID to enqueue (e.g., A12): ");
                        string? containerID = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(containerID))
                            queue.Enqueue(containerID);
                        else
                            Console.WriteLine("Invalid input.");
                        break;

                    case "2":
                        queue.Dequeue();
                        break;

                    case "3":
                        queue.Peek();
                        break;

                    case "4":
                        queue.Display();
                        break;

                    case "5":
                        Console.WriteLine($"Total containers: {queue.Count()}");
                        break;

                    case "6":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                if (!exit)
                {
                    Console.Write("\nPress any key to continue...");
                    Console.ReadKey(true);
                }
            }
        }
    }
}
