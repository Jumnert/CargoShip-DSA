using CargoShippingDSA.Modules;
using System;

namespace CargoShippingDSA.Menus
{
    public class StackMenu
    {
        private static StackModule stack = new StackModule();

        public static void Show()
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine(@"
 .d8888b.  888                      888      
d88P  Y88b 888                      888      
Y88b.      888                      888      
 ""Y888b.   888888  8888b.   .d8888b 888  888 
    ""Y88b. 888        ""88b d88P""    888 .88P 
      ""888 888    .d888888 888      888888K  
Y88b  d88P Y88b.  888  888 Y88b.    888 ""88b 
 ""Y8888P""   ""Y888 ""Y888888  ""Y8888P 888  888 
                                             
                                             
                                                  
                ");
                Console.WriteLine("========== STACK MENU ==========");
                Console.WriteLine("1. Push container");
                Console.WriteLine("2. Pop container");
                Console.WriteLine("3. Peek top container");
                Console.WriteLine("4. Display stack");
                Console.WriteLine("5. Count containers");
                Console.WriteLine("6. Back");
                Console.WriteLine("================================");
                Console.Write("Choose an option: ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter container ID (can be letters & numbers, e.g., A12): ");
                        string? containerID = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(containerID))
                        {
                            stack.Push(containerID);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }
                        break;

                    case "2":
                        stack.Pop();
                        break;

                    case "3":
                        stack.Peek();
                        break;

                    case "4":
                        stack.Display();
                        break;

                    case "5":
                        Console.WriteLine($"Total containers: {stack.Count()}");
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
