using System;
using CargoShippingDSA.Menus; // <-- This lets you use QueueMenu, StackMenu, etc.
namespace CargoShippingDSA
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();

                Console.WriteLine(@"
                                                                                                                 
   _____                         _____ _     _             _               _____   _____         
  / ____|                       / ____| |   (_)           (_)             |  __ \ / ____|  /\    
 | |     __ _ _ __ __ _  ___   | (___ | |__  _ _ __  _ __  _ _ __   __ _  | |  | | (___   /  \   
 | |    / _` | '__/ _` |/ _ \   \___ \| '_ \| | '_ \| '_ \| | '_ \ / _` | | |  | |\___ \ / /\ \  
 | |___| (_| | | | (_| | (_) |  ____) | | | | | |_) | |_) | | | | | (_| | | |__| |____) / ____ \ 
  \_____\__,_|_|  \__, |\___/  |_____/|_| |_|_| .__/| .__/|_|_| |_|\__, | |_____/|_____/_/    \_\
                   __/ |                      | |   | |             __/ |                        
                  |___/                       |_|   |_|            |___/                                                                                                     
                ");
                Console.WriteLine("=======================================");
                Console.WriteLine("1. Queue");
                Console.WriteLine("2. Stacks");
                Console.WriteLine("3. Linked List");
                Console.WriteLine("4. Sort");
                Console.WriteLine("5. Search");
                Console.WriteLine("6. Exit");
                Console.WriteLine("=======================================");
                Console.Write("Enter your choice: ");

                string? input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        //QueueMenu.Show();
                        break;

                    case "2":
                        //StackMenu.Show();
                        break;

                    case "3":
                        //LinkedListMenu.Show();
                        break;

                    case "4":
                        //SortMenu.Show();
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
