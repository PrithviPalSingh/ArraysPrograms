using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class MinDist2Numbers
    {
        public long minDist(long[] arr, long n, long x, long y)
        {
            // add code here.
            return SearchIndex(arr, x, y);            
        }

        private long SearchIndex(long[] arr, long x, long y)
        {
            var indexX = -1;
            var indexY = -1;
            var indexDiff = long.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    indexX = i;
                }

                if (arr[i] == y)
                {
                    indexY = i;
                }

                if (indexX != -1 && indexY != -1)
                {
                    indexDiff = Math.Min(indexDiff, Math.Abs(indexX - indexY));
                }
            }

            return indexDiff == long.MaxValue ? -1 : indexDiff;

        }

        private long BinarySearch(long[] arr, long x, long min, long max)
        {
            if (min < 0 || max > arr.Length - 1)
                return -1;

            long mid = (min + max) / 2;

            if (arr[mid] == x)
                return mid;
            else if (arr[mid] < x)
                min = mid + 1;
            else
                max = mid - 1;

            return BinarySearch(arr, x, min, max);
        }
    }
}
