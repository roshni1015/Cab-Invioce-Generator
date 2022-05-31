// See https://aka.ms/new-console-template for more information
using CabInvoiceGenerator;

Console.WriteLine("Welcome to Cab Invoice Generator!");
InvoiceGenerator test1 = new();
double fare1 = test1.calculateFare(10, 50);
Console.WriteLine("Total Fare for your Journey is :" + fare1);
