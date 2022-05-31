using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        public const double Mini_Fare = 5;
        public const double Mini_Cost_Perkm = 10;
        public const int Cost_Per_Time = 1;

        public double calculateFare(double distance, int time)
        {
            double totalFare = distance * Mini_Cost_Perkm + time * Cost_Per_Time;
            if (totalFare < Mini_Fare)
            {
                return Mini_Fare;
            }
            return totalFare;


        }
    }
}
