using System;

namespace THUCHANH02
{
    public class Bai2_4_Mang2Chieu
    {
        private int[,] mangSo;
        private int soDong;
        private int soCot;

   
        public Bai2_4_Mang2Chieu()
        {
            soDong = 0;
            soCot = 0;
            mangSo = new int[0, 0];
        }

        public Bai2_4_Mang2Chieu(int dong, int cot)
        {
            soDong = dong;
            soCot = cot;
            mangSo = new int[dong, cot];
        }

     
        public int this[int i, int j]
        {
            get { return mangSo[i, j]; }
            set { mangSo[i, j] = value; }
        }

        
        public void Nhap()
        {
            Console.Write("Nhap so dong (n): ");
            soDong = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot (m): ");
            soCot = int.Parse(Console.ReadLine());

          
            mangSo = new int[soDong, soCot];

            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    Console.Write($"Nhap phan tu [{i},{j}] = ");
                    mangSo[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }


        public void Xuat()
        {
            Console.WriteLine("\n--- MANG 2 CHIEU VUA NHAP ---");
            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    Console.Write(mangSo[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }


        private bool KiemTraSoNguyenTo(int so)
        {
            if (so < 2) return false;
            for (int i = 2; i <= Math.Sqrt(so); i++)
            {
                if (so % i == 0) return false;
            }
            return true;
        }

 
        public void InCacSoNguyenTo()
        {
            Console.Write("\nCac so nguyen to co trong mang gom: ");
            bool coSoNguyenTo = false;

            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    if (KiemTraSoNguyenTo(mangSo[i, j]))
                    {
                        Console.Write(mangSo[i, j] + " ");
                        coSoNguyenTo = true;
                    }
                }
            }

            if (!coSoNguyenTo) Console.Write("Khong co so nao!");
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            Bai2_4_Mang2Chieu mang2C = new Bai2_4_Mang2Chieu();
            mang2C.Nhap();
            mang2C.Xuat();
            mang2C.InCacSoNguyenTo();
            Console.ReadLine();
        }
    }
}