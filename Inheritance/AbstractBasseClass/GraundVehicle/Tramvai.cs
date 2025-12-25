using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBasseClass
{
    internal class Tramvai: OnRail
    {
        public override void Move()
        {
            Console.WriteLine("Ездиет по рельсам пировозить людей");
        }
    }
}
