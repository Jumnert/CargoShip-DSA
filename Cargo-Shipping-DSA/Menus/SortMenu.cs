using CargoShippingDSA.Modules;
using System;
using System.Collections.Generic;

public class SortMenu
{
    public static void Show()
    {
        List<CargoItem> cargos = new List<CargoItem>();
        int choice;

        do
        {
            Console.Clear();
            Console.WriteLine(@"
 .d8888b.                   888    d8b                   
d88P  Y88b                  888    Y8P                   
Y88b.                       888                          
 ""Y888b.    .d88b.  888d888 888888 888 88888b.   .d88b.  
    ""Y88b. d88""""88b 888P""   888    888 888 ""88b d88P""88b 
      ""888 888  888 888     888    888 888  888 888  888 
Y88b  d88P Y88..88P 888     Y88b.  888 888  888 Y88b 888 
 ""Y8888P""   ""Y88P""  888      ""Y888 888 888  888  ""Y88888 
                                                     888 
                                                Y8b d88P 
                                                 ""Y88P""  
                                               
            ");
            Console.WriteLine("=== Cargo Sorting Menu ===");
            Console.WriteLine("1. Add Cargo Item");
            Console.WriteLine("2. Sort Cargo by Weight");
            Console.WriteLine("3. Display Cargo Items");
            Console.WriteLine("0. Back to Main Menu");
            Console.Write("Enter choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Press any key to try again...");
                Console.ReadKey();
                continue;
            }

            Console.Clear();

            switch (choice)
            {
                case 1:
                    Console.Write("Enter cargo name: ");
                    string name = Console.ReadLine()!;
                    Console.Write("Enter cargo weight (kg): ");
                    double weight = double.Parse(Console.ReadLine()!);
                    Console.Write("Enter cargo priority (1 = highest): ");
                    int priority = int.Parse(Console.ReadLine()!);
                    cargos.Add(new CargoItem(name, weight, priority));
                    Console.WriteLine("\nCargo added successfully!");
                    break;

                case 2:
                    SortModule.SortByWeight(cargos);
                    Console.WriteLine("\nCargo sorted by weight successfully!");
                    break;

                case 3:
                    Console.WriteLine("\n--- Cargo Items ---");
                    SortModule.DisplayCargo(cargos);
                    break;

                case 0:
                    Console.WriteLine("Returning to main menu...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Press any key to try again...");
                    break;
            }

            if (choice != 0)
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey(true);
            }

        } while (choice != 0);
    }
}
