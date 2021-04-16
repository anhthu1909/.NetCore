using System;
using System.IO;

namespace CS008_Struct
{
    class Program
    {
        //Struct kieu tham tri, kieu du lieu class kieu tham chieu
        //Kieu tham tri la kieu so nguyen, boolean, ... day la nhung kieu du lieu luu tru gia tri cua no o bo nho stack
        //Kieu tham chieu doi tuong class tao ra luu tru o bo nho Heap, day la bo nho lon, luu tru cac cau truc du lieu phuc tap, kich thuoc lon
        public struct Product
        {
            //du lieu
            public string name;
            public double price;

            //thuoc tinh
            public string Info
            {
                get
                {
                    return $"Ten {name}, gia {price}";
                }
            }

            //phuong thuc
            public string GetInfo()
            {
                return $"Ten san pham {name}, gia {price}";
            }

            //constructor
            //phuong thuc tao trong struct khac voi trong Class, da su dung phuong thuc tao thi tat ca cac truong du lieu phai thiet lap gia tri trong phuong thuc tao do
            public Product(string _name, double _price)
            {
                name = _name;
                this.price = _price;
            }

        }   
        /////////////////////Kieu liet ke Enum/////////////////////////
        /*
        0 - Kem
        1 - Trung binh
        2 - Kha
        3 - Gioi
        */
        enum HOCLUC
        {
            kem = 10,
            trungbinh = 23,
            kha = 30,
            gioi = 45
        }    
        static void Main(string[] args)
        {
            //struct khong can khoi tao doi tuong ssau khi khai bao bien
            Product sanpham1;
            sanpham1.name = "Iphone";
            sanpham1.price = 1000;

            //khi su dung den phuong thuc khoi tao thi phai su dung den tu khoa new
            Product sanpham2 = new Product("Nokia", 990); 
            //trong cac phep gan hay truyen du lieu tham so cua cac phuong thuc thi no sao chep ve gia tri chu khong tham chieu doi tuong
            sanpham2 = sanpham1;
            sanpham2.name = "Iphone X";

            Console.WriteLine(sanpham1.GetInfo());
            Console.WriteLine(sanpham2.GetInfo());
            Console.WriteLine(sanpham2.Info);

            ////////////////Kieu liet ke Enum////////////////

            HOCLUC hocluc;
            hocluc = HOCLUC.kem;

            int so = (int)hocluc;
            Console.WriteLine(so);
            hocluc = (HOCLUC)23;
            
            switch(hocluc)
            {
                case HOCLUC.kem:
                Console.WriteLine("Hoc luc Kem");
                break;
                case HOCLUC.trungbinh:
                Console.WriteLine("Hoc luc Trung binh");
                break;
                case HOCLUC.kha:
                Console.WriteLine("Hoc luc Kha");
                break;
                case HOCLUC.gioi:
                Console.WriteLine("Hoc luc Gioi");
                break;
            }

            // int hocluc;
            // hocluc = 3;

            // switch(hocluc)
            // {
            //     case 0:
            //     Console.WriteLine("Hoc luc Kem");
            //     break;
            //     case 1:
            //     Console.WriteLine("Hoc luc Trung binh");
            //     break;
            //     case 2:
            //     Console.WriteLine("Hoc luc Kha");
            //     break;
            //     case 3:
            //     Console.WriteLine("Hoc luc Gioi");
            //     break;
            // }

            // if(hocluc == 0)
            // {
            //     Console.WriteLine("Hoc luc Kem");
            // }else if(hocluc == 1)
            // {
            //     Console.WriteLine("Hoc luc Trung binh");
            // }else if (hocluc == 2)
            // {
            //     Console.WriteLine("Hoc luc Kha");
            // }else
            // {
            //     Console.WriteLine("Hoc luc Gioi");
            // }
        }
    }
}


