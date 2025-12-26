using CargoShippingDSA.Menus;
using CargoShippingDSA.Modules;
using System;
using System.Collections.Generic;

namespace CargoShippingDSA
{
    class Program
    {
        private static List<CargoItem> sharedCargos = new List<CargoItem>();

        public static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();

                Console.WriteLine(@"
                                                                                                                 
 .d8888b.                                     .d8888b.  888      d8b                   d8b                        8888888b.   .d8888b.        d8888 
d88P  Y88b                                   d88P  Y88b 888      Y8P                   Y8P                        888  ""Y88b d88P  Y88b      d88888 
888    888                                   Y88b.      888                                                       888    888 Y88b.          d88P888 
888         8888b.  888d888 .d88b.   .d88b.   ""Y888b.   88888b.  888 88888b.  88888b.  888 88888b.   .d88b.       888    888  ""Y888b.      d88P 888 
888            ""88b 888P""  d88P""88b d88""""88b     ""Y88b. 888 ""88b 888 888 ""88b 888 ""88b 888 888 ""88b d88P""88b      888    888     ""Y88b.   d88P  888 
888    888 .d888888 888    888  888 888  888       ""888 888  888 888 888  888 888  888 888 888  888 888  888      888    888       ""888  d88P   888 
Y88b  d88P 888  888 888    Y88b 888 Y88..88P Y88b  d88P 888  888 888 888 d88P 888 d88P 888 888  888 Y88b 888      888  .d88P Y88b  d88P d8888888888 
 ""Y8888P""  ""Y888888 888     ""Y88888  ""Y88P""   ""Y8888P""  888  888 888 88888P""  88888P""  888 888  888  ""Y88888      8888888P""   ""Y8888P"" d88P     888 
                                888                                  888      888                        888                                        
                           Y8b d88P                                  888      888                   Y8b d88P                                        
                            ""Y88P""                                   888      888                    ""Y88P""                                                                                                                                           
                ");
                Console.WriteLine("=======================================");
                Console.WriteLine("1. Queue (Cargo Management)");
                Console.WriteLine("2. Stack (Container Management)");
                Console.WriteLine("3. Linked List (Captain Task List)");
                Console.WriteLine("4. Sorting Cargo (by Weight)");
                Console.WriteLine("5. Searching Cargo (Linear Search)");
                Console.WriteLine("6. Exit");
                Console.WriteLine("=======================================");
                Console.Write("Enter your choice: ");

                string? input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        QueueMenu.Show();
                        break;

                    case "2":
                        StackMenu.Show();
                        break;

                    case "3":
                        LinkedListMenu.Show();
                        break;

                    case "4":
                        SortMenu.Show();
                        break;

                    case "5":
                        SearchMenu.Show();
                        break;

                    case "6":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }

            Console.WriteLine("Exiting program...");
        }
    }
}
