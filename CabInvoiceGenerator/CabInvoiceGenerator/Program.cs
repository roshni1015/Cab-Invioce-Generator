// See https://aka.ms/new-console-template for more information
using CabInvoiceGenerator;

while (true)
{
    Console.WriteLine("Please choose the option :\n1)Calculating Fare\n2)Calculating Aggregate for Multiple Rides\n3)Enhanced Invoice\n4)Invoice Service\n5)Category for Rides");
    int option = Convert.ToInt16(Console.ReadLine());
    string RideType = null;
    switch (option)
    {
        case 1:
            InvoiceGenerator test1 = new();
            double fare1 = test1.calculateFare(10, 50);
            Console.WriteLine("Total Fare for your Journey is :" + fare1);
            Console.WriteLine();
            Console.WriteLine("********************************************************************");
            break;
        case 2:
            InvoiceGenerator test2 = new();
            MultipleRides[] Rides = { new MultipleRides(10, 40), new MultipleRides(20, 50), new MultipleRides(40, 60), new MultipleRides(50, 90) };
            double totalfare = test2.calculateFare(Rides);
            Console.WriteLine("Total Aggregate :" + totalfare);
            Console.WriteLine();
            Console.WriteLine("********************************************************************");
            break;
        case 3:
            InvoiceGenerator test3 = new();
            MultipleRides[] Rides1 = { new MultipleRides(10, 40), new MultipleRides(20, 50), new MultipleRides(40, 60), new MultipleRides(50, 90) };
            double totalFare = test3.calculateFare(Rides1);
            int numOfRides = test3.count;
            double average = totalFare / numOfRides;
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Total Number of Rides : " + numOfRides);
            Console.WriteLine("Total Aggregate :" + totalFare);
            Console.WriteLine("Average of all the Rides :" + average);
            Console.WriteLine();
            Console.WriteLine("********************************************************************");
            break;
        case 4:
            InvoiceGenerator test4 = new();
            Console.WriteLine("Enter the User Id :");
            string UserId = Console.ReadLine();
            MultipleRides[] rides2 = { new MultipleRides(10, 40), new MultipleRides(20, 50), new MultipleRides(40, 20), new MultipleRides(50, 10) };
            double totalFare1 = test4.calculateFare(rides2);
            int numOfRides1 = test4.count;
            double average1 = totalFare1 / numOfRides1;
            RideRepository ride1 = new();
            ride1.AddRides(UserId, rides2);
            Console.WriteLine("********************************************************************");
            MultipleRides[] ride3 = ride1.GetRideDetails(UserId);
            Console.WriteLine("Total Number of Rides : " + numOfRides1);
            Console.WriteLine("-------------------------------------------");
            test4.InvoiceSummary(rides2);
            Console.WriteLine("Total Aggregate :" + totalFare1);
            Console.WriteLine("Average of all the Rides :" + average1);
            Console.WriteLine();
            Console.WriteLine("********************************************************************");
            break;
        case 5:
            InvoiceGenerator test5 = new();
            Console.WriteLine("Enter the User Id :");
            string UserID = Console.ReadLine();
            MultipleRides[] rides = {new MultipleRides(1,5), new MultipleRides(20, 50), new MultipleRides(40, 20), new MultipleRides(50, 10) };
            double totalFare2 = test5.calculateFare(rides);
            int numOfRides2 = test5.count;
            double average2 = totalFare2 / numOfRides2;
            RideRepository ride = new();
            ride.AddRides(UserID, rides);
            Console.WriteLine("********************************************************************");
            MultipleRides[] Ride = ride.GetRideDetails(UserID);
            Console.WriteLine("Total Number of Rides : " + numOfRides2);
            Console.WriteLine("-------------------------------------------");
            test5.InvoiceSummary1(rides);
            Console.WriteLine("Total Aggregate :" + totalFare2);
            Console.WriteLine("Average of all the Rides :" + average2);
            Console.WriteLine();
            Console.WriteLine("********************************************************************");
            break;
        default:
            Console.WriteLine("Please choose the correct option!");
            break;
    }
}