using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class BubbleSort
    {
        public static void Perform(List<double> listToSort)
        {
            bool swapped = true;
            double temp;

            while (swapped)
            {
                swapped = false;
                for(int i = 0; i<listToSort.Count -1; i++)
                {
                    if (listToSort[i] > listToSort[i+1])
                    {
                        temp = listToSort[i];
                        listToSort[i]=listToSort[i+1];
                        listToSort[i+1]=temp;
                        swapped = true;
                    }
                }
            }
        }
    }
}
