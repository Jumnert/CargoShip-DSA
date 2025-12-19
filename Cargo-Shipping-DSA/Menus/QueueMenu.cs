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
    ___                        
  / _ \ _   _  ___ _   _  ___ 
 | | | | | | |/ _ \ | | |/ _ \
 | |_| | |_| |  __/ |_| |  __/
  \__\_\\__,_|\___|\__,_|\___|                                                                                                                                                                                                                    
                ");
                Console.WriteLine("========== QUEUE MENU ==========");
                Console.WriteLine("1. Enqueue cargo");
                Console.WriteLine("2. Dequeue cargo");
                Console.WriteLine("3. Peek front cargo");
                Console.WriteLine("4. Display all cargos");
                Console.WriteLine("5. Count cargos");
                Console.WriteLine("6. Back");
                Console.WriteLine("================================");
                Console.Write("Choose an option: ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter cargo ID to enqueue: ");
                        if (int.TryParse(Console.ReadLine(), out int cargo))
                            queue.Enqueue(cargo); // Pass to module
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
                        Console.WriteLine($"Total cargos: {queue.Count()}");
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
                    Console.Write("\nPress any key...");
                    Console.ReadKey(true);
                }
            }
        }
    }
}
