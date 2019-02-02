using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class OperatingAnArray
    {
        public bool searchEle(int[] a, int x)
        {
            int[] a1 = new int[a.Length];
            Array.Copy(a, a1, a.Length);
            Array.Sort(a1);
            var b = BinarySearch(a1, x, 0, a1.Length - 1);
            return b == -1 ? false : true;
        }

        public bool insertEle(int[] a, int y, int yi)
        {
            //add code here.
            if (yi < a.Length)
            {
                a[yi] = y;
                return true;
            }
            else
                return false;

        }

        public bool deleteEle(int[] a, int z)
        {
            //add code here.
            if (searchEle(a, z))
            {
                int pos = SearchIndex(a, z);
                for (int i = pos; i < a.Length - 1; i++)
                    a[i] = a[i + 1];
                return true;
            }

            return true;
        }

        private int SearchIndex(int[] arr, int x)
        {
            int indexX = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    indexX = i;
                    break;
                }
            }

            return indexX;

        }

        private int BinarySearch(int[] arr, int x, int min, int max)
        {
            if (min < 0 || max > arr.Length - 1 || min > max)
                return -1;

            int mid = (min + max) / 2;

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
