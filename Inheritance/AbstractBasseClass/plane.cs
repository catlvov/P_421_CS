using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBasseClass
{
    internal class plane:AirVehicle
    {
        public override void Move()
        {
            Console.WriteLine("Перевозка грузов и людей на Большие дистанции с высокой скоростью");
        }
    }
}
