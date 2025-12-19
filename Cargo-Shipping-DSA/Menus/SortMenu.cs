using System;
using CargoShippingDSA.Modules;
namespace CargoShippingDSA.Menus;
public class SortMenu
{
    public static void Show(List<CargoItem> cargos)
    {
        int choice;

        do
        {
            Console.WriteLine("\n=== Cargo Sorting Menu ===");
            Console.WriteLine("1. Sort by Weight");
            Console.WriteLine("2. Sort by Priority");
            Console.WriteLine("3. Display Cargo");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    SortModule.SortByWeight(cargos);
                    Console.WriteLine("Sorted by weight.");
                    break;

                case 2:
                    SortModule.SortByPriority(cargos);
                    Console.WriteLine("Sorted by priority.");
                    break;

                case 3:
                    SortModule.DisplayCargo(cargos);
                    break;

                case 0:
                    Console.WriteLine("Exit program.");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 0);
    }
}
