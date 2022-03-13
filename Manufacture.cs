using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterface
{
    class Manufacture : Procurement
    {
        public void ManufactureEquipment()
        {
            SupplyMaterials();
            Console.WriteLine("Резка металла выполнена");
            Console.WriteLine("Металлоконструкции собраны и сварены");
            Console.WriteLine("Оборудование испытано, покрашено и упаковано");
        }
    }
}
