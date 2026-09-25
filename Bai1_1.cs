using System;

namespace THUCHANH02
{
    public class Bai1_1
    {
        // Thuộc tính lưu trữ họ tên và năm sinh[cite: 18]
        public string HoTen { get; set; }
        public int NamSinh { get; set; }

        public void Nhap()
        {
            Console.Write("Nhap ho ten sinh vien: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
        }

        // Phương thức tính tuổi dựa trên năm hiện hành[cite: 18]
        public int TinhTuoi()
        {
            return DateTime.Now.Year - NamSinh;
        }

        public void Xuat()
        {
            Console.WriteLine($"Sinh vien {HoTen}, sinh nam {NamSinh}, hien tai {TinhTuoi()} tuoi.");
        }

        
        public static void Main(string[] args)
        {
            Bai1_1 sv = new Bai1_1();
            sv.Nhap();
            sv.Xuat();
            Console.ReadLine();
        }
    }
}