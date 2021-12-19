using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyZaliczenie
{
    internal class BubbleSort
    {
        public static int[] BubbleSortFunction(int[] table)
        {
            bool swapped;
            for(int i = 0; i < table.Length - 1; i++)
            {
                swapped = false;
                for(int j = 0; j < table.Length -1; j++)
                {
                    if(table[j] > table[j + 1])
                    {
                        int temp = table[j];
                        table[j] = table[j + 1];
                        table[j + 1] = temp;
                        swapped = true;
                    }
                }
                if(!swapped)
                {
                    break;
                }
            }
            return table;
        }
    }
}
