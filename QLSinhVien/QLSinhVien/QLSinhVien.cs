using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    internal class QLSinhVien
    {
        private SinhVienKCNTT[] dsSinhVien;
        private SinhVienDienTu[] dsSinhVienDT;
        private int soLuongSinhVien;
        private int soLuongSinhVienDT;

        

        public QLSinhVien()
        {
            dsSinhVien = new SinhVienKCNTT[99];
            dsSinhVienDT = new SinhVienDienTu[99];
            soLuongSinhVien = 0;
            soLuongSinhVienDT = 0;
        }

        public void Nhap()
        {
            Console.Write("Nhập số lượng sinh viên: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập (D) sinh viên điện tử, (C) sinh viên công nghệ thông tin: ");
                char loai = char.ToUpper(Console.ReadLine()[0]);

                if (loai == 'C')
                {
                    var sv = new SinhVienKCNTT();
                    sv.Nhap();
                    dsSinhVien[soLuongSinhVien] = sv;
                    soLuongSinhVien++;
                }
                else if (loai == 'D')
                {
                    var svdt = new SinhVienDienTu();
                    svdt.Nhap();
                    dsSinhVienDT[soLuongSinhVienDT] = svdt;
                    soLuongSinhVienDT++;
                }
            }
        }

        public void Xuat()
        {
            Console.WriteLine("Danh sách sinh viên Công nghệ thông tin:");
            for (int i = 0; i < soLuongSinhVien; i++)
            {
                dsSinhVien[i].Xuat();
                Console.WriteLine();
            }

            Console.WriteLine("Danh sách sinh viên Điện tử:");
            for (int i = 0; i < soLuongSinhVienDT; i++)
            {
                dsSinhVienDT[i].Xuat();
                Console.WriteLine();
            }
        }

        public void ThongKe()
        {
            int gioi = 0, kha = 0, trungBinh = 0, yeu = 0;

            for (int i = 0; i < soLuongSinhVien; i++)
            {
                switch (dsSinhVien[i].TinhXepLoai())
                {
                    case "Gioi": gioi++; break;
                    case "Kha": kha++; break;
                    case "Trung binh": trungBinh++; break;
                    case "Yeu": yeu++; break;
                }
            }

            for (int i = 0; i < soLuongSinhVienDT; i++)
            {
                switch (dsSinhVienDT[i].TinhXepLoai())
                {
                    case "Gioi": gioi++; break;
                    case "Kha": kha++; break;
                    case "Trung binh": trungBinh++; break;
                    case "Yeu": yeu++; break;
                }
            }

            Console.WriteLine($"Số sinh viên Giỏi: {gioi}");
            Console.WriteLine($"Số sinh viên Khá: {kha}");
            Console.WriteLine($"Số sinh viên Trung bình: {trungBinh}");
            Console.WriteLine($"Số sinh viên Yếu: {yeu}");
        }

        public static void Main(string[] args)
        {

            QLSinhVien qlSinhVien = new QLSinhVien();

            qlSinhVien.Nhap();
            qlSinhVien.Xuat();
            qlSinhVien.ThongKe();
        }
    }
}
