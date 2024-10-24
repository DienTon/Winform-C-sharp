using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    internal class SinhVienDienTu
    {
        private string mssv;
        private string hoten;
        private string diachi;
        private DateTime ngaysinh;
        private double diemEE200;
        private double diemEE201;
        private double diemEE205;

        public string MSSV { get => mssv; set => mssv = value; }
        public string HoTen { get => hoten; set => hoten = value; }
        public string DiaChi { get => diachi; set => diachi = value; }
        public DateTime NgaySinh { get => ngaysinh; set => ngaysinh = value; }
        public double DiemEE200 { get => diemEE200; set => diemEE200 = value; }
        public double DiemEE201 { get => diemEE201; set => diemEE201 = value; }
        public double DiemEE205 { get => diemEE205; set => diemEE205 = value; }


        public SinhVienDienTu(int soLuong)
        {
        }

        public SinhVienDienTu()
        {
        }

        

        public new double DiemTB()
        {
            return (diemEE200 + diemEE201 + diemEE205) / 3;
        }
        public string TinhXepLoai()
        {
            double dtb = DiemTB();
            if (dtb >= 8) return "Gioi";
            else if (dtb >= 6.5) return "Kha";
            else if (dtb >= 5) return "Trung Binh";
            else return "Yeu";
        }

        public new void Nhap()
        {
            Console.Write("Nhập MSSV: ");
            MSSV = Console.ReadLine();
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            DiaChi = Console.ReadLine();
            while (true)
            {
                Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
                try
                {
                    NgaySinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ngày sinh không đúng định dạng, vui lòng nhập lại.");
                }
            }
            Console.Write("Nhập điểm EE200: ");
            DiemEE200 = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm EE201: ");
            DiemEE201 = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm EE205: ");
            DiemEE205 = double.Parse(Console.ReadLine());
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

        //    SinhVienDienTu[] dsSinhVien = new SinhVienDienTu[soLuong];

        //    for (int i = 0; i < soLuong; i++)
        //    {
        //        var svdt = new SinhVienDienTu();
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
