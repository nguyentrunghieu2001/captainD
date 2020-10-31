using System;
using System.Collections.Generic;
using System.Text;

namespace Thuchanh3
{
    class HocSinh
    {
        private string hoten;
        private double diemtoan, diemli, diemhoa;

        public HocSinh()
        {
            hoten = "";
            diemtoan = diemli = diemhoa = 0;
        }

        public HocSinh(string hoten, double diemtoan, double diemli, double diemhoa)
        {
            this.hoten = hoten;
            this.diemtoan = diemtoan;
            this.diemli = diemli;
            this.diemhoa = diemhoa;
        }

        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap diem toan: ");
            diemtoan = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem li: ");
            diemli = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem hoa: ");
            diemhoa = double.Parse(Console.ReadLine());
        }

        public virtual void Hien()
        {
            Console.WriteLine("Ho ten: " + hoten);
            Console.WriteLine("Diem toan: " + diemtoan);
            Console.WriteLine("Diem li: " + diemli);
            Console.WriteLine("Diem hoa: " + diemhoa);
        }

    }

    class QL
    {
        private HocSinh[] dshs;
        private int shs;
        public void Nhap()
        {
            Console.Write("Nhap so hoc sinh: ");
            shs = int.Parse(Console.ReadLine());
            dshs = new HocSinh[shs];
            for (int i = 0; i < shs; i++)
            {
                dshs[i] = new HocSinh();
                dshs[i].Nhap();
            }
        }

        public void Hien()
        {
            for (int i = 0; i < shs; i++)
                dshs[i].Hien();
        }

    }

    class Ap
    {
        static void Main4_3(string[] args)
        {
            QL t = new QL();
            t.Nhap();
            t.Hien();
            Console.ReadLine();
        }
    }
}
