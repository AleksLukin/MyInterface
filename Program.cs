
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterface
{
    class Documentation
    {
        protected int createDocDay { get; set; } //срок разработки КД
        protected int checkDocDay { get; set; } //срок согласования КД

        public void Create() //разработка КД
        {
            createDocDay = 20;
            if (createDocDay==20)
            {
                Console.WriteLine("КД разработана!");
            }
                          
        }
        public void Agree() //согласование КД
        {
            Create();
            Console.WriteLine("КД направлена на согласование");
            bool agreeDocumentation = true;

            checkDocDay = 5;
            if (checkDocDay==5)
            {
                if (agreeDocumentation)
                {
                    Console.WriteLine("КД согласована!");
                }
                else
                {
                    Console.WriteLine("КД не согласована");
                }
            }
        }        
    }
    class Procurement:Documentation
    {
        protected bool takeTenders { get; set; }
        protected bool getSpecifications { get; set; }
        protected bool supply { get; set; }
        public void Tenders() //тендерные процедуры
        {
            Agree();
            if (!takeTenders)
            {
                Console.WriteLine("Торги состоялись!");
            }
            else
            {
                Console.WriteLine("Требуются повторные торги");
            }
            
        }
        public void Specifications() //подписание спецификаций
        {
            Tenders();
            if (!getSpecifications)
            {
                Console.WriteLine("Спецификации согласованы!");
            }
            else
            {
                Console.WriteLine("Требуется протокол разногласий");
            }
        }
        public void SupplyMaterials() //поставка материалов
        {
            Specifications();
            if (!supply)
            {
                Console.WriteLine("Поставка материалов выполнена!");
            }
            else
            {
                Console.WriteLine("Материалы в срок не поставлены");
            }
        }        
    }
    class Manufacture:Procurement
    {
        public void ManufactureEquipment()
        {
            SupplyMaterials();
            Console.WriteLine("Резка металла выполнена");
            Console.WriteLine("Металлоконструкции собраны и сварены");
            Console.WriteLine("Оборудование испытано, покрашено и упаковано");
        }
    }
    class Delivery : Manufacture
    {
        public void DeliveryEquipment()
        {
            ManufactureEquipment();
            Console.WriteLine("Груз доставлен");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Delivery delivery = new();
            delivery.DeliveryEquipment();

        }
    }
}
