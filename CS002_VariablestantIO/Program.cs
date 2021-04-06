using System;

namespace CS002_VariablestantIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName;
            string address = "Ha Noi, Viet Nam";

            int studentAge;
            studentAge = 22;

            double so_pi = 3.14;
            Console.WriteLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Xin chao - Chuong trinh nhap xuat du lieu");
            Console.ResetColor();

            Console.WriteLine("Gia tri so pi la: ");
            Console.Write(so_pi);
            Console.WriteLine();

            int a = 123;
            double b = 5671.123;
            Console.WriteLine($"Bien a = {a}, bien b = {b} - tich la {a * b}");
            
            char username;
            Console.Write("Nhap userrname:");
            username = Console.ReadKey().KeyChar;
            Console.WriteLine($"Ten nhap vao la : {username}");

            Console.Write("Nhap mot so thuc:");
            double input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"So da nhap la:{input}");
            var bien1 = 3.3;
            var bien2 = 3;
            var bien3 = "Bien khai bao voi var";
            var bien4 = (5<4);

            const string Mon = "Thu hai";
            Console.WriteLine(Mon);
        }
    }

}
