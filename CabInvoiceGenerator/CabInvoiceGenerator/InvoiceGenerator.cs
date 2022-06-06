using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        public double Mini_Fare = 5;
        public double Mini_Cost_Perkm = 10;
        public int Cost_Per_Time = 1;
        public int count;
        public double calculateFare(double distance, int time)
        {
            count++;
            double totalFare = distance * Mini_Cost_Perkm + time * Cost_Per_Time;
            if (totalFare < Mini_Fare)
            {
                return Mini_Fare;
            }
            return totalFare;
        }
       
        public double calculateFare(MultipleRides[] Ride)
        {
         
            double totalfare = 0;
            foreach (MultipleRides Rides in Ride)
            {
                totalfare = totalfare + calculateFare(Rides.distance, Rides.time);
            }
            return totalfare;
        }
        public void InvoiceSummary(MultipleRides[] Ride)
        {
            foreach (MultipleRides Rides in Ride)
            {
                Console.WriteLine("Distance Travelled by Cab:" + Rides.distance);
                Console.WriteLine("Time Travelled :" + Rides.time);
                Console.WriteLine("Total Fare for Ride is :" + calculateFare(Rides.distance, Rides.time));
                Console.WriteLine("-------------------------------------------");

            }
        }
        public bool? RideType(double distance, int time)
        {
            
            double totalFare = distance * Mini_Cost_Perkm + time * Cost_Per_Time;           
           
        
            if (totalFare >= 20)
            {

                
                Console.WriteLine("Category for Ride is Premium");


            }
            else
            {
                Console.WriteLine("Category for Ride is Normal");


            }
            return null;
            



        }
      
        public void InvoiceSummary1(MultipleRides[] Ride)
        {
            foreach (MultipleRides Rides in Ride)
            {
               
                Console.WriteLine("Distance Travelled by Cab:" + Rides.distance);
                Console.WriteLine("Time Travelled :" + Rides.time);
                Console.WriteLine("Total Fare for Ride is :" + calculateFare(Rides.distance, Rides.time));
                Console.WriteLine(RideType(Rides.distance, Rides.time));
                Console.WriteLine("-------------------------------------------");

            }
        }

    }
}

