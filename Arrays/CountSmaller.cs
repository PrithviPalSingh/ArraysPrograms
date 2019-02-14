using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class CountSmaller
    {
        public static string getCount(long[] arr)
        {
            var retString = string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {                
                long count = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                        count++;
                }

                retString += count + " ";
            }

            return retString;
        }
    }
}
