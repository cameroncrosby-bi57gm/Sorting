using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class MergeSort
    {
        public static void Perform(List<double> listToSort)
        {
            if (listToSort.Count <= 1) //checking to see if the list is greater than 1
                return;

            int mid = listToSort.Count / 2; //halfs the list

            List<double> left = listToSort.GetRange(0, mid);//gets values of first in array, to central
            List<double> right = listToSort.GetRange(mid, listToSort.Count - mid); //gets the values from middle, to last in array

            Perform(left);
            Perform(right);

            Merge(listToSort, left, right); //merges the two halves back together
        }

        private static void Merge(List<double> listToSort, List<double> left, List<double> right) //using comparison to check if each side of the array has 1 or less values 
        {
            int leftIndex = 0, rightIndex = 0, sortedIndex = 0;

            while (leftIndex < left.Count && rightIndex < right.Count) //comparing if the index is bigger than the length of the array
            {
                if (left[leftIndex] <= right[rightIndex]) //compares the values of the left side to the right
                {
                    listToSort[sortedIndex] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    listToSort[sortedIndex] = right[rightIndex];
                    rightIndex++;
                }
                sortedIndex++;
            }

            while (leftIndex < left.Count)
            {
                listToSort[sortedIndex] = left[leftIndex];
                leftIndex++;
                sortedIndex++;
            }

            while (rightIndex < right.Count)
            {
                listToSort[sortedIndex] = right[rightIndex];
                rightIndex++;
                sortedIndex++;
            }
        }
    }
}
