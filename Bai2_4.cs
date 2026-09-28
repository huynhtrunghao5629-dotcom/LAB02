        using System;

namespace THUCHANH02
{
    public class Bai2_4
    {
        private Bai1_4[] mangPhanSo;
        private int soLuong;

        public void Nhap()
        {
            Console.Write("Nhap so luong phan so: ");
            soLuong = int.Parse(Console.ReadLine());
            mangPhanSo = new Bai1_4[soLuong];

            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine($"--- Nhap phan so thu {i + 1} ---");
                Console.Write("Tu so: "); int tu = int.Parse(Console.ReadLine());
                Console.Write("Mau so: "); int mau = int.Parse(Console.ReadLine());
                mangPhanSo[i] = new Bai1_4(tu, mau);
            }
        }

        public void Xuat()
        {
            Console.Write("Danh sach phan so: ");
            for (int i = 0; i < soLuong; i++)
            {
                Console.Write(mangPhanSo[i]);

                if (i < soLuong - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        public Bai1_4 TinhTongPhanSo()
        {
            Bai1_4 tong = new Bai1_4(0, 1);
            for (int i = 0; i < soLuong; i++)
            {
                tong = tong + mangPhanSo[i];
            }
            tong.RutGon();
            return tong;
        }

        public static void Main(string[] args)
        {
            Bai2_4 dayPS = new Bai2_4();
            dayPS.Nhap();
            dayPS.Xuat();
            Console.WriteLine($"Tong cua day phan so la: {dayPS.TinhTongPhanSo()}");
            Console.ReadLine();
        }
    }
}