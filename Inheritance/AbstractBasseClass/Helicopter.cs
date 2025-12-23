using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBasseClass
{
    internal class Helicopter:AirVehicle
    {
        public override void Move()
        {
            Console.WriteLine("Перевозка грузов и людей на средние и близкие растояния с хорошей моневренастью и уникальными свойсвами");
        }
    }
}
