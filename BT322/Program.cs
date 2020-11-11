using System;

namespace BT322
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
            Console.WriteLine(GetSumOfRowInMatrix(testcase,1));
        }
        static int GetSumOfRowInMatrix(int[,] M, int k)
        {
            if (M.GetLength(0) <= k || k < 0)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 0; i < M.GetLength(1); i++)
            {
                sum += M[k, i];
            }
            return sum;
        }
    }
}
