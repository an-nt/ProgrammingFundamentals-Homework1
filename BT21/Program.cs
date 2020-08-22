using System;

namespace BT21
{
    class Program
    {
        static void Main(string[] args)
        {
        ReDebug:
            //Khai bao tham so
            int N;
            int i = 1;
            int S = 0;
            string back;

        ReInput:
            //Nhap va kiem tra thong so dau vao
            Console.WriteLine("Nhap N");
            var check = int.TryParse(Console.ReadLine(), out N);
            if (!check || N < 1)
            {
                Console.WriteLine("Vui long nhap lai N");
                goto ReInput;
            }

            //Tinh toan theo yeu cau de bai
            while (i <= N)
            {
                if (N % i == 0)
                {
                    S += i;
                }
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
