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
  ____  _             _    
 / ___|| |_ __ _  ___| | __
 \___ \| __/ _` |/ __| |/ /
  ___) | || (_| | (__|   < 
 |____/ \__\__,_|\___|_|\_\                                                                                                                                                                                                                                                        
                ");
                Console.WriteLine("========== STACK MENU ==========");
                Console.WriteLine("1. Push cargo");
                Console.WriteLine("2. Pop cargo");
                Console.WriteLine("3. Peek top cargo");
                Console.WriteLine("4. Display stack");
                Console.WriteLine("5. Count cargos");
                Console.WriteLine("6. Back");
                Console.WriteLine("================================");
                Console.Write("Choose an option: ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter cargo ID to push: ");
                        if (int.TryParse(Console.ReadLine(), out int cargo))
                            stack.Push(cargo);
                        else
                            Console.WriteLine("Invalid input.");
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
                        Console.WriteLine($"Total cargos: {stack.Count()}");
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
