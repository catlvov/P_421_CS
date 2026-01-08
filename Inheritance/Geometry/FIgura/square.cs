using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace Geometry.FIgura
{
    internal class Square : Shape
    {
        float side;
        public float Side 
        {
            get => side;
            set => side = FilterSize(value);
        } //длина стороны
        public Square (int startX, int startY,float side, Color colors)  : base (colors)
        { 
            this.Side = side;
        }
        public override double GetArea() => Side* Side;
        public override double GetPerimeter() => Side * 4;
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Colors, LineWidth);
            e.Graphics.DrawRectangle(pen, startX, startY, side, side);
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"{this.GetType()}\nДлина стороны квадрата={Side}");
            base.Info(e);
        }
    }
}
