using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBasseClass
{
    internal class Car:ONRoad
    {
        public override void Move()
        {
            Console.WriteLine("Ездиет на 4 колесах и можеь пировозить людей и грузы");
        }
    }
}
