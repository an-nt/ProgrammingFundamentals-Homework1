using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoDaGiac();
        }
        static void DemoPhanSo()
        {
            PhanSo a = XL_PhanSo.NhapPhanSo();
            PhanSo b = XL_PhanSo.NhapPhanSo();

            PhanSo kq = XL_PhanSo.TinhTongPhanSo(a, b);
            XL_PhanSo.InPhanSo(kq);
        }
        static void DemoDiemToaDo()
        {
            DiemToaDo a = XL_Diem.NhapDiem();
            DiemToaDo b = XL_Diem.NhapDiem();
            Console.WriteLine($"Khoang cach 2 diem la {XL_Diem.TinhKhoangCach2Diem(a, b)}");
        }
        static void DemoDaGiac()
        {
            DaGiac daGiac = XL_DaGiac.NhapDaGiac();
            Console.WriteLine($"Chu vi da giac la {XL_DaGiac.TinhChuViDaGiac(daGiac)}");
        }
    }
}
