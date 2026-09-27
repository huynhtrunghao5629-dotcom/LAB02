using System;

namespace THUCHANH02
{
    public class SinhVien3_2
    {
        public string HoTen { get; set; }
        public double Diem { get; set; }

        public SinhVien3_2(string ten, double diem) { HoTen = ten; Diem = diem; }
        public override string ToString() => $"{HoTen} - {Diem} diem";
    }

    public interface IGiaoDienSoSanh
    {
        bool LonHon(SinhVien3_2 a, SinhVien3_2 b);
    }

    public class SoSanhDiem : IGiaoDienSoSanh
    {
        public bool LonHon(SinhVien3_2 a, SinhVien3_2 b) => a.Diem > b.Diem;
    }

    public class Bai3_2
    {
        public static void SapXepMang(SinhVien3_2[] mang, IGiaoDienSoSanh boSoSanh)
        {
            for (int i = 0; i < mang.Length - 1; i++)
                for (int j = i + 1; j < mang.Length; j++)
                    if (boSoSanh.LonHon(mang[i], mang[j]))
                    {
                        SinhVien3_2 tam = mang[i];
                        mang[i] = mang[j];
                        mang[j] = tam;
                    }
        }

        public static void Main(string[] args)
        {
            SinhVien3_2[] mang = {
                new SinhVien3_2("An", 8),
                new SinhVien3_2("Binh", 5),
                new SinhVien3_2("Cuong", 9)
            };

            Console.WriteLine("--- SAP XEP TANG DAN BANG INTERFACE ---");
            SapXepMang(mang, new SoSanhDiem()); 

            foreach (var sv in mang) Console.WriteLine(sv);
            Console.ReadLine();
        }
    }
}