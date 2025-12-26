using System;
using System.Collections.Generic;

namespace CargoShippingDSA.Modules
{
    public class CargoItem
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Priority { get; set; }

        public CargoItem(string name, double weight, int priority)
        {
            Name = name;
            Weight = weight;
            Priority = priority;
        }

        public override string ToString() => $"{Name}: {Weight} kg (Priority: {Priority})";
    }

    public static class SortModule
    {
        // Bubble Sort based on Weight
        public static void SortByWeight(List<CargoItem> cargos)
        {
            int n = cargos.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (cargos[j].Weight > cargos[j + 1].Weight)
                    {
                        var temp = cargos[j];
                        cargos[j] = cargos[j + 1];
                        cargos[j + 1] = temp;
                    }
                }
            }
        }

        public static void DisplayCargo(List<CargoItem> cargos)
        {
            if (cargos.Count == 0)
            {
                Console.WriteLine("No cargo items to display.");
                return;
            }

            Console.WriteLine("\n--- Cargo Items ---");
            foreach (var cargo in cargos)
            {
                Console.WriteLine(cargo);
            }
        }
    }
}
