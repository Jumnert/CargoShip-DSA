using System;

namespace CargoShippingDSA.Modules
{
    public static class SearchModule
    {
        // Linear search for strings (case-insensitive)
        public static int LinearSearch(string[] items, string key)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Equals(key, StringComparison.OrdinalIgnoreCase))
                    return i;
            }
            return -1;
        }
    }
}
