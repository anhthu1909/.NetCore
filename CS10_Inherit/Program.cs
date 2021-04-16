using System;

namespace CS10_Inherit
{
    //tinh ke thua
    //b ke thua A
    //A, lop cha, co so
    //B, lop con, lop ke thua
    /*
        khai bao

        class B:A
        {

        }

        Animal
            -Legs
            -Weight
            -ShowLegs()
        Cat : Animal

       private _ khong truy cap duoc tu lop khac
       protected _ chi truy cap duco tu lop ke thua, khong truy cap duoc tu lop khac
       sealed (niem phong) _ khong cho bat ki lop nao ke thua no

       Tao phuong thuc giong phuong thuc trong class cha thi them tu khoa new

    */
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Khoi tao Animal");
        }

        public Animal(string name)
        {
            Console.WriteLine($"Khoi tao {name}");
        }

        public int Legs{set; get;}

        public float Weight{set; get;}

        public void ShowLegs()
        {
            Console.WriteLine($"Legs: {Legs}");
        }

    }    
    class Cat : Animal
    {
        public string Food;
        //base(s): ham khoi tao co doi so o phuong thuc cha duoc goi, base(): goi ham khoi tao khong doi so o phuong thuc cha
        public Cat(string s) : base(s) 
        {
            this.Legs = 4;
            this.Food = "Mouse";
            Console.WriteLine("Khoi tao lop Cat");
        }
        public void Eat()
        {
            Console.WriteLine(Food);
        }

        public new void ShowLegs() // trung ten phuong thuc trong lop cha, them tu khoa new 
        {
            Console.WriteLine($"Loai meo co: {Legs}");       
        }

        public void ShowInfo()
        {
            base.ShowLegs();
            ShowLegs();
        }
        
    }

//*********************Truyenkieu************************************

    class A{} 

    class B : A{}

    class D : B{}
    // A->B->C
    
    class Program
    {
        static void Main(string[] args)
        {
            
            Cat c = new Cat("ABCXYZ");
            
            // c.ShowLegs();

            // c.Eat();

            // c.ShowInfo();

            A a;
            B b = new B();
            D d = new D();

            a = new B();
            a = new D();
            b = d;
            b = a; //loi
            d = b; //loi
            d = a; //loi
            
        }
    }
}