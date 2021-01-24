using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace XY
{
    class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            SetX(x);
            SetY(y);
        }

        public int GetX()
        {
            return x;
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public int GetY()
        {
            return y;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public void show()
        {
            Console.WriteLine($" X: {GetX()}");
            Console.WriteLine($" Y: {GetY()}");
        }
    }


    class Counter
    {

        public Counter(int max, int counters = 1)
        {
            Max = max;

            Counters = counters;
        }


        public Counter()
        {

        }
        public int Max { get; set; }




        private int counters;
        public int Counters
        {
            get
            {
                return counters;
            }

            set
            {
                if (value < Max)
                {

                    counters = value;

                }
            }
        }


        public void showCounter()
        {
            for (int i = 0; i < Max; i++)
            {
                if (Counters < Max)
                {

                    Console.WriteLine($" Counters: { Counters++}");
                    Thread.Sleep(1000);
                    Console.Clear();
                }








            }

        }

    }












    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write(" X -i daxil edin: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Y -i daxil edin: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Point p = new Point(x, y);
            p.show();

            Console.WriteLine("\n");



            Console.Write(" Max -i daxil edin: ");
            int max = Convert.ToInt32(Console.ReadLine());
            Counter c = new Counter(max);


            if (c.Max == 10)
            {
                Thread.Sleep(1000);
                Console.Clear();
                c.showCounter();
                Console.WriteLine($" Counters: { 0}");
            }
            else
            {
                Thread.Sleep(1000);
                Console.Clear();
                c.showCounter();
                Console.Clear();
            }

            Console.ReadKey();
        }
    }
}
