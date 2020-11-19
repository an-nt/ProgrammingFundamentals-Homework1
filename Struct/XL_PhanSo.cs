using System;
using System.Collections.Generic;
using System.Text;

namespace Struct
{
    public struct PhanSo
    {
        public int TuSo;
        public int MauSo;
    }
    class XL_PhanSo
    {
        public static PhanSo NhapPhanSo()
        {
            PhanSo phanso = new PhanSo { TuSo=0,MauSo=0};
            bool KTTuSo = false;
            bool KTMauSo = false;

            while (!KTTuSo)
            {
                Console.WriteLine("Nhap tu so");
                KTTuSo = int.TryParse(Console.ReadLine(), out phanso.TuSo);
            }

            while (!KTMauSo || phanso.MauSo == 0)
            {
                Console.WriteLine("Nhap mau so");
                KTMauSo = int.TryParse(Console.ReadLine(), out phanso.MauSo);
            }
            return phanso;
        }
        public static PhanSo TinhTongPhanSo(PhanSo a, PhanSo b)
        {
            PhanSo tong;
            tong.MauSo = a.MauSo * b.MauSo;
            tong.TuSo = a.TuSo * b.MauSo + a.MauSo * b.TuSo;
            return tong;
        }
        public static void InPhanSo(PhanSo phanso)
        {
            Console.WriteLine($"Phan so {phanso.TuSo}/{phanso.MauSo}");
        }
    }
}
