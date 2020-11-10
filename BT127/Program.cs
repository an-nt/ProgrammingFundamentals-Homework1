using System;
using System.Collections;

namespace BT127
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testcase = new int[] { -2, -1, 0, 1, 2, 4, 6, 5, 3, 2, 0, 8 };
            SortArray(ref testcase);
            
            for (int i = 0; i < testcase.Length; i++)
            {
                Console.WriteLine(testcase[i]);
            }
        }
        static void SortArray(ref int[] Arr)
        {
            if (Arr.Length < 2)
            {
                return;
            }

            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = i+1; j < Arr.Length; j++)
                {
                    if (Arr[i] > Arr[j])
                    {
                        int temp = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = temp;
                    }
                }
            }
        }
    }
}
