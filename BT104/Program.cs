using System;
using System.ComponentModel.DataAnnotations;

namespace BT104
{
    class Program
    {
        static void Main(string[] args)
        {
        ReDebug:
            //Khai bao tham so
            int d, m, y;
            int max = 0;
            int S = 0;
            string back;

            //Nhap va kiem tra thong so dau vao
        ReInput1:
            Console.WriteLine("Nhap nam");
            var checky = int.TryParse(Console.ReadLine(), out y);

            if (!checky || y < 0)
            {
                Console.WriteLine("Khong hop le, vui long nhap lai nam");
                goto ReInput1;
            }

        ReInput2:
            Console.WriteLine("Nhap thang");
            var checkm = int.TryParse(Console.ReadLine(), out m);
            if (!checkm || m > 12 || m < 1)
            {
                Console.WriteLine("Khong hop le, vui long nhap lai thang");
                goto ReInput2;
            }

            if (m==1||m==3||m==5||m==7||m==8||m==10||m==12)
            {
                max = 31;
            }
            if (m==4||m==6||m==9||m==11)
            {
                max = 30;
            }
            if (m==2)
            {
                if (y%400 ==0 || (y%4 == 0 && y%100 != 0))
                {
                    max = 29;
                } else
                {
                    max = 28;
                }
            }

            ReInput3:
            Console.WriteLine("Nhap ngay");
            var checkd = int.TryParse(Console.ReadLine(), out d);
            if (!checkd || d > max || d < 1)
            {
                Console.WriteLine("Khong hop le, vui long nhap lai ngay");
                goto ReInput3;
            }

            //Tinh toan theo yeu cau de bai
            for (int i = 1; i < m; i++)
            {
                if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
                {
                    S += 31;
                }
                if (i == 4 || i == 6 || i == 9 || i == 11)
                {
                    S += 30;
                }
                if (i == 2)
                {
                    if (y % 400 == 0 || (y % 4 == 0 && y % 100 != 0))
                    {
                        S += 29;
                    }
                    else
                    {
                        S += 28;
                    }
                }
            }
            S += d;
            Console.WriteLine($"Ngay {d} thang {m} nam {y} la ngay thu {S} trong nam {y}");


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
