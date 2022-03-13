using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterface
{
    class Procurement : Documentation
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
}
