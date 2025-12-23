using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBasseClass
{
    internal class Bake:ONRoad
    {
        public override void Move()
        {
            Console.WriteLine("Ездиет на двух колесахБ может перевозить не более 3 человек");
        }
    }
}
