using System;

namespace BT323
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] testcase = new int[,]
            {
                {1,2,-3 },
                {4,-5,-6 },
                {7,8,-9 },
            };
            Console.WriteLine(GetProductOfColumnInMatrix(testcase,2));
        }
        static int GetProductOfColumnInMatrix(int[,] M, int k)
        {
            if (k < 0 || M.GetLength(1) <= k )
            {
                return 0;
            }
            int product = 1;
            for (int i = 0; i < M.GetLength(0); i++)
            {
                if (M[i,k] > 0)
                {
                    product *= M[i, k];
                }
            }
            return product;
        }
    }
}
