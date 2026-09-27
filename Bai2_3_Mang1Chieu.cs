using System;

namespace THUCHANH02
{
    public class Bai2_3_Mang1Chieu
    {
        private int[] mangSo;
        private int soLuong;

        public Bai2_3_Mang1Chieu() { soLuong = 0; mangSo = new int[0]; }
        public Bai2_3_Mang1Chieu(int n) { soLuong = n; mangSo = new int[soLuong]; }

        public int this[int i]
        {
            get { return mangSo[i]; }
            set { mangSo[i] = value; }
        }

        public void Nhap()
        {
            Console.Write("Nhap so luong phan tu: ");
            soLuong = int.Parse(Console.ReadLine());
            mangSo = new int[soLuong];
            for (int i = 0; i < soLuong; i++)
            {
                Console.Write($"Phan tu thu ({i}) = ");
                mangSo[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Xuat()
        {
            for (int i = 0; i < soLuong; i++) Console.Write(mangSo[i] + " ");
            Console.WriteLine();
        }

        public void InCacSoChan()
        {
            Console.Write("Cac so chan gom co: ");
            foreach (int so in mangSo)
            {
                if (so % 2 == 0) Console.Write(so + " ");
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            Bai2_3_Mang1Chieu mang = new Bai2_3_Mang1Chieu();
            mang.Nhap();
            Console.Write("Mang vua nhap la: ");
            mang.Xuat();
            mang.InCacSoChan();
            Console.ReadLine();
        }
    }
}