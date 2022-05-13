using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjICE4
{
    class BigBox : items
    {
        public double deliveryFee;
        public DateTime endDate { get; set; }
        
        public BigBox (double Delivery, DateTime startDate)
        {
            deliveryFee = Delivery;
            endDate = startDate.AddDays(365);
        }
    }
}
