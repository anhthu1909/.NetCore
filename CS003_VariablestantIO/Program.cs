using System;

namespace CS003_VariablestantIO
{
    class Program
    {
        static void Main(string[] args)
        {
           int number=12;
           if ((number % 2)==0) 
                Console.WriteLine($"{number} la so chan");
        
            var a = 2;
            var b = 3.5;
            var c = 2;
            var max = a>=b ? a>=c ? a:c:b >= c ?b:c;
            Console.WriteLine($"{max}");

            int num = 2;
            switch(num)
            {
                case 1:
                Console.WriteLine("num co gia tri la mot");
                break;
                case 2:
                Console.WriteLine("num co gia tri la hai");
                break;
                default:
                Console.WriteLine("num co gia tri la mot va hai");
                break;
            }
                
            int so1 = 10;
            while(so1 <= 9)
            {
                Console.WriteLine("so 1: " + so1);
                so1++;
            }

            do
            {
                Console.WriteLine("so 2:" + so1);
            }
            while(so1 < 9);
        }
 
    }
}
