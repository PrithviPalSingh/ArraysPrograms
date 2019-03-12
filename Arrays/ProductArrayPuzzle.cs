using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class ProductArrayPuzzle
    {
        public long[] ProductArray(int[] arr)
        {
            int n = arr.Length;
            long[] newArr = new long[n];
            long mul = 1;

            for (int i = 0; i < n; i++)
            {
                mul *= arr[i];
            }

            for (int i = 0; i < n; i++)
            {
                newArr[i] = mul / arr[i];
            }

            return newArr;
        }
    }
}
