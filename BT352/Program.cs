using System;

namespace BT352
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] testcase = new int[,]
            {
                {0,1,1},
                {1,1,1 },
                {1,0,1 },
            };
            Console.WriteLine(IsRowIncrease(testcase,2));
        }
        static bool IsRowIncrease(int[,] M, int k)
        {
            if (M.GetLength(0) >= k || M.GetLength(1) < 2 || k<0)
            {
                return true;
            }
            for (int j = 0; j < M.GetLength(1)-1; j++)
            {
                if (M[k,j] > M[k, j + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
