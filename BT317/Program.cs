using System;

namespace BT317
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] testcase = new int[,]
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 },
            };
            Console.WriteLine(GetNumOfPrimeNumInMatrix(testcase));
        }
        static int GetNumOfPrimeNumInMatrix(int[,] M)
        {
            int count = 0;
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    if (IsPrimeNumber(M[i, j]))
                    {
                        count++;
                    }
                }
            }
            return count;
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
