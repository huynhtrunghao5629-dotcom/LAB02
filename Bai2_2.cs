using System;
using System.Collections.Generic;

namespace THUCHANH02
{
    public class Bai2_2
    {
        private List<Bai1_3> danhSachNguoi;

        public Bai2_2()
        {
            danhSachNguoi = new List<Bai1_3>();
        }

        public Bai2_2(Bai2_2 danhSachKhac)
        {
            danhSachNguoi = new List<Bai1_3>();
            foreach (var nguoi in danhSachKhac.danhSachNguoi)
            {
                danhSachNguoi.Add(new Bai1_3(nguoi));
            }
        }

        public void Them(Bai1_3 nguoiMoi)
        {
            danhSachNguoi.Add(nguoiMoi);
        }

        public void Nhap()
        {
            Console.Write("Nhap so luong nguoi can quan ly: ");
            int soLuong = int.Parse(Console.ReadLine());
            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine($"--- Nhap thong tin nguoi thu {i + 1} ---");
                Bai1_3 nguoi = new Bai1_3();
                // Đã sửa lại thành hàm Nhap()
                nguoi.Nhap();
                Them(nguoi);
            }
        }

        public void Xuat()
        {
            foreach (var nguoi in danhSachNguoi) nguoi.Xuat();
        }

        public Bai2_2 LayDanhSachConSong()
        {
            Bai2_2 ketQua = new Bai2_2();
            foreach (var nguoi in danhSachNguoi)
            {
          
                if (nguoi.ConSong()) ketQua.Them(nguoi);
            }
            return ketQua;
        }

        public static void Main(string[] args)
        {
            Bai2_2 danhSach = new Bai2_2();
            danhSach.Nhap();

            Console.WriteLine("\n--- DANH SACH TAT CA ---");
            danhSach.Xuat();

            Console.WriteLine("\n--- DANH SACH NHUNG NGUOI CON SONG ---");
            Bai2_2 dsConSong = danhSach.LayDanhSachConSong();
            dsConSong.Xuat();
            Console.ReadLine();
        }
    }
}