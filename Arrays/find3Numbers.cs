using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class find3Numbers
    {
        public static List<int> find3Numbersfunc(int[] a, int n)
        {
            List<int> list = new List<int>();
            bool gotit = false;
            for (int i = 0; i < a.Length; i++)
            {                
                for (int j = i; j < a.Length; j++)
                {
                    for (int k = j; k < a.Length; k++)
                    {
                        if (a[i] < a[j] && a[j] < a[k])
                        {
                            list.Add(a[i]);
                            list.Add(a[j]);
                            list.Add(a[k]);
                            gotit = true;
                            break;
                        }
                    }

                    if (gotit)
                        break;
                }

                if (gotit)
                    break;
            }

            return list;
        }

        public static List<int> find3NumbersOpt(int[] arr, int n)
        {
            List<int> list = new List<int>();
            int max = n - 1;
            int min = 0;
            int i;
            int[] smaller = new int[n];

            smaller[0] = -1;
            for (i = 1; i < n; i++)
            {
                if (arr[i] <= arr[min])
                {
                    min = i;
                    smaller[i] = -1;
                }
                else
                    smaller[i] = min;
            }

            int[] greater = new int[n];

            greater[n - 1] = -1;
            for (i = n - 2; i >= 0; i--)
            {
                if (arr[i] >= arr[max])
                {
                    max = i;
                    greater[i] = -1;
                }
                else
                    greater[i] = max;
            }

            for (i = 0; i < n; i++)
            {
                if (smaller[i] != -1 && greater[i] != -1)
                {
                    list.Add(arr[smaller[i]]);
                    list.Add(arr[i]);
                    list.Add(arr[greater[i]]);
                    break;
                }
            }

            return list;
        }
    }
}
