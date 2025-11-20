//#define NUMERIC_TYPES
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	class Program
	{
		static readonly string delimiter = "\n------------------------------------------\n";
		static void Main(string[] args)
		{
#if NUMERIC_TYPES
			Console.WriteLine("DataTypes");

			Console.WriteLine("ЦЕЛОЧИСЛЕННЫЕ ТИПЫ");

			Console.WriteLine("byte");
			Console.WriteLine($"byte занимает {sizeof(byte)} Байт памяти, и принимает значения в диапазоне");
			Console.WriteLine($"Беззнаковый byte от {byte.MinValue} до {byte.MaxValue},\tКласс-обвертка - {typeof(byte)};");
			Console.WriteLine($"   Знаковый byte от {sbyte.MinValue} до {sbyte.MaxValue},Класс-обвертка - {typeof(sbyte)};");
			Console.WriteLine(delimiter);

			Console.WriteLine("short");
			Console.WriteLine($"short занимает {sizeof(short)} Байт памяти, и принимает значения в диапазоне");
			Console.WriteLine($"   Знаковый short от {short.MinValue} до {short.MaxValue},\tКласс-обвертка - {typeof(short)};");
			Console.WriteLine($"Беззнаковый short от {ushort.MinValue} до {ushort.MaxValue},\tКласс-обвертка - {typeof(ushort)};");
			Console.WriteLine(delimiter);

			Console.WriteLine("Integer - Целое число");
			Console.WriteLine($"int занимает {sizeof(int)} Байт памяти, и принимает значения в диапазоне");
			Console.WriteLine($"   Знаковый int от {int.MinValue} до {int.MaxValue},\tКласс-обвертка - {typeof(int)};");
			Console.WriteLine($"Беззнаковый int от {uint.MinValue} до {uint.MaxValue},\t\tКласс-обвертка - {typeof(uint)};");
			Console.WriteLine(delimiter);

			Console.WriteLine("long");
			Console.WriteLine($"long занимает {sizeof(long)} Байт памяти, и принимает значения в диапазоне");
			Console.WriteLine($"   Знаковый long от {long.MinValue} до {long.MaxValue},Класс-обвертка - {typeof(long)};");
			Console.WriteLine($"Беззнаковый long от {ulong.MinValue} до {ulong.MaxValue},\t\t\tКласс-обвертка - {typeof(ulong)};");
			Console.WriteLine(delimiter);

			Console.WriteLine("float");
			Console.WriteLine($"float занимает {sizeof(float)} Байт памяти, и принимает значения в диапазоне");
			Console.WriteLine($"float от {float.MinValue} до {float.MaxValue},\t\t\tКласс-обвертка - {typeof(float)};");
			Console.WriteLine(delimiter);

			Console.WriteLine("double");
			Console.WriteLine($"double занимает {sizeof(double)} Байт памяти, и принимает значения в диапазоне");
			Console.WriteLine($"double от {double.MinValue} до {double.MaxValue},\t\t\tКласс-обвертка - {typeof(double)};");
			Console.WriteLine(delimiter);

			Console.WriteLine("decimal");
			Console.WriteLine($"decimal занимает {sizeof(decimal)} Байт памяти, и принимает значения в диапазоне");
			Console.WriteLine($"decimal от {decimal.MinValue} до {decimal.MaxValue},\t\t\tКласс-обвертка - {typeof(decimal)};");
			Console.WriteLine(delimiter); 
#endif

			int a = 2;
			byte b = (byte)a;
			//(type)value;	//явное преобразование типов
			//Convert
		}
	}
}