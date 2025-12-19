using System;

namespace CargoShippingDSA.Modules
{
    public static class SearchModule
    {
        public static int LinearSearch(int[] cargoIds, int key)
        {
            for (int i = 0; i < cargoIds.Length; i++)
            {
                if (cargoIds[i] == key)
                    return i;
            }
            return -1; 
        }

        public static int BinarySearch(int[] cargoIds, int key)
        {
            int left = 0;
            int right = cargoIds.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (cargoIds[mid] == key)
                    return mid;
                else if (cargoIds[mid] < key)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1; 
        }
    }
}
