using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopcartCore
{
    public class OrderService
    {
        public bool InsertOrder(List<sale_detail> order, customer customer)
        {
            try
            {
                using (ShopcartEntities e = new ShopcartEntities())
                {
                    using (var trans = e.Database.BeginTransaction())
                    {
                        var theOrder = e.sale.Add(new sale() { order_time = DateTime.Now, customer_rowid = customer.rowid });
                        e.SaveChanges();

                        var saleTicket = e.sale.Where(x => x.customer_rowid == customer.rowid).OrderByDescending(x => x.order_time).First();
                        
                        var o = order.Select(x => {
                            x.sale_rowid = theOrder.rowid;
                            return x;
                        });
                        e.sale_detail.AddRange(o);
                        e.SaveChanges();
                        trans.Commit();
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
