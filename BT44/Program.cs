using System;

namespace BT44
{
    class Program
    {
        static void Main(string[] args)
        {
        ReDebug:
            //Khai bao tham so
            int N;
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
            for (; N > 0; N /= 10)
            {
                S += (N%10);
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
