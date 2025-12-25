using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Collections.Specialized;

namespace Geometry.FIgura
{
    internal class Square : Shape
    {
        public double Side { get; set; } //длина стороны
        public Square (double side, Color colors)  : base (colors)
        { 
            this.Side = side;
        }
        public override double GetArea() => Side* Side;
        public override double GetPerimeter() => Side * 4;
        public override void Draw()
        {
            Console.WriteLine("Draw DONE");
        }
        public override void Info()
        {
            Console.WriteLine($"{this.GetType()}\nДлина стороны квадрата={Side}");
            base.Info();
        }
    }
}
