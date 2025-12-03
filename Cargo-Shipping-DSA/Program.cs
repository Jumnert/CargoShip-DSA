using System;

namespace CargoShippingDSA
{
    class Program
    {
        static void Main(string[] args)
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
                        Console.WriteLine("Queue Module Selected...");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("Stack Module Selected...");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("Linked List Module Selected...");
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("Sort Module Selected...");
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.WriteLine("Search Module Selected...");
                        Console.ReadKey();
                        break;

                    case "6":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        Console.ReadKey();
                        break;
                }
            }

            Console.WriteLine("Exiting program...");
        }
    }
}
