using System;

namespace BT123
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testcase = new int[] { 1, 2, 3, 4, 5, -1, 4 };

            Console.WriteLine(FindIndexOfMinElement(testcase));
        }
        static int FindIndexOfMinElement(int[] Arr)
        {
            if (Arr.Length == 0)
            {
                return -1;
            }
            int min = Arr[0];
            int index = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (min > Arr[i])
                {
                    min = Arr[i];
                    index = i;
                }
            }
            return index;
        }
    }
}
