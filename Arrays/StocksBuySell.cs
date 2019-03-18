using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class StocksBuySell
    {
        public static void fnStockBuySell(int[] arr, int n)
        {
            int[] minArray = new int[n];
            minArray[0] = arr[0];

            for (int i = 1; i < n; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    minArray[i] = arr[i];
                }
                else
                {
                    minArray[i] = Math.Min(arr[i], minArray[i - 1]);
                }
            }

            StringBuilder sb = new StringBuilder();
            int count = 0;
            int startIndex = -1;
            int endIndex = -1;
            for (int i = 1; i < n; i++)
            {
                if (minArray[i] == minArray[i - 1])
                {
                    count++;
                    if (startIndex == -1)
                        startIndex = i - 1;


                    endIndex = i;

                }
                else
                {
                    if (startIndex != -1)
                        sb.Append("(" + startIndex + " " + endIndex + ") ");

                    count = 0;
                    startIndex = -1;
                    endIndex = -1;
                }
            }

            if (startIndex != -1)
                sb.Append("(" + startIndex + " " + endIndex + ") ");

            if (sb.Length == 0) {
                Console.WriteLine("No Profit");
            }
            else {
                Console.WriteLine(sb.ToString());
            }
        }
    }
}
