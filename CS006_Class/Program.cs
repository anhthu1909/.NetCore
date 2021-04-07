using System;

namespace CS006_Class
{
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
        }
    }
}
