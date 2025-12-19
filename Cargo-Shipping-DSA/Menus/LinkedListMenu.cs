using CargoShippingDSA.Modules;
using System;
namespace CargoShippingDSA.Menus
{
    public class LinkedListMenu
    {
        private static LinkedListModule list = new LinkedListModule();

        public static void Show()
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine(@"                                                                                                                                                                               
  _     _       _            _   _     _     _       
 | |   (_)_ __ | | _____  __| | | |   (_)___| |_ ___ 
 | |   | | '_ \| |/ / _ \/ _` | | |   | / __| __/ __|
 | |___| | | | |   <  __/ (_| | | |___| \__ \ |_\__ \
 |_____|_|_| |_|_|\_\___|\__,_| |_____|_|___/\__|___/                                                                                                                                                                                          
                ");
                Console.WriteLine("========== LINKED LIST MENU ==========");
                Console.WriteLine("1. Add Cargo at Beginning");
                Console.WriteLine("2. Add Cargo at End");
                Console.WriteLine("3. Remove Cargo");
                Console.WriteLine("4. Search Cargo");
                Console.WriteLine("5. Display List");
                Console.WriteLine("6. Count Cargo");
                Console.WriteLine("7. Back");
                Console.WriteLine("=======================================");
                Console.Write("Choose an option: ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter cargo name: ");
                        list.AddFirst(Console.ReadLine()!);
                        break;

                    case "2":
                        Console.Write("Enter cargo name: ");
                        list.AddLast(Console.ReadLine()!);
                        break;

                    case "3":
                        Console.Write("Enter cargo name to remove: ");
                        Console.WriteLine(list.Remove(Console.ReadLine()!)
                            ? "Cargo removed!"
                            : "Cargo not found.");
                        break;

                    case "4":
                        Console.Write("Search cargo: ");
                        Console.WriteLine(list.Search(Console.ReadLine()!)
                            ? "Cargo found!"
                            : "Cargo not found.");
                        break;

                    case "5":
                        Console.WriteLine(list.Display());
                        break;

                    case "6":
                        Console.WriteLine($"Total cargo: {list.Count()}");
                        break;

                    case "7":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid input. Try again.");
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
