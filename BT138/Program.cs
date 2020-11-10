using System;

namespace BT138
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testcase = new int[] { -1, -3, -5, 0, 1, 2, 4 };
            Console.WriteLine(FindIndexOfFirstEvenElement(testcase));
        }
        static int FindIndexOfFirstEvenElement(int[] Arr)
        {
            if (Arr.Length == 0)
            {
                return -1;
            }
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i]%2 == 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
