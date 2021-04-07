using System;

namespace CS004
{
    class Tinhtoan
    {
        public static int tinhtong(int a, int b)
        {
            return a+b;
        }
        public static float tinhtong(float a, float b)
        {
            return a+b;
        }
        public static double binhphuong(double number)
        {
            double kq = number * number;
            return kq;
        }

        public static int max(int a, int b)
        {
            int max = a>=b ? a:b;
            return max;
        }
        public static double thetich_hhcn(double dai, double rong = 2.5, double cao = 3.2)
        {
            return dai*rong*cao;
        }
    }
}


