using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Leaders
    {
        public static void LeadersInAnArray(long[] arr)
        {
            long max_from_right = arr[arr.Length - 1];
            List<long> list = new List<long>();
            list.Add(max_from_right);
            for (long i = arr.Length - 2; i >= 0; i--)
            {
                if (arr[i] >= max_from_right)
                {
                    max_from_right = arr[i];
                    list.Add(max_from_right);
                }
            }
            list.Reverse();
            StringBuilder sb = new StringBuilder();
            foreach (var item in list)
            {
                sb.Append(item + " ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
