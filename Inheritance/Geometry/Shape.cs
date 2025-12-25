using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Geometry
{
    abstract class Shape
    {
        public Color Colors { get; set; }
        public Shape(Color colors) { Colors = colors; }
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public abstract void Draw();
        public virtual void Info()
        {
            Console.WriteLine($"Площадь фигуры ={GetArea()}\nПериметр фигуры ={GetPerimeter()}");
            Draw();
        }
    }
}
