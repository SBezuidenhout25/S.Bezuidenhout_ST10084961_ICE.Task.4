using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjICE4
{
    class items
    {
        private double vat;
        public string itemName
        {
            get; set;

        }
        public double itemPrice
        {
            get; set;
        }

        public double itemVat
        {
            set { vat = value * itemPrice; }
            get { return vat; }
        }

    }
}
