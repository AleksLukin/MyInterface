using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterface
{
    class Documentation
    {
        protected int createDocDay { get; set; } //срок разработки КД
        protected int checkDocDay { get; set; } //срок согласования КД

        public virtual void Create() //разработка КД
        {
            createDocDay = 20;
            if (createDocDay == 20)
            {
                Console.WriteLine("КД разработана!");
            }

        }
        public virtual void Agree() //согласование КД
        {
            Create();
            Console.WriteLine("КД направлена на согласование");
            bool agreeDocumentation = true;

            checkDocDay = 5;
            if (checkDocDay == 5)
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
}
