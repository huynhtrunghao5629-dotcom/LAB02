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

        public void Input()
        {
            Console.Write("Nhap toa do x: "); x = double.Parse(Console.ReadLine());
            Console.Write("Nhap toa do y: "); y = double.Parse(Console.ReadLine());
        }

        public void Output() => Console.WriteLine(this.ToString());
        public override string ToString() => $"({x}, {y})";

        // Toán tử
        public static Bai1_2 operator +(Bai1_2 p1, Bai1_2 p2) => new Bai1_2(p1.x + p2.x, p1.y + p2.y);
        public static Bai1_2 operator -(Bai1_2 p1, Bai1_2 p2) => new Bai1_2(p1.x - p2.x, p1.y - p2.y);
        public static Bai1_2 operator -(Bai1_2 p) => new Bai1_2(-p.x, -p.y);

        // Phương thức
        public double KhoangCach(Bai1_2 pKhac) => Math.Sqrt(Math.Pow(this.x - pKhac.x, 2) + Math.Pow(this.y - pKhac.y, 2));
        public static double KhoangCach(Bai1_2 p1, Bai1_2 p2) => Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));

        public Bai1_2 TrungDiem(Bai1_2 pKhac) => new Bai1_2((this.x + pKhac.x) / 2, (this.y + pKhac.y) / 2);
        public static Bai1_2 TrungDiem(Bai1_2 p1, Bai1_2 p2) => new Bai1_2((p1.x + p2.x) / 2, (p1.y + p2.y) / 2);

        public static void Main(string[] args)
        {
            Console.WriteLine("Diem A : ");
            Bai1_2 A = new Bai1_2(); A.Input();

            Console.WriteLine("\nDiem B : ");
            Bai1_2 B = new Bai1_2(); B.Input();

            Console.WriteLine($"\nKhoang cach : {A.KhoangCach(B)}");
            Console.WriteLine($"Trung diem : {Bai1_2.TrungDiem(A, B)}");
            Console.ReadLine();
        }
    }
}