using System;

namespace BT348
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] testcase = new int[,]
            {
                {0,1,1},
                {1,1,1 },
                {1,1,1 },
            };
            Console.WriteLine(ExistPositiveNumInMatrix(testcase));
        }
        static bool ExistPositiveNumInMatrix(int[,] M)
        {
            if (M.GetLength(0) == 0 || M.GetLength(1) == 1)
            {
                return false;
            }
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    if (M[i,j] > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
