using System;

namespace THUCHANH02
{
    public class Bai1_3
    {
        private string maSo;
        private string hoTen;
        private int namSinh;
        private int namMat;

        public Bai1_3() { maSo = ""; hoTen = ""; namSinh = 0; namMat = 0; }
        public Bai1_3(Bai1_3 nguoiKhac) { this.maSo = nguoiKhac.maSo; this.hoTen = nguoiKhac.hoTen; this.namSinh = nguoiKhac.namSinh; this.namMat = nguoiKhac.namMat; }

        public void Nhap()
        {
            Console.Write("Nhap ma so: "); maSo = Console.ReadLine();
            Console.Write("Nhap ho ten: "); hoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: "); namSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam mat (nhap 0 neu con song): "); namMat = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            string trangThai = ConSong() ? "Con song" : $"Da mat nam {namMat}";
            Console.WriteLine($"Ma so: {maSo} | Ho ten: {hoTen} | Nam sinh: {namSinh} | {trangThai}");
        }

        public bool ConSong() => namMat == 0;

        public static void Main(string[] args)
        {
            Bai1_3 nguoi1 = new Bai1_3();
            nguoi1.Nhap();
            nguoi1.Xuat();

            Console.WriteLine("\n--- Tao ban sao ---");
            Bai1_3 nguoi2 = new Bai1_3(nguoi1);
            nguoi2.Xuat();
            Console.ReadLine();
        }
    }
}