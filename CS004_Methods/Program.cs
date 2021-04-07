using System;

namespace CS004_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            int kq, kq1;
            kq = tich(3,4);
            kq1 = Tinhtoan.tinhtong(3,4);
            CS004_Methods.Program.xinchao();
            xinchao();
            Console.WriteLine("Ket qua a nhan voi b la: {0} va ket qua a cong voi b la: {1}", kq, kq1);

        }
        static void xinchao()
        {
            Console.WriteLine("==================");
            Console.WriteLine("Xin Chao Anh Thu");
            Console.WriteLine("==================");
        }

        public static int tich(int a, int b)
        {
            return a*b;
        }
    }
}
