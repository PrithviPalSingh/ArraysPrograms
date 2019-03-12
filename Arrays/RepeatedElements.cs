using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class RepeatedElements
    {
        public static void printDuplicates1(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(arr[i]) < n)
                {
                    if (arr[Math.Abs(arr[i])] > 0)
                    {
                        arr[Math.Abs(arr[i])] = -arr[Math.Abs(arr[i])];
                    }
                    else
                    {
                        Console.Write(Math.Abs(arr[i]) + " ");
                    }
                }
            }
        }

        public static void printDuplicates(int[] arr, int n)
        {
            bool found = false;
            for (int i = 0; i < n; i++)
            {
                int index = arr[i] % n;
                if (arr[index] / n == 1)
                {
                    found = true;
                    Console.Write(index + " ");
                }
                arr[index] += n;
            }

            if (!found)
                Console.Write(-1);
        }
    }
}
