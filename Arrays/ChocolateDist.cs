using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class ChocolateDist
    {
        public long GetChocDiff(long[] arr, int s)
        {

            long diff = long.MaxValue;
            Array.Sort(arr);
            for (int i = 0; i < arr.Length - s + 1; i++)
            {
                var interimdiff = arr[i + s - 1] - arr[i];
                if (interimdiff < diff)
                    diff = interimdiff;
            }

            return diff;
        }
    }
}
