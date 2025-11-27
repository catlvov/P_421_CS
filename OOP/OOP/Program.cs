using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	class Program
	{
		static void Main(string[] args)
		{
			Point A = new Point();
			//A.SetX(2);
			//A.SetY(3);
			A.X = 22;	//Свойства позволяют использовать инкапсуляцию как обычные переменные в классе.
			A.Y = 33;
			//Console.WriteLine($"{A.GetX()}\t{A.GetY()}");
			//Assignment - Присваивание
			//Unassigned - неприсвоенный
			A.Print();
		}
	}
}
