using System;

namespace BT12
{
    class Program
    {
        static void Main(string[] args)
        {
        ReDebug:
            //Khai bao tham so
            int N;
            double x;
            double T = 1;
            double S = 0;
            int i = 1;
            string back;

        ReInput:
            //Nhap va kiem tra thong so dau vao
            Console.WriteLine("Nhap x");
            var checkx = double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Nhap N");
            var checkN = int.TryParse(Console.ReadLine(), out N);

            if (!checkN || !checkx || N < 1)
            {
                Console.WriteLine("Vui long nhap lai");
                goto ReInput;
            }

            //Tinh toan theo yeu cau de bai
            while (i <= N)
            {
                T *= x;
                S += T;
                i++;
            }
            Console.WriteLine($"Ket qua S bang {S}");

            //Thuc hien lai chuong trinh
            Console.WriteLine("Nhap YES de thuc hien lai chuong trinh");
            back = Console.ReadLine();
            if (back == "yes")
            {
                goto ReDebug;
            }
        }
    }
}
