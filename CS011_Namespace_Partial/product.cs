using System;

namespace SanPham
{
    public partial class Product
    {
        public string name {set; get;}

        public decimal price {set; get;}

        public string GetInfo()
        {
            this.description = "Mau ma dep";
            return $"{name} + {price} + {description}";
        } 
    }
}