using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class PairWithGivenSum
    {
        public static void isPairSum(int[] A, int X)
        {
            int N = A.Length;
            // represents first pointer 
            int i = 0;
            bool found = false;
            // represents second pointer 
            int j = N - 1;

            while (i < j)
            {

                // If we find a pair 
                if (A[i] + A[j] == X)
                {
                    if (!found)
                        found = true;

                    Console.WriteLine(A[i] + " " + A[j] + " " + X);
                    i++;
                    j--;
                }

                // If sum of elements at current 
                // pointers is less, we move towards 
                // higher values by doing i++ 
                else if (A[i] + A[j] < X)
                    i++;

                // If sum of elements at current 
                // pointers is more, we move towards 
                // lower values by doing i++ 
                else
                    j--;
            }

            if(!found)
                Console.WriteLine(-1);
        }

        /// <summary>
        /// O(nlogn)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="elementsum"></param>
        public static void FindPairs(int[] arr, int elementsum)
        {
            int n = arr.Length;
            bool found = false;
            for (int i = 0; i < n; i++)
            {
                int a1 = arr[i];
                int diff = elementsum - a1;
                var a2 = BinarySearch(arr, i + 1, arr.Length - 1, diff);

                if (a2 != -1)
                {
                    found = true;
                    Console.WriteLine(a1 + " " + a2);
                }
            }

            if (!found)
                Console.WriteLine(-1);
        }

        private static int BinarySearch(int[] arr, int lo, int high, int diff)
        {
            if (lo > high)
            {
                return -1;
            }

            int mid = (lo + high) / 2;
            if (diff == arr[mid])
            {
                return arr[mid];
            }
            else if (diff < arr[mid])
            {
                high = mid - 1;
            }
            else
            {
                lo = mid + 1;
            }

            return BinarySearch(arr, lo, high, diff);
        }
    }
}
