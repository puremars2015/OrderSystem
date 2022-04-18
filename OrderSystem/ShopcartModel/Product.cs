using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopcartModel
{

    public class Product
    {
        private decimal _ItemPrice { get; set; }
        public int ItemNo { get; set; }
        public string ItemName { get; set; }
        public decimal ItemPrice 
        { 
            get 
            {
                return this._ItemPrice.Normalize(); 
            } 
            set
            {
                this._ItemPrice = value;
            }
        }
        public object Img { get; set; }
        public Product(string Name, decimal Price)
        {
            this.ItemName = Name;
            this.ItemPrice = Price;
        }
        public Product(int ItemNo, string Name, decimal Price)
        {
            this.ItemNo = ItemNo;
            this.ItemName = Name;
            this.ItemPrice = Price;
        }
        public Product(Product Product)
        {
            this.Img = Product.Img;
            this.ItemName = Product.ItemName;
            this.ItemNo = Product.ItemNo;
            this.ItemPrice = Product.ItemPrice;
        }
    }
}
