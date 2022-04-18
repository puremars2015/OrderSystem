using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopcartCore
{
    public class CustomerService
    {
        public List<customer> GetCustomers()
        {
            using(ShopcartEntities e = new ShopcartEntities())
            {
                return e.customer.ToList();
            }
        }

        public bool ImportCustomers(List<customer> customers)
        {
            using (ShopcartEntities e = new ShopcartEntities())
            {
                try
                {
                    e.customer.AddRange(customers);
                    e.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool DeleteCustomer(int rowid)
        {
            try
            {
                using (ShopcartEntities e = new ShopcartEntities())
                {
                    var entity = e.customer.Where(x => x.rowid == rowid).First();
                    e.customer.Remove(entity);
                    e.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }       
        }
    }
}
