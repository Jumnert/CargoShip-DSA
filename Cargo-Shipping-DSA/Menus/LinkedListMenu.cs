
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
888      d8b          888                    888      888      d8b          888    
888      Y8P          888                    888      888      Y8P          888    
888                   888                    888      888                   888    
888      888 88888b.  888  888  .d88b.   .d88888      888      888 .d8888b  888888 
888      888 888 ""88b 888 .88P d8P  Y8b d88"" 888      888      888 88K      888    
888      888 888  888 888888K  88888888 888  888      888      888 ""Y8888b. 888    
888      888 888  888 888 ""88b Y8b.     Y88b 888      888      888      X88 Y88b.  
88888888 888 888  888 888  888  ""Y8888   ""Y88888      88888888 888  88888P'  ""Y888 
                                                                                   
                                                                                   
                                                                                                                                                                                                                                                                      
                ");
                Console.WriteLine("========== CAPTAIN TASK LIST ==========");
                Console.WriteLine("1. Add Task at Beginning");
                Console.WriteLine("2. Add Task at End");
                Console.WriteLine("3. Remove Task");
                Console.WriteLine("4. Search Task");
                Console.WriteLine("5. Display All Tasks");
                Console.WriteLine("6. Count Tasks");
                Console.WriteLine("7. Back");
                Console.WriteLine("=======================================");
                Console.Write("Choose an option: ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter new task: ");
                        list.AddFirst(Console.ReadLine()!);
                        break;

                    case "2":
                        Console.Write("Enter new task: ");
                        list.AddLast(Console.ReadLine()!);
                        break;

                    case "3":
                        Console.Write("Enter task to remove: ");
                        Console.WriteLine(list.Remove(Console.ReadLine()!)
                            ? "Task removed!"
                            : "Task not found.");
                        break;

                    case "4":
                        Console.Write("Search task: ");
                        Console.WriteLine(list.Search(Console.ReadLine()!)
                            ? "Task found!"
                            : "Task not found.");
                        break;

                    case "5":
                        Console.WriteLine(list.Display());
                        break;

                    case "6":
                        Console.WriteLine($"Total tasks: {list.Count()}");
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

