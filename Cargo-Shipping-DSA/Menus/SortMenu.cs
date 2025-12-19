using CargoShippingDSA.Modules;

public class SortMenu
{
    public static void Show()
    {
        List<CargoItem> cargos = new List<CargoItem>();
        int choice;
        do
        {
            Console.WriteLine("\n=== Cargo Sorting Menu ===");
            Console.WriteLine("1. Add Cargo Item");
            Console.WriteLine("2. Sort by Weight");
            Console.WriteLine("3. Sort by Priority");
            Console.WriteLine("4. Display Cargo");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter weight: ");
                    double weight = double.Parse(Console.ReadLine());
                    Console.Write("Enter priority: ");
                    int priority = int.Parse(Console.ReadLine());
                    cargos.Add(new CargoItem(name, weight, priority));
                    Console.WriteLine("Cargo added.");
                    break;
                case 2:
                    SortModule.SortByWeight(cargos);
                    Console.WriteLine("Sorted by weight.");
                    break;
                case 3:
                    SortModule.SortByPriority(cargos);
                    Console.WriteLine("Sorted by priority.");
                    break;
                case 4:
                    SortModule.DisplayCargo(cargos);
                    break;
                case 0:
                    Console.WriteLine("Returning to main menu.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        } while (choice != 0);
    }
}