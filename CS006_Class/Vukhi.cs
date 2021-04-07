using System;
namespace CS006_Class
{
    class Vukhi
    {
        //DU LIEU
        string name = "ten vu khi"; // co nghia la "private string name"
        public string name1 = "ten vu khi";
        int dosatthuong = 0;
        //PHUONG THUC
        //Phuong thuc khoi tao mac dinh
        public Vukhi()
        {
            Console.WriteLine("Khoi tao");
            dosatthuong = 1;
        }

        //Phuong thuc khoi tao co tham so la chuoi
        public Vukhi(string abc)
        {
            Console.WriteLine("Khoi tao");
        }

        public Vukhi(string name, int _dosatthuong)
        {
            dosatthuong = _dosatthuong;
            this.name1 = name;
        }

        public void Thietlapdosatthuong(int dosatthuong)
        {
            this.dosatthuong = dosatthuong;
            Vukhi abc = this; 
        }

        public void Tancong()
        {
            Console.WriteLine(name1);
            for (int i = 0; i<dosatthuong; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        //THUOC TINH
        public int Satthuong
        {
            //khi thiet lap
            //neu khong co set, chi cho phep doc
            set
            {
                dosatthuong = value;
            }
            //khi truy cap
            //neu khong co get, chi cho phep ghi
            get
            {
                return dosatthuong;
            }
        }

        public string Noisanxuat{set; get;}


    }
}