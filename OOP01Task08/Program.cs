using Microsoft.VisualBasic;
using System.Diagnostics.Contracts;

namespace OOP01Task08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            //a) What is Abstraction in Object-Oriented Programming?
            // Abstraction is the process of hiding implementation details and showing only the essential features of an object to the user.
            // It focuses on WHAT an object does rather than HOW it does it.

            //b) Why is abstraction considered one of the four pillars of OOP?
            // It is a core pillar because it provides essential architectural benefits:
            // Reduces complexity: Simplifies system interaction by removing unnecessary technical details.
            // Improves maintainability: Allows internal code updates without breaking external code.Enhances security: Protects sensitive implementation logic from exposure.
            // Promotes flexibility and reusability: Enables modular code through abstract interfaces and contracts.

            #endregion

            #region In Main
            // // a. Create a Driver
            // Driver driver = new Driver("Ahmed Mohamed");

            //// b. Create a DeliveryCenter
            //DeliveryCenter center = new DeliveryCenter("Cairo Main Center");

            //// c. Assign the Driver to the DeliveryCenter
            //center.AssignedDriver = driver;

            //// d. Create one StandardShipment
            //DeliveryAddress stdAddress = new DeliveryAddress("Cairo", "Tahrir St", 10);
            //StandardShipment standardShipment = new StandardShipment("SH001", "Laptop", 3.0, 80, stdAddress);

            //// e. Create one ExpressShipment
            //DeliveryAddress expAddress = new DeliveryAddress("Giza", "Pyramids St", 5);
            //ExpressShipment expressShipment = new ExpressShipment(20, "EX002", "Smart Phone", 1.5, 120, expAddress);

            //// f. Create one InternationalShipment
            //DeliveryAddress intAddress = new DeliveryAddress("Riyadh", "King Fahd Rd", 12);
            //InternationalShipment internationalShipment = new InternationalShipment("Saudi Arabia", 50, "IN003", "Document File", 0.5, 200, intAddress);

            //// g. Add all shipments to the DeliveryCenter
            //center.AddShipment(standardShipment);
            //center.AddShipment(expressShipment);
            //center.AddShipment(internationalShipment);

            ////// h. Print all shipments using PrintAllShipments()
            //center.PrintAllShipments();

            //// i. Call DeliveryHelper.PrintShipmentDetails() for each shipment
            //Console.WriteLine("\n--- Printing Using DeliveryHelper... ---");
            //DeliveryHelper.PrintShipmentDetails(standardShipment);
            //DeliveryHelper.PrintShipmentDetails(expressShipment);
            //DeliveryHelper.PrintShipmentDetails(internationalShipment);

            //// j. Demonstrate both versions of UpdateWeight()
            //Console.WriteLine("Updating Weight...\n");
            //Console.WriteLine($"Original Weight : {standardShipment.Weight} KG"); //3

            //standardShipment.UpdateWeight(5.0);
            //Console.WriteLine($"Updated Weight : {standardShipment.Weight} KG");

            //standardShipment.UpdateWeight(5.0, 0.5);
            //Console.WriteLine($"Updated Weight After Packing : {standardShipment.Weight} KG");

            //Console.WriteLine("==============================================");

            //// k. Build a Shipment[] holding mixed types and print all of them in a loop
            //Console.WriteLine("Printing Using Shipment[]...\n");

            //Shipment[] mixedShipments = new Shipment[]
            //{ standardShipment,  expressShipment,internationalShipment };
            //foreach (Shipment shipment in mixedShipments)
            //{
            //    if (shipment is StandardShipment)
            //    {
            //        Console.WriteLine("Standard Shipment...\n");
            //    }
            //    else if (shipment is ExpressShipment)
            //    {
            //        Console.WriteLine("Express Shipment...\n");
            //    }
            //    else if (shipment is InternationalShipment)
            //    {
            //        Console.WriteLine("International Shipment...\n");
            //    }
            //}
            //Console.WriteLine("==============================================");
            #endregion
            Console.WriteLine("test");
            Console.ReadLine();
        }
    }
}
