using System;

namespace BT341
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] testcase = new int[,]
            {
                {-1,-2,-3 },
                {4,-5,6 },
                {7,8,-9 },
            };
            Console.WriteLine(GetNumOfPositiveOnBorderOfMatrix(testcase));
        }
        static int GetNumOfPositiveOnBorderOfMatrix(int[,] M)
        {
            int count = 0;
            if (M.GetLength(0) == 0 || M.GetLength(1) == 0)
            {
                return count;
            }

            for (int i = 0; i < M.GetLength(0); i++)
            {
                if (i == 0 || i == M.GetLength(0) - 1)
                {
                    for (int j = 0; j < M.GetLength(1); j++)
                    {
                        if (M[i,j] > 0)
                        {
                            count++;
                        }
                    }
                } else
                {
                    if (M[i,0] > 0)
                    {
                        count++;
                    }
                    if (M[i, M.GetLength(1) - 1] > 0)
                    {
                        count++;
                    }
                } 
            }
            return count;
        }
    }
}
