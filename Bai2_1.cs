using System;
using System.Collections;

namespace THUCHANH02
{
    public class Bai2_1
    {
        private ArrayList dsPoint;

        public Bai2_1()
        {
            dsPoint = new ArrayList();
        }

        public Bai1_2 this[int index]
        {
            get { return (Bai1_2)dsPoint[index]; }
            set { dsPoint[index] = value; }
        }

        public void ThemPoint(Bai1_2 p)
        {
            dsPoint.Add(p);
        }

        public void NhapDanhSach()
        {
            Console.Write("Ban muon nhap bao nhieu diem : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"--- Nhap toa do Diem thu {i + 1} ---");
                Bai1_2 p = new Bai1_2(); 
                p.Nhap();              
                ThemPoint(p);           
            }
        }

     
        public void XuatDanhSach()
        {
            Console.WriteLine("\n--- DANH SACH CAC DIEM VUA NHAP ---");
            for (int i = 0; i < dsPoint.Count; i++)
            {
                Console.WriteLine($"Diem thu {i + 1}: {this[i]}");
            }
        }

        public static void Main(string[] args)
        {
            Bai2_1 arrayPoint = new Bai2_1();

            arrayPoint.NhapDanhSach();
            arrayPoint.XuatDanhSach();

            Console.ReadLine();
        }
    }
}