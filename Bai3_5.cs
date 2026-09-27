using System;
using System.Collections.Generic;

namespace THUCHANH02
{
    // LỚP CHA
    public class NhanVienCongTy
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }

        public NhanVienCongTy() { } // Constructor rỗng để dễ tạo đối tượng

        // Hàm ảo cho phép lớp con gọi lại và viết thêm
        public virtual void Nhap()
        {
            Console.Write("Nhap Ma NV: "); MaNV = Console.ReadLine();
            Console.Write("Nhap Ho ten: "); HoTen = Console.ReadLine();
        }

        public virtual double TinhLuong() { return 0; }

        public virtual void XuatThongTin()
        {
            Console.WriteLine($"[{MaNV}] - {HoTen} | Luong: {TinhLuong():N0} VND");
        }
    }

    // LỚP CON 1: KINH DOANH
    public class NhanVienKinhDoanh : NhanVienCongTy
    {
        public double LuongCoBan { get; set; }
        public int SoHopDong { get; set; }

        public NhanVienKinhDoanh() { }

        public override void Nhap()
        {
            base.Nhap(); // Gọi lại hàm Nhap của lớp Cha (để nhập Mã NV, Họ tên)
            Console.Write("Nhap Luong co ban: "); LuongCoBan = double.Parse(Console.ReadLine());
            Console.Write("Nhap So hop dong ky duoc: "); SoHopDong = int.Parse(Console.ReadLine());
        }

        public override double TinhLuong() => LuongCoBan + (SoHopDong * 500000);
    }

    // LỚP CON 2: SẢN XUẤT
    public class NhanVienSanXuat : NhanVienCongTy
    {
        public int SoSanPham { get; set; }

        public NhanVienSanXuat() { }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap So san pham lam duoc: "); SoSanPham = int.Parse(Console.ReadLine());
        }

        public override double TinhLuong()
        {
            double luong = SoSanPham * 1000;
            if (SoSanPham > 3000) luong = luong + (luong * 0.05);
            return luong;
        }
    }

    public class Bai3_5
    {
        public static void Main(string[] args)
        {
            List<NhanVienCongTy> danhSach = new List<NhanVienCongTy>();

            Console.Write("Nhap so nhan vien muon nhap:  ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Nhap nhan vien thu {i + 1} ---");
                Console.WriteLine("Chon loai: 1. Kinh doanh | 2. San xuat");
                Console.Write("=> Ban chon: ");
                int loai = int.Parse(Console.ReadLine());

                NhanVienCongTy nv;
                if (loai == 1) nv = new NhanVienKinhDoanh();
                else nv = new NhanVienSanXuat();

                nv.Nhap(); 
                danhSach.Add(nv);
            }

            Console.WriteLine("\n=== BANG LUONG CONG TY ===");
            foreach (var nv in danhSach)
            {
                nv.XuatThongTin();
            }
            Console.ReadLine();
        }
    }
}