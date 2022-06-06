using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class MultipleRides
    {
        public double distance;
        public int time;
        public MultipleRides(double distance, int time)
        {
            this.distance = distance;
            this.time = time;
        }
    }
}
