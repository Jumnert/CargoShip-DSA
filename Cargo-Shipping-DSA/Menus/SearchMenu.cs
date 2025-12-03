using System;
using CargoShippingDSA.Modules;

namespace CargoShippingDSA.Menus
{
    public static class SearchMenu
    {
        public static void Show()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Cargo Shipping Search Menu ===");
                Console.WriteLine("1. Linear Search Cargo ID");
                Console.WriteLine("2. Binary Search Cargo ID (sorted automatically)");
                Console.WriteLine("0. Back to Main Menu");
                Console.Write("Enter your choice: ");

                string? input = Console.ReadLine();
                while (!int.TryParse(input, out choice))
                {
                    Console.Write("Invalid input. Enter a number: ");
                    input = Console.ReadLine();
                }

                switch (choice)
                {
                    case 1:
                        LinearSearchMenu();
                        break;
                    case 2:
                        BinarySearchMenu();
                        break;
                    case 0:
                        Console.WriteLine("Returning to main menu...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Press any key to try again...");
                        Console.ReadKey();
                        break;
                }

            } while (choice != 0);
        }

        private static void LinearSearchMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Linear Search Cargo ID ===");

            int n = GetPositiveInt("Enter number of cargos: ");
            int[] cargoIds = new int[n];

            for (int i = 0; i < n; i++)
            {
                cargoIds[i] = GetInt($"Enter Cargo ID {i + 1}: ");
            }

            int key = GetInt("Enter Cargo ID to search: ");
            int result = SearchModule.LinearSearch(cargoIds, key);

            if (result != -1)
                Console.WriteLine($"Cargo ID {key} found at position {result + 1}");
            else
                Console.WriteLine($"Cargo ID {key} not found");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void BinarySearchMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Binary Search Cargo ID ===");

            int n = GetPositiveInt("Enter number of cargos: ");
            int[] cargoIds = new int[n];

            for (int i = 0; i < n; i++)
            {
                cargoIds[i] = GetInt($"Enter Cargo ID {i + 1}: ");
            }

            int key = GetInt("Enter Cargo ID to search: ");
            Array.Sort(cargoIds);

            Console.WriteLine("\nSorted Cargo IDs:");
            Console.WriteLine(string.Join(", ", cargoIds));

            int result = SearchModule.BinarySearch(cargoIds, key);

            if (result != -1)
                Console.WriteLine($"\nCargo ID {key} found at position {result + 1}");
            else
                Console.WriteLine($"\nCargo ID {key} not found");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private static int GetInt(string prompt)
        {
            int value;
            Console.Write(prompt);
            string? input = Console.ReadLine();

            while (!int.TryParse(input, out value))
            {
                Console.Write("Invalid input. Try again: ");
                input = Console.ReadLine();
            }
            return value;
        }
        private static int GetPositiveInt(string prompt)
        {
            int value;
            do
            {
                value = GetInt(prompt);
                if (value <= 0)
                    Console.WriteLine("Number must be positive.");
            } while (value <= 0);

            return value;
        }
    }
}
