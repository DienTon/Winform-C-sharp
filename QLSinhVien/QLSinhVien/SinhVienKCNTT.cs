using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    internal class SinhVienKCNTT
    {
        private string mssv;
        private string hoten;
        private string diachi;
        private DateTime ngaysinh;
        private double diemcs414;
        private double diemis311;
        private double diemcs311;

        public string MSSV { get => mssv; set => mssv = value; }
        public string HoTen { get => hoten; set => hoten = value; }
        public string DiaChi { get => diachi; set => diachi = value; }
        public DateTime NgaySinh { get => ngaysinh; set => ngaysinh = value; }
        public double DiemCS414 { get => diemcs414; set => diemcs414 = value; }
        public double DiemIS311 { get => diemis311; set => diemis311 = value; }
        public double DiemCS311 { get => diemcs311; set => diemcs311 = value; }

        public double DiemTB()
        {
            return (diemcs414 + diemis311 + diemcs311) / 3;
        }

        public void Nhap()
        {
            Console.Write("Nhap MSSV: ");
            mssv = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            diachi = Console.ReadLine();

            while (true)
            {
                Console.Write("Nhap ngay sinh (dd/MM/yyyy): ");
                if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out ngaysinh))
                    break;
                else
                    Console.WriteLine("Ngay sinh khong dung dinh dang, vui long nhap lai.");
            }

            Console.Write("Nhap diem CS414: ");
            diemcs414 = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem IS311: ");
            diemis311 = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem CS311: ");
            diemcs311 = double.Parse(Console.ReadLine());
        }

        public string TinhXepLoai()
        {
            double dtb = DiemTB();
            if (dtb >= 8) return "Gioi";
            else if (dtb >= 6.5) return "Kha";
            else if (dtb >= 5) return "Trung Binh";
            else return "Yeu";
        }

        public void Xuat()
        {
            Console.WriteLine($"MSSV: {MSSV}, Ho Ten: {HoTen}, Dia Chi: {DiaChi}, Ngay Sinh: {NgaySinh.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Diem TB: {DiemTB():0.00}, Xep Loai: {TinhXepLoai()}");
        }

        //static void Main(string[] args)
        //{
        //    Console.Write("Nhập số lượng sinh viên: ");
        //    int soLuong = int.Parse(Console.ReadLine());

        //    SinhVienKCNTT[] dsSinhVien = new SinhVienKCNTT[soLuong];

        //    for (int i = 0; i < soLuong; i++)
        //    {
        //        var svdt = new SinhVienKCNTT();
        //        svdt.Nhap();
        //        dsSinhVien[i] = svdt;
        //    }
        //    for (int i = 0; i < soLuong; i++)
        //    {

        //        dsSinhVien[i].Xuat();
        //        Console.WriteLine();
        //    }
        //}
    }
}
