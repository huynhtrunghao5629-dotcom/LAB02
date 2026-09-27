using System;

namespace THUCHANH02
{
    public class Bai1_5
    {
        public double a { get; set; }
        public int n { get; set; }

        public Bai1_5(double heSo, int soMu)
        {
            a = heSo; n = soMu;
        }

        public double TinhGiaTri(double x) => a * Math.Pow(x, n);

        public Bai1_5 DaoHam()
        {
            if (n == 0) return new Bai1_5(0, 0);
            return new Bai1_5(a * n, n - 1);
        }

        public override string ToString()
        {
            if (a == 0) return "0";
            if (n == 0) return $"{a}";

            string heSoStr = (a == 1) ? "" : (a == -1 ? "-" : $"{a}");

            if (n == 1) return $"{heSoStr}x";
            return $"{heSoStr}x^{n}";
        }

        public static void Main(string[] args)
        {
            Console.Write("Nhap he so a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap so mu n (nguyen khong am): ");
            int n = int.Parse(Console.ReadLine());

            Bai1_5 donThuc = new Bai1_5(a, n);
            Console.WriteLine($"Don thuc P(x) = {donThuc}");

            Console.Write("Nhap x de tinh P(x): ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine($"=> P({x}) = {donThuc.TinhGiaTri(x)}");

            Console.WriteLine($"=> Dao ham Q(x) = P'(x) = {donThuc.DaoHam()}");
            Console.ReadLine();
        }
    }
}