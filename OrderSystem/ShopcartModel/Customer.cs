using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopcartModel
{
    public class Customer
    {
        public int rowid { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string text 
        {
            get 
            {
                return $"{name}     {phone}";
            }    
        }
    }
}
