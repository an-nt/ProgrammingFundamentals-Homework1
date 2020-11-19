using System;
using System.Collections.Generic;
using System.Text;

namespace Struct
{
    public struct DaGiac
    {
        public int SoDinh;
        public DiemToaDo[] ToaDoCacDinh;
    }
    class XL_DaGiac
    {
        public static DaGiac NhapDaGiac()
        {
            DaGiac dagiac = new DaGiac { SoDinh = 0 };
            bool KtraSoDinh = false;

            while (!KtraSoDinh || dagiac.SoDinh < 3)
            {
                Console.WriteLine("Nhap so dinh cua da giac");
                KtraSoDinh = int.TryParse(Console.ReadLine(), out dagiac.SoDinh);
            }

            dagiac.ToaDoCacDinh = new DiemToaDo[dagiac.SoDinh];
            for (int i = 0; i < dagiac.ToaDoCacDinh.Length; i++)
            {
                dagiac.ToaDoCacDinh[i] = XL_Diem.NhapDiem();
            }

            return dagiac;
        }
        public static double TinhChuViDaGiac(DaGiac daGiac)
        {
            double ChuVi = 0;
            if (daGiac.ToaDoCacDinh.Length < 3)
            {
                Console.WriteLine("Da giac khong hop le");
                return ChuVi;
            }
            for (int i = 0; i < daGiac.ToaDoCacDinh.Length -1; i++)
            {
                ChuVi += XL_Diem.TinhKhoangCach2Diem(daGiac.ToaDoCacDinh[i], daGiac.ToaDoCacDinh[i + 1]);
            }
            ChuVi += XL_Diem.TinhKhoangCach2Diem(daGiac.ToaDoCacDinh[0], daGiac.ToaDoCacDinh[daGiac.ToaDoCacDinh.Length-1]);
            return ChuVi;
        }
    }
}
