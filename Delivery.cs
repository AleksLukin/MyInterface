using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterface
{
    class Delivery : Manufacture
    {
        public void DeliveryEquipment()
        {
            ManufactureEquipment();
            Console.WriteLine("Груз доставлен");
        }
    }
}
