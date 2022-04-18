using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopcartCore
{
    public class ProductService
    {
        public IList<product> GetProducts()
        {
            using (ShopcartEntities e = new ShopcartEntities())
            {
                return e.product.ToList();
            }
        }
    }
}
