using System;

namespace THUCHANH02
{
    public class Bai1_4
    {
        private int tu;
        private int mau;

        public Bai1_4() { tu = 0; mau = 1; }

        public Bai1_4(int tu, int mau)
        {
            if (mau == 0) throw new DivideByZeroException("Mau so khong duoc bang 0!");
            this.tu = tu;
            this.mau = mau;
            RutGon();
        }

        public Bai1_4(Bai1_4 ps) { this.tu = ps.tu; this.mau = ps.mau; }

        private int UCLN(int a, int b)
        {
            a = Math.Abs(a); b = Math.Abs(b);
            while (a != b && b != 0 && a != 0)
            {
                if (a > b) a = a - b; else b = b - a;
            }
            return a == 0 ? b : a;
        }

        public void RutGon()
        {
            int c = UCLN(tu, mau);
            if (c > 0) { tu /= c; mau /= c; }
            if (mau < 0) { tu = -tu; mau = -mau; }
        }

        public override string ToString() => mau == 1 ? $"{tu}" : (tu == 0 ? "0" : $"{tu}/{mau}");

        public static Bai1_4 operator +(Bai1_4 ps) => new Bai1_4(ps.tu, ps.mau);
        public static Bai1_4 operator -(Bai1_4 ps) => new Bai1_4(-ps.tu, ps.mau);

        public static Bai1_4 operator +(Bai1_4 a, Bai1_4 b) => new Bai1_4(a.tu * b.mau + b.tu * a.mau, a.mau * b.mau);
        public static Bai1_4 operator -(Bai1_4 a, Bai1_4 b) => new Bai1_4(a.tu * b.mau - b.tu * a.mau, a.mau * b.mau);
        public static Bai1_4 operator *(Bai1_4 a, Bai1_4 b) => new Bai1_4(a.tu * b.tu, a.mau * b.mau);
        public static Bai1_4 operator /(Bai1_4 a, Bai1_4 b) => new Bai1_4(a.tu * b.mau, a.mau * b.tu);

        public static bool operator >(Bai1_4 a, Bai1_4 b) => a.tu * b.mau > b.tu * a.mau;
        public static bool operator <(Bai1_4 a, Bai1_4 b) => a.tu * b.mau < b.tu * a.mau;
        public static bool operator >=(Bai1_4 a, Bai1_4 b) => a.tu * b.mau >= b.tu * a.mau;
        public static bool operator <=(Bai1_4 a, Bai1_4 b) => a.tu * b.mau <= b.tu * a.mau;

        public static bool operator ==(Bai1_4 a, Bai1_4 b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            return a.tu * b.mau == b.tu * a.mau;
        }
        public static bool operator !=(Bai1_4 a, Bai1_4 b) => !(a == b);

        public override bool Equals(object obj) => obj is Bai1_4 so && this == so;
        public override int GetHashCode() => tu.GetHashCode() ^ mau.GetHashCode();

        public static void Main(string[] args)
        {
            Bai1_4 ps1 = new Bai1_4(1, 2);
            Bai1_4 ps2 = new Bai1_4(3, 4);
            Console.WriteLine($"Phan so 1: {ps1}");
            Console.WriteLine($"Phan so 2: {ps2}");
            Console.WriteLine("-------------------");

            Console.WriteLine($"Cong: {ps1} + {ps2} = {ps1 + ps2}");
            Console.WriteLine($"Tru: {ps1} - {ps2} = {ps1 - ps2}");
            Console.WriteLine($"Nhan: {ps1} * {ps2} = {ps1 * ps2}");
            Console.WriteLine($"Chia: {ps1} / {ps2} = {ps1 / ps2}");
            Console.WriteLine($"Toan tu 1 ngoi (am ps1): {-ps1}");

            Console.WriteLine("-------------------");
            Console.WriteLine($"PS1 co lon hon PS2 khong? {(ps1 > ps2 ? "Co" : "Khong")}");
            Console.WriteLine($"PS1 co bang PS2 khong? {(ps1 == ps2 ? "Co" : "Khong")}");

            Console.ReadLine();
        }
    }
}