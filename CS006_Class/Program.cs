using System;

namespace CS006_Class
{
    //Phuong thuc huy - chay tu dong
    //khi khong con doi tuong nao tham chieu den 
    //doi tuong nay nua, 
    //giai phong tai nguyen ma no chiem giu.
    class Student:IDisposable
    {
        public string name;
        public Student(string name)
        {
            this.name = name;
            Console.WriteLine("Khoi tao "+ name);
        }

        ~Student() //1 lop chi cos mot phuong thuc huy
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Huy" + name);
            Console.ResetColor();
        }

        public void Dispose()//tu dong thi hanh khi bien ra khoi pham vi, dam bao phai co su dung using
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Huy boi Dispose" + name);
            Console.ResetColor();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vukhi sungluc; //null
            sungluc = new Vukhi();
            
            Vukhi sungtruong = new Vukhi("Xin chao");

            sungluc.name1 = "Sung luc";

            sungluc.Thietlapdosatthuong(5);
            sungluc.Tancong();

            Vukhi sungmay = new Vukhi("Sung may", 15);
            sungmay.Tancong();
            sungluc.Tancong();

            Console.WriteLine(sungluc.Satthuong);
            
            sungluc.Noisanxuat = "My";
            Console.WriteLine(sungluc.Noisanxuat);

            Student student;
            for (int i = 1; i < 100; i++)
            {
                student = new Student("Sinh vien thu " + i);
                student = null;
            }
            using(Student s = new Student("ten sinh vien"))
            {
                //....
            }

            static void testDispose() //doi tuong se bi huy khi ra khoi phuong thuc testDispose
            {
                using Student a = new Student("Nguyen Thi Anh Thu");
            }
        testDispose();

        }
    }
}
