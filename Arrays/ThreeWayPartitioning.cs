using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class ThreeWayPartitioning
    {
        public static void Exchange(int[] arr, int minIndex, int indextoSwap)
        {
            var swap = arr[minIndex];
            arr[minIndex] = arr[indextoSwap];
            arr[indextoSwap] = swap;
        }

        public static void threeWayPartition(int[] arr, int low, int high)
        {
            int start = 0;
            int end = arr.Length - 1;
            int exchanges = 0;
            for (int i = 0; i <= end;)
            {
                // If current element is smaller than 
                // range, put it on next available smaller 
                // position. 
                if (arr[i] < low)
                {
                    Exchange(arr, i++, start++);
                    exchanges++;
                }

                // If current element is greater than 
                // range, put it on next available greater 
                // position. 
                else if (arr[i] > high)
                {
                    exchanges++;
                    Exchange(arr, i, end--);
                }

                else
                    i++;
            }

            if (exchanges == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(1);
            }
        }
    }
}
