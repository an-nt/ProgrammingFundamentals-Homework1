using System;

namespace BT150
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testcase = new int[] { 1, 2, 3};
            Console.WriteLine(FindTheLargestMinusNumber(testcase));
        }
        static int FindTheLargestMinusNumber(int[] Arr)
        {
            if (Arr.Length == 0)
            {
                return -1; 
            }
            bool containMinusNumber = false;

            int max = 0;
            int index = -1;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] < 0 && containMinusNumber == false)
                {
                    containMinusNumber = true;
                    max = Arr[i];
                    index = i;
                }
                if (Arr[i]<0 && containMinusNumber == true)
                {
                    if (Arr[i] > max)
                    {
                        max = Arr[i];
                        index = i;
                    }
                }
            }

            if (containMinusNumber == false)
            {
                return -1;
            } else
            {
                return index;
            }
        }
    }
}
