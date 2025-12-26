using CargoShippingDSA.Modules;
using System;

namespace CargoShippingDSA.Menus
{
    public static class SearchMenu
    {
        public static void Show()
        {
            string choice;
            do
            {
                Console.Clear();
                Console.WriteLine(@"
 .d8888b.                                    888      
d88P  Y88b                                   888      
Y88b.                                        888      
 ""Y888b.    .d88b.   8888b.  888d888 .d8888b 88888b.  
    ""Y88b. d8P  Y8b     ""88b 888P""  d88P""    888 ""88b 
      ""888 88888888 .d888888 888    888      888  888 
Y88b  d88P Y8b.     888  888 888    Y88b.    888  888 
 ""Y8888P""   ""Y8888  ""Y888888 888     ""Y8888P 888  888 
                                                      
                                                      
                                                       
                ");
                Console.WriteLine("=== Cargo Shipping Search Menu ===");
                Console.WriteLine("1. Linear Search by Container ID / Cargo Name");
                Console.WriteLine("0. Back to Main Menu");
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1":
                        LinearSearchMenu();
                        break;
                    case "0":
                        Console.WriteLine("Returning to main menu...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Press any key to try again...");
                        Console.ReadKey();
                        break;
                }

            } while (choice != "0");
        }

        private static void LinearSearchMenu()
        {
            Console.Clear();
            Console.WriteLine(@"
 .d8888b.                                    888      d8b                   
d88P  Y88b                                   888      Y8P                   
Y88b.                                        888                            
 ""Y888b.    .d88b.   8888b.  888d888 .d8888b 88888b.  888 88888b.   .d88b.  
    ""Y88b. d8P  Y8b     ""88b 888P""  d88P""    888 ""88b 888 888 ""88b d88P""88b 
      ""888 88888888 .d888888 888    888      888  888 888 888  888 888  888 
Y88b  d88P Y8b.     888  888 888    Y88b.    888  888 888 888  888 Y88b 888 
 ""Y8888P""   ""Y8888  ""Y888888 888     ""Y8888P 888  888 888 888  888  ""Y88888 
                                                                        888 
                                                                   Y8b d88P 
                                                                    ""Y88P""  
                ");
            Console.WriteLine("=== Linear Search ===");

            int n = GetPositiveInt("Enter number of containers/cargo items: ");
            string[] items = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter Container ID / Cargo Name {i + 1}: ");
                items[i] = Console.ReadLine()!;
            }

            Console.Write("Enter Container ID / Cargo Name to search: ");
            string key = Console.ReadLine()!;

            int result = SearchModule.LinearSearch(items, key);

            if (result != -1)
                Console.WriteLine($"\n'{key}' found at position {result + 1}");
            else
                Console.WriteLine($"\n'{key}' not found");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        private static int GetPositiveInt(string prompt)
        {
            int value;
            do
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                while (!int.TryParse(input, out value))
                {
                    Console.Write("Invalid input. Try again: ");
                    input = Console.ReadLine();
                }

                if (value <= 0)
                    Console.WriteLine("Number must be positive.");

            } while (value <= 0);

            return value;
        }
    }
}
