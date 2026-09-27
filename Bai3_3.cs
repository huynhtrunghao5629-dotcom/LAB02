using System;

namespace THUCHANH02
{
    public class SinhVien3_3
    {
        public string HoTen { get; set; }
        public double Diem { get; set; }

        public SinhVien3_3(string ten, double diem) { HoTen = ten; Diem = diem; }
        public override string ToString() => $"{HoTen} - {Diem} diem";
    }

    public delegate bool HamSoSanh(SinhVien3_3 a, SinhVien3_3 b);

    public class Bai3_3
    {
        public static void SapXepBangDelegate(SinhVien3_3[] mang, HamSoSanh hamSoSanh)
        {
            for (int i = 0; i < mang.Length - 1; i++)
                for (int j = i + 1; j < mang.Length; j++)
                    if (hamSoSanh(mang[i], mang[j]))
                    {
                        SinhVien3_3 tam = mang[i];
                        mang[i] = mang[j];
                        mang[j] = tam;
                    }
        }

        public static void Main(string[] args)
        {
            SinhVien3_3[] mang = {
                new SinhVien3_3("An", 8),
                new SinhVien3_3("Binh", 5),
                new SinhVien3_3("Cuong", 9)
            };

            Console.WriteLine("--- SAP XEP GIAM DAN BANG DELEGATE ---");
            SapXepBangDelegate(mang, (a, b) => a.Diem < b.Diem);

            foreach (var sv in mang) Console.WriteLine(sv);
            Console.ReadLine();
        }
    }
}