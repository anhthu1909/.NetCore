using System;
using CS004;

namespace CS004_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CS004_Methods.Program.xinchao(); //goi phuong thuc trong C#
            xinchao();

            int kq, kq1;
            kq = tich(3,4);
            kq1 = Tinhtoan.tinhtong(3,4);           
            Console.WriteLine("Ket qua a nhan voi b la: {0} va ket qua a cong voi b la: {1}", kq, kq1);
            
            float a = 12.2f;
            float b = 10.3f;
            var kq2 = Tinhtoan.tinhtong(a, b);
            Console.WriteLine("Ket qua cong 2 so thuc a va b la: {0}", kq2);

            double kq3 = Tinhtoan.binhphuong(5);
            Console.WriteLine("Binh phuong cua 5 la: {0}", kq3);

            int max = Tinhtoan.max(4, 6);
            Console.WriteLine("So lon trong hai so la: {0}", max);
        
            //Tham so co gia tri mac dinh
            var thetich_hcn = Tinhtoan.thetich_hhcn(3);
            Console.WriteLine("The tich hinh hop chu nhat la: {0}", thetich_hcn);

            var thetich_hcn1 = Tinhtoan.thetich_hhcn(3, 3, 4);
            Console.WriteLine("The tich hinh hop chu nhat 1 la: {0}", thetich_hcn1);
            
            var thetich_hcn2 = Tinhtoan.thetich_hhcn(3, 4.2);
            Console.WriteLine("The tich hinh hop chu nhat 2 la: {0}", thetich_hcn2);

            //Truyen tham so voi ten
            var fullname = Fullname(ho: "Nguyen", ten: "Thu", tendem: "Anh");
            Console.WriteLine("Ten day du cua toi la: {0}", fullname);

            //Tham chieu tham tri
            int c = 2;
            thamtri(c); //tham so c duoc sao chep va gan cho bien cuc bo x cua phuong thuc, bien x duoc bien doi nhung a khong thay doi
            Console.WriteLine("c tham tri = {0}", c);
            thamchieu(ref c); // tham so a duoc su dung lam bien cho phuong thuc, bien x tham chieu den a va khi trong ham thay doi x nghia la thay doi a ben ngoai
            Console.WriteLine("c tham chieu= {0}", c);
            //Tham chieu voi Out, tham so khong can khoi tao khi truyen cho phuong thuc
            int d;
            thamchieuvoiOut(out d);
            Console.WriteLine("d tham chieu voi out= {0}", d);
            //Tham chieu yeu cau doi so phai la bien
            Console.WriteLine("Giai thua cua 10 = {0}", giaithua(10));
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

        public static string Fullname(string ho, string tendem, string ten)
        {
            return ho + (tendem != "" ? " " + tendem : " ") + " " + ten;
        }

        public static void thamtri(int x)
        {
            x = x * x;
            Console.WriteLine("x={0}",x);
        }
        public static void thamchieu(ref int x)
        {
            x = x * x;
            Console.WriteLine("x={0}", x);
        }
        public static void thamchieuvoiOut(out int x)
        {
           x = 100; 
        }
        public static int giaithua(int a)
        {
            if(a==1)
            {
                return 1;
            }
            else
            {
                return (a*giaithua(a-1));
            }
        }

    }
}

