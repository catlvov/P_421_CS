using Geometry.FIgura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(5, Color.Purple);
            square.Info();

            IntPtr hwnd = GetConsoleWindow(); //получаем окно консоли
            Graphics graphics = Graphics.FromHwnd(hwnd); //создаем объект 'graphics', на котором мы будем рисовать
            Rectangle window_rect = new Rectangle //получаем прямоугольник угла консоли 
                (
                 Console.WindowLeft, Console.WindowTop,
                 Console.WindowHeight , Console.WindowHeight
                );
            PaintEventArgs e = new PaintEventArgs( graphics,window_rect );

            Pen pen = new Pen(Color.Purple, 5);
            e.Graphics.DrawRectangle(pen, 20,150,100,100);
        }
        [DllImport("kernel32.dll")]//подключаем модуль OC windows
        public static extern IntPtr GetConsoleWindow();

    }
}
