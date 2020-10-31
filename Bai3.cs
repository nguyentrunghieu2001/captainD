using System;
using System.Collections.Generic;
using System.Text;

namespace Thuchanh3
{
    class Time
    {
        private int gio, phut, giay;
        public Time()
        {
            gio = 0;
            phut = 0;
            giay = 0;
        }
        public Time(int gio, int phut, int giay)
        {
            this.gio = gio;
            this.phut = phut;
            this.giay = giay;
        }
        public int Gio
        {
            get
            {
                return gio;
            }
            set
            {
                gio = value;
            }
        }
        public int Phut
        {
            get
            {
                return phut;
            }
            set
            {
                phut = value;
            }
        }
        public int Giay
        {
            get
            {
                return giay;
            }
            set
            {
                giay = value;
            }
        }
        public Time normalize()
        {
            this.phut += giay / 60;
            this.giay = giay % 60;
            this.gio += phut % 60;
            this.phut = phut % 60;
            this.gio = gio % 24;
            return this;
        }
        public Time advance(int gio, int phut, int giay)
        {
            Time t = new Time();
            t.gio = this.gio + gio;
            t.phut = this.phut + phut;
            t.giay = this.giay + giay;
            t.phut += t.giay / 60;
            t.giay = t.giay % 60;
            t.gio += t.phut % 60;
            t.phut = t.phut % 60;
            t.gio = t.gio % 24;
            return t;

        }
        public void print()
        {
            Console.WriteLine("Thoi gian:{0}:{1}:{2}", gio, phut, giay);
        }

    }
    class Progam
    {
        static void Main(string[] args)
        {
            Time t = new Time(23, 561, 89);
            Time t2 = t.normalize();
            t2.print();
            Time t3 = t.advance(35, 2, 24);
            t3.print();
            Console.ReadKey();
        }
    }
}