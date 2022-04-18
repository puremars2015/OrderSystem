using ShopcartModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopcartDesktop
{
    public class ProductButton : Button
    {
        public ProductButton(Product Product):base()
        {
            this.Product = Product;
            this.ItemName = Product.ItemName;
        }

        public Product Product { get; set; }

        /// <summary>
        /// 設定對應產品Key值
        /// </summary>
        public int ItemNo 
        {
            get
            {
                return this.Product.ItemNo;
            }
        }

        /// <summary>
        /// 產品名稱
        /// </summary>
        public string ItemName
        {
            get
            {
                return this.Text;
            }
            set
            {
                this.Text = value;
            }
        }

        /// <summary>
        /// 產品價錢
        /// </summary>
        public int ItemPrice { get; set; }
    }
}
