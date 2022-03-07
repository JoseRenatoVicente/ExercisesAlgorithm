using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers.SortAlgorithm
{
    public  class InsertionSort
    {
        public void sort(int[] array)
        {
            for (int left = 1; left < array.Length; left++)
            {
                int current = array[left];
                int right = left - 1;

                while (right >= 0 && array[right] > current)
                {
                    array[right + 1] = array[right];
                    right--;
                }
                array[right + 1] = current;

            }
        }
    }
}
