using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Invoice:IPayable
    {
        private int quantity;
        private double priceperitem;
        public string PartNumber { get; set; }
        public string PartDescription { get; set; }
        public int Quantity
        {
            set
            {
                quantity = value;
            }
            get
            {
                return quantity;
            }
        }
        public double PricePerItem
        {
            set
            {
                priceperitem = value;
            }
            get
            {
                return priceperitem;
            }
        }
        public double GetPaymentAmount()
        {
            return Quantity * PricePerItem;
        }
        public Invoice(string no,string description,int count,double price)
        {
            Quantity = count;
            PricePerItem = price;
            PartNumber = no;
            PartDescription = description;
        }
        public override string ToString()
        {
            return "\nInvoice\nPartnumber: " + PartNumber + "(" + PartDescription + ")" + "\nQuantity: " + Quantity + "\nPrice per item: " + PricePerItem;
        }
    }
}
