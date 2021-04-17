namespace SanPham{
    public partial class Product
    {
        public Manufactory m {set; get;}
        public class Manufactory
        {
            public string name {set; get;}
            public string address {set; get;}

            public string GetInfo()
            {
                return $"{name} + {address}";
            }
        }
        public string description {set; get;}

        public void Abc()
        {
            this.name = name;
        }
    }
}