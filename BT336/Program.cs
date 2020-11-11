using System;

namespace BT336
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
            Console.WriteLine(GetNumOfXInMatrix(testcase, 4));
        }
        static int GetNumOfXInMatrix(int[,] M, int x)
        {
            int count = 0;
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0;  j < M.GetLength(1); j++)
                {
                    if (M[i,j] == x)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
