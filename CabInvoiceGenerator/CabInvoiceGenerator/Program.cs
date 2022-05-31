// See https://aka.ms/new-console-template for more information
using CabInvoiceGenerator;

while (true)
{
    Console.WriteLine("Please choose the option :\n1)Calculating Fare\n2)Calculating Aggregate for Multiple Rides");
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
        default:
            Console.WriteLine("Please choose the correct option!");
            break;
    }
}