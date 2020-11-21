using System;

namespace BT59
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so N");
            int N = int.Parse(Console.ReadLine());
            int n = 0;
            for (int i = N; i > 0; i /= 10)
            {
                int ChuSo;
                ChuSo = i % 10;
                n = 10 * n + ChuSo;
            }
            if (N - n == 0)
            {
                Console.WriteLine($"{N} la so doi xung");
                return;
            }
            Console.WriteLine($"{N} KHONG la so doi xung");
        }
    }
}
