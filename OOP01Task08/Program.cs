using Microsoft.VisualBasic;
using OOP01Task08.Interface;
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
            DeliveryCenter center = new DeliveryCenter("Cairo Main Center");

            //a. Create one StandardShipment
            DeliveryAddress stdAddress = new DeliveryAddress("Cairo", "Tahrir St", 10);
            StandardShipment standardShipment = new StandardShipment("SH001", "Laptop", 3.0m, 80, stdAddress);

            // b. Create one ExpressShipment
            DeliveryAddress expAddress = new DeliveryAddress("Giza", "Pyramids St", 5);
            ExpressShipment expressShipment = new ExpressShipment(20, "EX002", "Smart Phone", 1.5m, 120, expAddress);

            // c. Create one InternationalShipment
            DeliveryAddress intAddress = new DeliveryAddress("Riyadh", "King Fahd Rd", 12);
            InternationalShipment internationalShipment = new InternationalShipment("Saudi Arabia", 50, "IN003", "Document File", 0.5m, 200, intAddress);

            //// d. Add all shipments to the DeliveryCenter
            center.AddShipment(standardShipment);
            center.AddShipment(expressShipment);
            center.AddShipment(internationalShipment);

            //// e. Print all shipments using PrintAllShipments()
            center.PrintAllShipments();

            // f & h. Print tracking status using ITrackable[] array (covers both requirements cleanly)
            ITrackable[] trackableShipments = new ITrackable[] { standardShipment, expressShipment, internationalShipment };

            Console.WriteLine("Tracking Status");
            foreach (var item in trackableShipments)
            {
                if (item != null)
                {
                    Console.WriteLine(item.GetTrackingStatus());
                }
            }
            Console.WriteLine("--------------------------------------------------");

            // g & i. Print insurance cost using IInsurable[] array (covers both requirements cleanly)
            IInsurable[] insurableShipments = new IInsurable[] { standardShipment, expressShipment, internationalShipment };

            Console.WriteLine("\nInsurance");
            foreach (var item in insurableShipments)
            {
                if (item != null)
                {
                    string shipmentTypeName = item switch
                    {
                        StandardShipment => "Standard Shipment",
                        ExpressShipment => "Express Shipment",
                        InternationalShipment => "International Shipment",
                        _ => "Shipment"
                    };

                    Console.WriteLine($"{shipmentTypeName} Insurance : {item.CalculateInsurance():F2} EGP");
                }
            }
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("\nInterface Polymorphism Demonstrated Successfully.");

            #endregion
            Console.ReadLine();
        }
    }
}
