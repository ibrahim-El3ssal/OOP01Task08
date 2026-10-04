using OOP01Task08;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP01Task08
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination) { }
        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment\n");
            base.PrintShipment();
        }

        public override decimal EstimatedCost => base.EstimatedCost;
    }
}