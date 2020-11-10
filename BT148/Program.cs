using System;

namespace BT148
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testcase = new int[] { 1,2,3,4,5,6,7,8,9,10 };
            Console.WriteLine(FindLastPrimeNumber(testcase));
        }
        static int FindLastPrimeNumber(int[] Arr)
        {
            for (int i = Arr.Length -1;i >= 0; i--)
            {
                if (IsPrimeNumber(Arr[i]))
                {
                    return Arr[i];
                }
            }
            return -1;
        }
        static bool IsPrimeNumber(int N)
        {
            if (N < 2)
            {
                return false;
            }

            int i = 2;
            while (i*i <= N)
            {
                if (N%i == 0)
                {
                    return false;
                }
                i++;
            }
            return true;
        }
    }
}
