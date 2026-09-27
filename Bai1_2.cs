using System;

namespace THUCHANH02
{
    public class Bai1_2
    {
        private double x;
        private double y;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public Bai1_2() { x = 0; y = 0; }
        public Bai1_2(double x, double y) { this.x = x; this.y = y; }

        public void Nhap()
        {
            Console.Write("Nhap toa do x: "); x = double.Parse(Console.ReadLine());
            Console.Write("Nhap toa do y: "); y = double.Parse(Console.ReadLine());
        }

        public void Xuat() => Console.WriteLine(this.ToString());
        public override string ToString() => $"({x}, {y})";

        // Toán tử
        public static Bai1_2 operator +(Bai1_2 diem1, Bai1_2 diem2) => new Bai1_2(diem1.x + diem2.x, diem1.y + diem2.y);
        public static Bai1_2 operator -(Bai1_2 diem1, Bai1_2 diem2) => new Bai1_2(diem1.x - diem2.x, diem1.y - diem2.y);
        public static Bai1_2 operator -(Bai1_2 diem) => new Bai1_2(-diem.x, -diem.y);

        // Phương thức
        public double KhoangCach(Bai1_2 diemKhac) => Math.Sqrt(Math.Pow(this.x - diemKhac.x, 2) + Math.Pow(this.y - diemKhac.y, 2));
        public static double KhoangCach(Bai1_2 diem1, Bai1_2 diem2) => Math.Sqrt(Math.Pow(diem1.x - diem2.x, 2) + Math.Pow(diem1.y - diem2.y, 2));

        public Bai1_2 TrungDiem(Bai1_2 diemKhac) => new Bai1_2((this.x + diemKhac.x) / 2, (this.y + diemKhac.y) / 2);
        public static Bai1_2 TrungDiem(Bai1_2 diem1, Bai1_2 diem2) => new Bai1_2((diem1.x + diem2.x) / 2, (diem1.y + diem2.y) / 2);

        public static void Main(string[] args)
        {
            Console.WriteLine("Diem A : ");
            Bai1_2 A = new Bai1_2(); A.Nhap();

            Console.WriteLine("Diem B : ");
            Bai1_2 B = new Bai1_2(); B.Nhap();

            Console.WriteLine($"\nKhoang cach : {A.KhoangCach(B)}");
            Console.WriteLine($"Trung diem : {Bai1_2.TrungDiem(A, B)}");
            Console.ReadLine();
        }
    }
}