using System;
using System.Collections.Generic;

namespace THUCHANH02
{
    // LỚP CHA TRỪU TƯỢNG
    public abstract class ThiSinh
    {
        public string SBD { get; set; }
        public string HoTen { get; set; }
        public double Bai1 { get; set; }
        public double Bai2 { get; set; }
        public double Bai3 { get; set; }
        public double TongDiem { get; protected set; }

        public ThiSinh() { }

        public virtual void Nhap()
        {
            Console.Write("Nhap So bao danh: "); SBD = Console.ReadLine();
            Console.Write("Nhap Ho ten: "); HoTen = Console.ReadLine();
            Console.Write("Nhap diem Bai 1: "); Bai1 = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem Bai 2: "); Bai2 = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem Bai 3: "); Bai3 = double.Parse(Console.ReadLine());
        }

        public abstract void TinhTongDiem();

        public virtual void Xuat()
        {
            Console.Write($"[{SBD}] {HoTen} | B1: {Bai1}, B2: {Bai2}, B3: {Bai3} | TONG: {TongDiem}");
        }
    }

    // LỚP CON 1: THÍ SINH CHUYÊN
    public class ThiSinhChuyen : ThiSinh
    {
        public double TiengAnh { get; set; }

        public ThiSinhChuyen() { }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap diem Tieng Anh: "); TiengAnh = double.Parse(Console.ReadLine());
        }

        public override void TinhTongDiem()
        {
            TongDiem = Bai1 + Bai2 + Bai3;
            if (TiengAnh >= 7 && TiengAnh <= 8) TongDiem += 1;
            else if (TiengAnh >= 9 && TiengAnh <= 10) TongDiem += 2;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($" (He Chuyen - Anh: {TiengAnh})");
        }
    }

    // LỚP CON 2: THÍ SINH SIÊU CÚP
    public class ThiSinhSieuCup : ThiSinh
    {
        public double DiemCSDL { get; set; }

        public ThiSinhSieuCup() { }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap diem CSDL: "); DiemCSDL = double.Parse(Console.ReadLine());
        }

        public override void TinhTongDiem()
        {
            TongDiem = Bai1 + Bai2 + Bai3 + DiemCSDL;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($" (Sieu Cup - CSDL: {DiemCSDL})");
        }
    }

    public class Bai3_6
    {
        public static void Main(string[] args)
        {
            List<ThiSinh> danhSachThiSinh = new List<ThiSinh>();

            Console.Write("Co bao nhieu thi sinh tham gia? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Nhap thi sinh thu {i + 1} ---");
                Console.WriteLine("Chon he thi: 1. Chuyen | 2. Sieu cup");
                Console.Write("=> Ban chon: ");
                int heThi = int.Parse(Console.ReadLine());

                ThiSinh ts;
                if (heThi == 1) ts = new ThiSinhChuyen();
                else ts = new ThiSinhSieuCup();

                ts.Nhap();
                danhSachThiSinh.Add(ts);
            }

            Console.WriteLine("\n=== KET QUA CUOC THI TIN HOC ===");
            foreach (var ts in danhSachThiSinh)
            {
                ts.TinhTongDiem();
                ts.Xuat();
            }
            Console.ReadLine();
        }
    }
}