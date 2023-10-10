using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithimsDataStructures.Arrays
{
    internal class LinearSearch
    {
        public bool LinSearch(int[] array, int key)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key) return true;
            }
            return false;
        }
    }
}
