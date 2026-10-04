using OOP01Task08;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP01Task08
{
    internal class StandardShipment : Shipment 
    {
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination) { }
        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment\n");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine("--------------------------------------------------");
        }

        public override decimal EstimatedCost 
        {
            get{ return DeliveryFee + (Weight * 5); }
                
        }

    }
}