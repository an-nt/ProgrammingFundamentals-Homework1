using System;

namespace BT337
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
            Console.WriteLine(DemSoChuSoTrongMaTran(testcase));
        }
        static int DemSoChuSoTrongMaTran(int[,] M)
        {
            int[] marker = new int[10];
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    DanhDauChuSo(ref marker, M[i, j]);
                }
            }
            int count = 0;
            for (int k = 0; k < 10; k++)
            {
                if (marker[k] > 0)
                {
                    count++;
                }
            }
            return count;
        }
        static void DanhDauChuSo(ref int[] marker, int N)
        {
            int ChuSo;
            if (N < 0)
            {
                return;
            }

            if (N == 0)
            {
                marker[0]++;
            }

            for (int i = N; i != 0; i /= 10 )
            {
                ChuSo = i - 10 * (i / 10);
                marker[ChuSo]++;
            }
        }
    }
}
