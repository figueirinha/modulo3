using System;
using System.Collections.Generic;
using System.Text;

namespace QueueExample
{
    public class Facturation
    {
        public string Name { get; set; }
        public long ClientNumber { get; set; }
        public double AmountToPay { get; set; }
        public string ProductSold { get; set; }

        public Facturation(string name, long clientNumber, double amountToPay, string productSold)
        {
            Name = name;
            ClientNumber = clientNumber;
            AmountToPay = amountToPay;
            ProductSold = productSold;
        }
    }
}
