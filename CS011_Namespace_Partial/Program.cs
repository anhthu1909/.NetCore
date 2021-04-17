using System;
using MyNameSpace;
using MyNameSpace.Abc;
using SanPham;

namespace CS011_Namespace_Partial
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyNameSpace.Class1.XinChao();
            Class1.XinChao();
            //MyNameSpace.Abc.Class2.XinChao2();
            Class2.XinChao2();
            
            Product p = new Product();
            p.name = "SamSungA50";
            p.price = 1000;

            p.m = new SanPham.Product.Manufactory();
            p.m.name = "Nha may SamSung";
            p.m.address = "TPHCM";

            Console.WriteLine(p.GetInfo());
            Console.WriteLine(p.m.GetInfo());
        }
    }
}
