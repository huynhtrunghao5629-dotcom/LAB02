using System;

namespace THUCHANH02
{
    public class SinhVien3_1 : IComparable<SinhVien3_1>
    {
        public string HoTen { get; set; }
        public double Diem { get; set; }

        public SinhVien3_1(string ten, double diem) { HoTen = ten; Diem = diem; }
        public override string ToString() => $"{HoTen} - {Diem} diem";

        public int CompareTo(SinhVien3_1 khac)
        {
            return this.Diem.CompareTo(khac.Diem);
        }
    }

    public class Bai3_1
    {
        public static void Main(string[] args)
        {
            SinhVien3_1[] mang = {
                new SinhVien3_1("An", 8),
                new SinhVien3_1("Binh", 5),
                new SinhVien3_1("Cuong", 9)
            };

            Console.WriteLine("--- SAP XEP TANG DAN ARRAY.SORT ---");
            Array.Sort(mang); 

            foreach (var sv in mang) Console.WriteLine(sv);
            Console.ReadLine();
        }
    }
}