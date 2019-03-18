using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class TrappingRainWater
    {
        public static void fnTrappingRainWater1(int[] arr, int n)
        {
            int capacity = 0;
            int lastMaxBlockId = 0;
            int[] capacityArray = new int[n];
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i - 1; j > lastMaxBlockId; j--)
                {
                    if (arr[j] > arr[i])
                        break;

                    if (arr[i] >= arr[lastMaxBlockId])
                    {
                        capacityArray[j] = (arr[lastMaxBlockId] - arr[j]);
                    }
                    else
                    {
                        if (capacityArray[j] < arr[i] - arr[j])
                            capacityArray[j] = (arr[i] - arr[j]);
                    }
                }

                if (arr[i] >= arr[lastMaxBlockId])
                {
                    lastMaxBlockId = i;
                }
            }

            for (int i = 0; i < capacityArray.Length; i++)
            {
                capacity += capacityArray[i];
            }

            Console.WriteLine(capacity);
        }

        public static void fnTrappingRainWater(int[] arr, int n)
        {
            int[] left = new int[n];
            int[] right = new int[n];

            left[0] = arr[0];
            for (int i = 1; i < n; i++)
            {
                left[i] = Math.Max(left[i - 1], arr[i]);
            }

            right[n - 1] = arr[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                right[i] = Math.Max(right[i + 1], arr[i]);
            }

            int capacity = 0;

            for (int i = 0; i < n; i++)
            {
                capacity += Math.Min(left[i], right[i]) - arr[i];
            }

            Console.WriteLine(capacity);
        }

        public static void fnTrappingRainWater3(int[] arr, int n)
        {
            // initialize output 
            int result = 0;

            // maximum element on left and right 
            int left_max = 0, right_max = 0;

            // indices to traverse the array 
            int lo = 0, hi = n - 1;

            while (lo <= hi)
            {
                if (arr[lo] < arr[hi])
                {
                    if (arr[lo] > left_max)

                        // update max in left 
                        left_max = arr[lo];
                    else

                        // water on curr element =  
                        // max - curr 
                        result += left_max - arr[lo];
                    lo++;
                }
                else
                {
                    if (arr[hi] > right_max)

                        // update right maximum 
                        right_max = arr[hi];

                    else
                        result += right_max - arr[hi];
                    hi--;
                }
            }


            Console.WriteLine(result);
        }
    }
}
