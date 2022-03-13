
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
        public void Create() //разработка КД
        {
            Console.WriteLine("КД разработана!");
        
        }
        public void Agree() //согласование КД
        {
            Create();
            Console.WriteLine("КД направлена на согласование");
            bool agreeDocumentation = true;

            if (agreeDocumentation)
            {
                Console.WriteLine("КД согласована");
            }
            else
            {
                Console.WriteLine("КД не согласована");
            }
        }
        
    }
    class Procurement
    {
        //тендерные процедуры
        //подписание спецификаций
        //поставка материалов
    }
    class Manufacture
    {
        //заготовительное производство
        //сборка
        //сварка
        //испытания
        //упаковка
        //сдача иинспектору
    }
    class Delivery
    {
        //выбор перевозчика
        //погрузка
        //доставка
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Documentation documentation = new();
            documentation.Agree();

        }
    }
}
