using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region -rotation
            //string[] nd = Console.ReadLine().Split(' ');

            //int n = Convert.ToInt32(nd[0]);

            //int d = Convert.ToInt32(nd[1]);

            //int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            //LeftRotate(a, d);
            #endregion

            #region - array manipulation
            //ArrayManipulation();
            #endregion

            #region - Dynamic array
            //string[] tokens_n = Console.ReadLine().Split(' ');
            //long seqlistcount = Convert.ToInt64(tokens_n[0]);
            //long queryCount = Convert.ToInt64(tokens_n[1]);
            //var seqList = new string[seqlistcount];

            //long lastAnswer = 0;
            //for (int i = 0; i < queryCount; i++)
            //{
            //    string[] queryValues = Console.ReadLine().Split(' ');
            //    long seqIndex = Convert.ToInt64(queryValues[0]);
            //    long x = Convert.ToInt64(queryValues[1]);
            //    long y = Convert.ToInt64(queryValues[2]);

            //    if (1 == seqIndex)
            //    {
            //        var index = ((x ^ lastAnswer) % seqlistcount);
            //        if (string.IsNullOrWhiteSpace(seqList[index]))
            //        {
            //            seqList[index] = y.ToString();
            //        }
            //        else
            //        {
            //            seqList[index] = seqList[index] + "," + y;
            //        }
            //    }
            //    else if (2 == seqIndex)
            //    {
            //        var index = ((x ^ lastAnswer) % seqlistcount);

            //        var z = seqList[index].Split(',');
            //        var t = y % z.Length;
            //        lastAnswer = Convert.ToInt64(z[t]);
            //        Console.WriteLine(lastAnswer);
            //    }

            //}
            #endregion

            //MinDist2Numbers minmaxdist = new MinDist2Numbers();
            //Console.WriteLine(minmaxdist.minDist(new long[] { 86, 39, 90, 67, 84, 66, 62 },
            //     7, 86, 84));

            OperatingAnArray opa = new OperatingAnArray();
            var a = new int[] { 2, 4, 1, 0, 6 };
            opa.insertEle(a, 2, 2);
            
            Console.WriteLine(a[2]);


            Console.Read();
        }

        /*
         * Given a range[, ] and a value  we need to add  to all the numbers whose indices are in the range from [, ]. 
         * We can do an O() update by adding  to index  and add  to index . Doing this kind of update, the number in the array 
         * will be prefix sum of array from index 1 to i because we are adding  to the value at index and subtracting  from the value 
         * at index  and taking prefix sum will give us the actual value for each index after  operations .
         * So, we can do all  updates in O(m) time. Now we have to check the largest number in the original array. 
         * i.e. the index i such that prefix sum attains the maximum value.
         * We can calculate all prefix sums as well as maximum prefix sum in O(n) time which will execute in time.
         */
        public static void ArrayManipulation()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            long n = Convert.ToInt32(tokens_n[0]);
            long m = Convert.ToInt32(tokens_n[1]);
            long[] finalArray = new long[n];
            for (long a0 = 0; a0 < m; a0++)
            {
                string[] tokens_a = Console.ReadLine().Split(' ');
                var a = Convert.ToInt64(tokens_a[0]) - 1;
                var b = Convert.ToInt64(tokens_a[1]);
                var c = Convert.ToInt64(tokens_a[2]);

                finalArray[a] = finalArray[a] + c;

                if (b < n)
                {
                    finalArray[b] = finalArray[b] - c;
                }
            }

            long tempMax = 0;
            long max = 0;
            for (int i = 0; i < n; i++)
            {
                tempMax += finalArray[i];
                if (tempMax > max) max = tempMax;
            }
            Console.WriteLine(max);
        }


        public static void LeftRotate(int[] arr, int rotation)
        {
            int[] arr1 = new int[arr.Length];
            int num = rotation % arr.Length;
            //int diff = arr.Length - num;
            for (int i = 0; i < arr1.Length; i++)
            {
                int j = num + i;
                if (j >= arr.Length)
                {
                    j = j - arr.Length;
                }
                arr1[i] = arr[j];
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
        }
    }
}
