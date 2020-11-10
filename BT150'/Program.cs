using System;

namespace BT150_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testcase = new int[] { 1, 2, 3};
            Console.WriteLine(FindLargestMinusNumber(testcase));
        }
        static int FindLargestMinusNumber(int[] Arr)
        {
            int maxindex = -1;
            if (Arr.Length == 0)
            {
                return maxindex;
            }

            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i]< 0)
                {
                    maxindex = i;
                    break;
                }
            }
            if (maxindex >= 0)
            {
                for (int i = maxindex; i < Arr.Length; i++)
                {
                    if (Arr[i] > Arr[maxindex])
                    {
                        maxindex = i;
                    }
                }
            }
            return maxindex;
        }
    }
}
