using System;

namespace BT125
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testcase = new int[] { 1,2,3,4,5,6,7,8,9,10};
            Console.WriteLine(GetNumOfPrimeLessThan100(testcase));
        }
        static int GetNumOfPrimeLessThan100(int[] Arr)
        {
            if (Arr.Length == 0)
            {
                return 0;
            }
            int result = 0;
            for(int i = 0; i < Arr.Length; i++)
            {
                if (IsPrimeNumber(Arr[i]) && Arr[i] < 100)
                {
                    result++;
                }
            }
            return result;
        }
        static bool IsPrimeNumber(int N)
        {
            if (N < 2)
            {
                return false;
            }
            if (N == 2)
            {
                return true;
            }
            for (int i = 2; i*i <= N; i++)
            {
                if (N%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
