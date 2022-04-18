using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopcartModel
{
    public class OrderedProduct : Product
    {
        public SugerLevel SugerLevel { get; set; }
        public IceLevel IceLevel { get; set; }
        public int ItemQuantity { get; set; }
        public decimal TotalPrice
        {
            get
            {
                return ItemQuantity * ItemPrice;
            }
        }
        public string NameWithQuantity
        {
            get
            {
                return $"{this.ItemName}       {ItemQuantity}杯";
            }
        }

        public OrderedProduct(SugerLevel SugerLevel, IceLevel IceLevel, Product Product):base(Product)
        {
            this.SugerLevel = SugerLevel;
            this.IceLevel = IceLevel;
            this.ItemQuantity = 1;
        }

    }
}
