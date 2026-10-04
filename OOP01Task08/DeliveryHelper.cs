using System;
using System.Collections.Generic;
using System.Text;

namespace OOP01Task08
{
    static class DeliveryHelper 
    {
        public static void PrintShipmentDetails(Shipment shipment)
        {
            if (shipment != null)
            {
                shipment.PrintShipment();
            }
        }
    }
}
