using System;

namespace BT56
{
    class Program
    {
        static void Main(string[] args)
        {
        ReDebug:
            //Khai bao tham so
            int N;
            int i;
            bool flag = false;
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
            for (i = N; i > 0; i /= 10)
            {
                if ((i%10)%2 == 0)
                {
                    Console.WriteLine($"{N} co chu so chan");
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                Console.WriteLine($"{N} chi bao gom cac chu so le");
            }

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
