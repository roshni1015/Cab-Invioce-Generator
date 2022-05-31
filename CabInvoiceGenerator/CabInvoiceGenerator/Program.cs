// See https://aka.ms/new-console-template for more information
using CabInvoiceGenerator;

while (true)
{
    Console.WriteLine("Please choose the option :\n1)Calculating Fare\n2)Calculating Aggregate for Multiple Rides\n3)Enhanced Invoice");
    int option = Convert.ToInt16(Console.ReadLine());
    switch (option)
    {
        case 1:
            InvoiceGenerator test1 = new();
            double fare1 = test1.calculateFare(10, 50);
            Console.WriteLine("Total Fare for your Journey is :" + fare1);
            Console.WriteLine();
            Console.WriteLine("***************************************************************");
            break;
        case 2:
            InvoiceGenerator test2 = new();
            MultipleRides[] Rides = { new MultipleRides(10, 40), new MultipleRides(20, 50) };
            double totalfare = test2.calculateFare(Rides);
            Console.WriteLine("Total Aggregate :" + totalfare);
            Console.WriteLine();
            Console.WriteLine("****************************************************************");
            break;
        case 3:
            InvoiceGenerator test3 = new();
            MultipleRides[] Rides1 = { new MultipleRides(10, 40), new MultipleRides(20, 50) };
            double totalFare = test3.calculateFare(Rides1);
            int numOfRides = test3.count;
            double avg = totalFare / numOfRides;
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Total Number of rides : " + numOfRides);
            Console.WriteLine("Total Aggregate :" + totalFare);
            Console.WriteLine("Average of all the rides :" + avg);
            Console.WriteLine();
            Console.WriteLine("****************************************************************");
            break;
        default:
            Console.WriteLine("Please choose the correct option!");
            break;
    }
}