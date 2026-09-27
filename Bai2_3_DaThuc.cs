using System;

namespace THUCHANH02
{
    public class Bai2_3_DaThuc
    {
        private Bai1_5[] mangDonThuc;
        private int bacDaThuc;

        public Bai2_3_DaThuc(int n)
        {
            bacDaThuc = n;
            mangDonThuc = new Bai1_5[n + 1];
        }

        public Bai1_5 this[int i]
        {
            get { return mangDonThuc[i]; }
            set { mangDonThuc[i] = value; }
        }

        public void Nhap()
        {
            Console.Write("Nhap bac cua da thuc: ");
            bacDaThuc = int.Parse(Console.ReadLine());
            mangDonThuc = new Bai1_5[bacDaThuc + 1];

            for (int i = 0; i <= bacDaThuc; i++)
            {
                Console.Write($"Nhap he so cho x^{i}: ");
                double heSo = double.Parse(Console.ReadLine());
                mangDonThuc[i] = new Bai1_5(heSo, i);
            }
        }

        public void Xuat()
        {
            Console.Write("Da thuc P(x) = ");
            for (int i = 0; i <= bacDaThuc; i++)
            {
                Console.Write(mangDonThuc[i]);
                if (i < bacDaThuc && mangDonThuc[i + 1].a >= 0) Console.Write(" + ");
                else if (i < bacDaThuc) Console.Write(" ");
            }
            Console.WriteLine();
        }

        public double TinhGiaTriDaThuc(double x)
        {
            double tong = 0;
            for (int i = 0; i <= bacDaThuc; i++)
            {
                tong += mangDonThuc[i].TinhGiaTri(x);
            }
            return tong;
        }

        public static void Main(string[] args)
        {
            Bai2_3_DaThuc daThuc = new Bai2_3_DaThuc(0);
            daThuc.Nhap();
            daThuc.Xuat();

            Console.Write("Nhap gia tri x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine($"=> Ket qua P({x}) = {daThuc.TinhGiaTriDaThuc(x)}");
            Console.ReadLine();
        }
    }
}