using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class MaxSumPath
    {
        public int maxPathSum1(int[] ar1, int[] ar2)
        {
            int n = ar1.Length;
            int m = ar2.Length;
            int sum = 0;

            int[] newArr = n > m ? new int[n] : new int[m];
            int maxIndex = newArr.Length - 1;

            // Choose the first and last index
            bool startIndexA1 = false;
            bool startIndexA2 = false;
            bool endIndexA1 = false;
            bool endIndexA2 = false;

            if (n > m)
            {
                startIndexA2 = true;
                endIndexA1 = true;
            }
            else if (m > n)
            {
                startIndexA1 = true;
                endIndexA2 = true;
            }
            else
            {
                // if A1[0] > A1[n]
                if (ar1[0] > ar1[n - 1])
                    startIndexA1 = true;
                else
                    startIndexA2 = true;

                // if A1[0] < A2[0]
                if (startIndexA1 && ar1[0] < ar2[0])
                {
                    startIndexA1 = false;
                    startIndexA2 = true;
                }

                // if A2[0] < A1[0]
                if (startIndexA2 && ar2[0] < ar1[0])
                {
                    startIndexA1 = true;
                    startIndexA2 = false;
                }

                if (startIndexA1)
                    endIndexA2 = true;
                else
                    endIndexA1 = true;
            }

            if (startIndexA1)
                sum += ar1[0];
            else
                sum += ar2[0];

            for (int i = 1; i < maxIndex; i++)
            {
                if (i > m - 1)
                {
                    sum += ar1[i];
                }
                else if (i > n - 1)
                {
                    sum += ar2[i];
                }
                else
                {

                    if (ar1[i] > ar2[i])
                        sum += ar1[i];
                    else
                        sum += ar2[i];
                }
            }

            if (endIndexA1)
                sum += ar1[n - 1];
            else
                sum += ar2[m - 1];

            return sum;
        }

        public int maxPathSum(int[] ar1, int[] ar2)
        {
            int i = 0;
            int j = 0;

            int n = ar1.Length;
            int m = ar2.Length;
            int sum1 = 0;
            int sum2 = 0;
            int result = 0;
            while (i < n && j < m)
            {
                if (ar1[i] < ar2[j])
                {
                    sum1 += ar1[i++];
                }
                else if (ar1[i] > ar2[j])
                {
                    sum2 += ar2[j++];
                }
                else
                {
                    result += Math.Max(sum1, sum2);
                    sum1 = 0;
                    sum2 = 0;
                    while (i < n && j < m && ar1[i] == ar2[j])
                    {
                        result += ar1[i++];
                        j++;
                    }
                }
            }

            while (i < n)
            {
                sum1 += ar1[i++];
            }

            while (j < m)
            {
                sum2 += ar2[j++];
            }

            result += Math.Max(sum1, sum2);

            return result;
        }
    }
}
