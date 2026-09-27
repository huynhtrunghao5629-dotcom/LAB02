using System;

namespace THUCHANH02
{
    public delegate void SuKienChonMenu(int luaChon);

    public class ConsoleMenu
    {
        public event SuKienChonMenu KhiNguoiDungChon;

        public void HienThiVaChon()
        {
            while (true)
            {
                Console.WriteLine("\n===== MENU CHUC NANG =====");
                Console.WriteLine("1. Giai phuong trinh bac 2");
                Console.WriteLine("0. Thoat chuong trinh");
                Console.Write("Ban chon: ");
                int chon = int.Parse(Console.ReadLine());

                if (KhiNguoiDungChon != null)
                {
                    KhiNguoiDungChon(chon);
                }

                if (chon == 0) break;
            }
        }
    }

    public class Bai3_4
    {
        public static void Main(string[] args)
        {
            ConsoleMenu menu = new ConsoleMenu();

            menu.KhiNguoiDungChon += XuLyMenu;

            menu.HienThiVaChon();
        }

        public static void XuLyMenu(int luaChon)
        {
            if (luaChon == 1)
            {
                Console.WriteLine("\n--- GIAI PHUONG TRINH: ax^2 + bx + c = 0 ---");
                Console.Write("Nhap a (khac 0): "); double a = double.Parse(Console.ReadLine());
                Console.Write("Nhap b: "); double b = double.Parse(Console.ReadLine());
                Console.Write("Nhap c: "); double c = double.Parse(Console.ReadLine());

                double delta = b * b - 4 * a * c;
                if (delta < 0) Console.WriteLine("=> Phuong trinh vo nghiem!");
                else if (delta == 0) Console.WriteLine($"=> Nghiem kep: x = {-b / (2 * a)}");
                else Console.WriteLine($"=> 2 Nghiem: x1 = {(-b + Math.Sqrt(delta)) / (2 * a):F2}, x2 = {(-b - Math.Sqrt(delta)) / (2 * a):F2}");
            }
            else if (luaChon == 0) Console.WriteLine("Tam biet!");
            else Console.WriteLine("Chuc nang khong ton tai!");
        }
    }
}