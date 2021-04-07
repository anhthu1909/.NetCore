using System;
using System.Linq;

namespace CS005_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao chuoi
            string sinhvien = "nguyen van a";
            string sinhvien1 = "nguyen van b";
            string sinhvien2 = "nguyen van c";
            Console.WriteLine("{0}\n{1}\n{2}",sinhvien, sinhvien1, sinhvien2);
            Console.WriteLine("===========================");

            // Khai bao mang 1 chieu
            string[] ds;
            ds = new string[3];
            ds[0] = "nguyen van a";
            ds[1] = "nguyen van b";
            ds[2] = "nguyen van c";
            
            Console.WriteLine("{0}\n{1}\n{2}",ds[0], ds[1], ds[2]);
            Console.WriteLine("===========================");
            for (int i= 0; i<=2; i++)
            {
                Console.WriteLine(ds[i]);
            }
            
            int[] mangsonguyen;
            string[] mang1 = new string[2] {"dien thoai", "may tinh"};
            double[] mang2 = {0.1, 0.5, 2.4, 4.9};

            mangsonguyen = new int[3] {1, 2, 0};

            mangsonguyen[0] = 1;
            mangsonguyen[1] = 2;
            mangsonguyen[2] = 0;
            //mangsonguyen[3] = 4;

            int[] numbers = {1, 6, 7, 9, 10, 23, 66, 3, 46, 90};

            //in ra cacs phan tu cua chuoi theo thu tu tang dan chi so mang
            int sophantu = numbers.Length;
            for (int chiso = 0; chiso < sophantu; chiso++)
            {
                Console.WriteLine(numbers[chiso]);
            }
            //in ra so phan tu cua mang theo thu tu giam dan chi so mang
            
            Console.Write("========================================\n");
            for (int chiso = sophantu-1 ; chiso >=0 ; chiso--)
            {
                Console.WriteLine(numbers[chiso]);
            }
            Console.Write("========================================\n");
            
            //use foreach 
            foreach (var a in numbers)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine($"So phan tu: {numbers.Length}");
            Console.WriteLine($"Chieu: {numbers.Rank}");
            Console.WriteLine($"Min: {numbers.Min()}");
            Console.WriteLine($"Max: {numbers.Max()}");
            Console.WriteLine($"Sum: {numbers.Sum()}");

            Array.Sort(numbers);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            
            int[] soluong = {43, 4, 44, 63, 3, 9,};
            Array.Sort(soluong);
            foreach (var item in soluong)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Min so luong: {soluong.Min()}");
            Console.WriteLine($"Max so luong: {soluong.Max()}");
            Console.WriteLine($"So phan tu: {soluong.Length}");
            Console.WriteLine($"Tong cac phan tu: {soluong.Sum()}");

            //Khai bao mang 2 chieu
            double[,] manghaichieu = new double[2, 3] {{4, 6, 5.5}, {3, 6, 9}};

            int hang = 2;
            int cot = 3;

            for (int i = 0; i < hang; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    Console.Write(manghaichieu[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }
}
