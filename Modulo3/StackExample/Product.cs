using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExample
{
    public class Product
    {
        public string Brand { get; set; } //property
        public long BarCode { get; set; }
        public double Price { get; set; }
        public TypeOfProduct TypeOfProduct { get; set; }

        public Product(string brand, long barcode, double price, TypeOfProduct typeOfProduct)
        {
            Brand = brand;
            BarCode = barcode;
            Price = price;
            TypeOfProduct = typeOfProduct;
        }
        
    }
}
