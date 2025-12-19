using System;
using CargoShippingDSA.Menus;
using CargoShippingDSA.Modules;
namespace CargoShippingDSA.Modules;
using System.Collections.Generic;

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

    public override string ToString() => $"{Name}: {Weight}kg (Priority: {Priority})";
}

public class SortModule
{
    // Bubble Sort for Weight
    public static void SortByWeight(List<CargoItem> cargos)
    {
        for (int i = 0; i < cargos.Count - 1; i++)
        {
            for (int j = 0; j < cargos.Count - i - 1; j++)
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

    // Selection Sort for Priority
    public static void SortByPriority(List<CargoItem> cargos)
    {
        for (int i = 0; i < cargos.Count - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < cargos.Count; j++)
            {
                if (cargos[j].Priority < cargos[minIndex].Priority)
                {
                    minIndex = j;
                }
            }
            var temp = cargos[i];
            cargos[i] = cargos[minIndex];
            cargos[minIndex] = temp;
        }
    }

    public static void DisplayCargo(List<CargoItem> cargos)
    {
        foreach (var c in cargos) Console.WriteLine(c);
    }

}


