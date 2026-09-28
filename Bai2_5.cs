using System;
using System.Collections.Generic;

namespace THUCHANH02
{
    // Lớp nội bộ đại diện cho 1 nhân viên
    public class NhanVien
    {
        public string HoTen { get; set; }
        public double MucLuong { get; set; }
        public int SoNgayVang { get; set; }

        public NhanVien(string ten, double luong, int vang)
        {
            HoTen = ten; MucLuong = luong; SoNgayVang = vang;
        }

        
        public double TinhLuongThucNhan()
        {
            return MucLuong - (SoNgayVang * 100000);
        }
    }

    public class Bai2_5
    {
        private List<NhanVien> danhSachNhanVien;

        public Bai2_5()
        {
            danhSachNhanVien = new List<NhanVien>();
        }

        public void Nhap()
        {
            Console.Write("Nhap so luong nhan vien: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"--- Thong tin nhan vien thu {i + 1} ---");
                Console.Write("Ho ten: "); string ten = Console.ReadLine();
                Console.Write("Muc luong co ban: "); double luong = double.Parse(Console.ReadLine());
                Console.Write("So ngay vang: "); int vang = int.Parse(Console.ReadLine());
                danhSachNhanVien.Add(new NhanVien(ten, luong, vang));
            }
        }


        public void InBangLuongChiTiet()
        {
            Console.WriteLine("\n================ BANG CHI TIET LUONG ================");
            double tongTienPhongBan = 0;

            for (int i = 0; i < danhSachNhanVien.Count; i++)
            {
                NhanVien nv = danhSachNhanVien[i];
                double luongNhanVien = nv.TinhLuongThucNhan();

               
                tongTienPhongBan += luongNhanVien;

                
                Console.WriteLine($"* Nhan vien {i + 1}: {nv.HoTen}");
                Console.WriteLine($"  - Luong co ban: {nv.MucLuong:N0} VND");
                Console.WriteLine($"  - Phat vang mat: {nv.SoNgayVang} ngay x 100,000 = {(nv.SoNgayVang * 100000):N0} VND");
                Console.WriteLine($"  => Thuc nhan: {luongNhanVien:N0} VND");
                Console.WriteLine("-----------------------------------------------------");
            }

            Console.WriteLine($"Tong luong ca phong ban: {tongTienPhongBan:N0} VND");
        }

        public static void Main(string[] args)
        {
            Bai2_5 phongBan = new Bai2_5();
            phongBan.Nhap();
            phongBan.InBangLuongChiTiet();

            Console.ReadLine();
        }
    }
}