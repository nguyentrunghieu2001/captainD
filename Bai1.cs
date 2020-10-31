using System;

namespace Thuchanh3
{
    class Phanso
    {
        private int ts, ms;
        public Phanso()
        {
            ts = 0; ms = 1;
        }

        public Phanso(int ts, int ms)
        {
            this.ts = ts;
            this.ms = ms;
        }

        public void Nhap()
        {
            Console.Write("Nhap tu so: "); ts = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: "); ms = int.Parse(Console.ReadLine());
        }

        public void Hien()
        {
            if (ms == 1) Console.WriteLine("{0}", ts);
            else
                Console.WriteLine("{0}/{1}", ts, ms);
        }

        public int Ucln(int x, int y)
        {
            x = Math.Abs(x); y = Math.Abs(y);
            while (x != y)
            {
                if (x > y) x = x - y;
                if (y > x) y = y - x;
            }
            return x;
        }

        public Phanso ToiGian()
        {
            int uc = Ucln(this.ts, this.ms);
            this.ts = this.ts / uc;
            this.ms = this.ms / uc;
            return this;
        }

        public static Phanso operator +(Phanso t1, Phanso t2)
        {
            Phanso tong = new Phanso();
            tong.ts = t1.ts * t2.ms + t2.ts * t1.ms;
            tong.ms = t2.ms * t1.ms;
            tong.ToiGian();
            return tong;
        }

        public Phanso Cong(Phanso b)
        {
            Phanso tong = new Phanso();
            tong.ts = this.ts * b.ms + b.ts * this.ms;
            tong.ms = this.ms + b.ms;
            tong.ToiGian();
            return tong;
        }

        public static Phanso operator -(Phanso t1, Phanso t2)
        {
            Phanso tru = new Phanso();
            tru.ts = t1.ts * t2.ms - t2.ts * t1.ms;
            tru.ms = t2.ms * t1.ms;
            tru.ToiGian();
            return tru;
        }

        public Phanso Tru(Phanso b)
        {
            Phanso tru = new Phanso();
            tru.ts = this.ts * b.ms - b.ts * this.ms;
            tru.ms = this.ms + b.ms;
            tru.ToiGian();
            return tru;
        }
    }

    class App
    {
        static void Main1_3()
        {
            Phanso t1 = new Phanso();
            Phanso t2 = new Phanso();
            Console.WriteLine("Tong 2 phan so");
            Phanso tTong = t1.Cong(t2); tTong.Hien();
            Console.WriteLine("Hieu 2 phan so");
            Phanso tHieu = t1.Tru(t2); tHieu.Hien();


        }
    }
}