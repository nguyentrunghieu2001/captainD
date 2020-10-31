using System;
using System.Collections.Generic;
using System.Text;

namespace Thuchanh3
{
    class Vecto
    {
        private int n;
        private int[] v;
        public Vecto()
        {
            n = 2;
            v = new int[2];
        }

        public Vecto(int n)
        {
            this.n = n;
            v = new int[n];
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap thong tin cua vecto");
            for (int i = 0; i < n; i++)
            {
                Console.Write("v[{0}] = ", i);
                v[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Hien()
        {
            Console.WriteLine("Thong tin cua vecto");
            for (int i = 0; i < n; i++)
                Console.Write("{0},", i);
        }

        public Vecto Tong(Vecto t2)
        {
            if (this.n == t2.n)
            {
                Vecto t = new Vecto(this.n);
                for (int i = 0; i < n; i++)
                    t.v[i] = this.v[i] + t2.v[i];
                return t;
            }
            else return null;
        }

        public Vecto Hieu(Vecto t2)
        {
            if (this.n == t2.n)
            {
                Vecto t = new Vecto(this.n);
                for (int i = 0; i < n; i++)
                    t.v[i] = this.v[i] - t2.v[i];
                return t;
            }
            else return null;
        }
    }

    class Appp
    {
        static void Main5_3(string[] args)
        {
            Console.WriteLine("Nhap thong tin cho vecto thu nhat");
            Vecto t1 = new Vecto(); t1.Nhap();
            Console.WriteLine("Nhap thong tin cho vecto thu hai");
            Vecto t2 = new Vecto(); t2.Nhap();

            Console.WriteLine("Tong hai vecto");
            Vecto tong = t1.Tong(t2);
            if (tong == null)
                Console.WriteLine("Khong tinh tong duoc vi 2 vecto co kich thuoc khong bang nhau");
            else
            {
                Console.WriteLine("Tong 2 vecto");
                tong.Hien();
            }

            Console.WriteLine("Hieu hai vecto");
            Vecto hieu = t1.Hieu(t2);
            if (hieu == null)
                Console.WriteLine("Khong tinh hieu duoc vi 2 vecto co kich thuoc khong bang nhau");
            else
            {
                Console.WriteLine("Hieu 2 vecto");
                hieu.Hien();
            }



            Console.ReadKey();
        }
    }

}

