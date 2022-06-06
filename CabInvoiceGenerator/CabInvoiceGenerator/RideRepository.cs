using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class RideRepository
    {
        Dictionary<string, MultipleRides[]> Dictionary = new Dictionary<string, MultipleRides[]>();
        public RideRepository()
        {
            this.Dictionary = new Dictionary<string, MultipleRides[]>();
        }
        public void AddRides(string userId, MultipleRides[] rides)
        {
            if (!Dictionary.ContainsKey(userId))
            {
                Dictionary.Add(userId, rides);
            }
            else
            {
                Console.WriteLine("Rides are Null");
            }
        }
        public MultipleRides[] GetRideDetails(string userId)
        {
            foreach (var data in Dictionary)
            {
                if (data.Key == userId)
                {
                    Console.WriteLine("User ID is :" + userId);
                    return data.Value;
                }
                else
                {
                    Console.WriteLine("Please Choose Correct User ID");
                }
            }
            return null;
        }
    }
}
