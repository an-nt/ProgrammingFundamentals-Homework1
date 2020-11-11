using System;

namespace BT315
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] testcase = new int[,]
            {
                {1,2,3 },
                {-1,-2,-3 },
            };

            Console.WriteLine(GetMaxInMatrix(testcase));
        }
        static int GetMaxInMatrix(int[,] M)
        {
            if (M.GetLength(0) == 0 || M.GetLength(1) == 0)
            {
                return 0;
            }

            int max = M[0, 0];
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    if (M[i,j] > max)
                    {
                        max = M[i, j];
                    }
                }
            }
            return max;
        }
    }
}
