using System;
using System.Collections.Generic;
using System.Text;

namespace Struct
{
    public struct DiemToaDo
    {
        public int X;
        public int Y;
    }
    class XL_Diem
    {
        public static DiemToaDo NhapDiem()
        {
            DiemToaDo diem = new DiemToaDo { X = 0, Y = 0 };
            bool KtraX = false;
            bool KtraY = false;

            while (!KtraX)
            {
                Console.WriteLine("Nhap toa do X");
                KtraX = int.TryParse(Console.ReadLine(), out diem.X);
            }

            while (!KtraY)
            {
                Console.WriteLine("Nhap toa do Y");
                KtraY = int.TryParse(Console.ReadLine(), out diem.Y);
            }
            return diem;
        }
        public static double TinhKhoangCach2Diem(DiemToaDo a, DiemToaDo b)
        {
            return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
        }
    }
}
