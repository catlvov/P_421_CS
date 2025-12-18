//#define INHERITANCE_1
//#define INHERITANCE_2
//#difune POLYMORPHISM
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Academy
{
    class Program
    {
        const string delimiter = "\n------------------------------------\n";
        static void Main(string[] args)
        {
#if INHERITANCE_1
			Human human = new Human("Blackmore", "Ritchie", 32);
			human.Info();
			Console.WriteLine(delimiter);

			AcademyMember am = new AcademyMember("Dirkscheider", "Udo", 55, "Vocals");
			am.Info();
			Console.WriteLine(delimiter);

			Student student = new Student("Львов", "Константин", 16, "РПО", "P_421", 98, 100);
			student.Info();

			Teacher teacher = new Teacher("Henriksson", "Martin", 35, "Guitars", 15);
			teacher.Info();

			Graduate graduate = new Graduate("Чухарев", "Матвей", 16, "РПО", "P_421", 90, 95, "Разработка приложения для службы международной доставки");
			graduate.Info(); 
#endif

#if INHERITANCE_2
			Human human = new Human("Чухаоев", "Матвей", 16);
			human.Info();
			Console.WriteLine(delimiter);

			AcademyMember academyMember = new AcademyMember(human, "РПО");
			academyMember.Info();
			Console.WriteLine(delimiter);

			Student student = new Student(academyMember, "P_421", 90, 95);
			student.Info();
			Console.WriteLine(delimiter);

			Graduate graduate = new Graduate(student, "Разработка приложения для службы международной доставки");
			graduate.Info(); 
#endif
#if POLYMORPHISM
			//Polymorphism
			//1) Base class pointers;
			//Upcast - преобразование объекта к базовому типу
			Human[] group =
			{
				new Student("Гусев", "Савелий", 15, "РПО", "P_421", 90, 95),
				new Teacher("Hoffman", "Wolf", 35, "Guitars", 15),
				new Graduate("Чухарев", "Матвей", 16, "РПО", "P_421", 95, 97, "Разработка приложения для службы междунарожной доставки"),
                new Specialist("Львов", "Константин", 16, "РПО", "P_421", 100, 100, "фаловый менеджер", 13),
                new Teacher("Henriksson", "Martin", 32, "Bass guitar", 12),
				new Student("Абдрашитов", "Булат", 16, "РПО", "P_421", 98, 99)
			};

			Print(group);

			Save(group, "P_421.csv");

			load("P_421");
		
#endif
            Console.WriteLine(nameof(Student));
            Human[] group = load("P_421.csv");
            Print(group);
            Console.WriteLine("end");
        }
        static void Print(Human[] group)
        {
            Console.WriteLine(delimiter);
            //2) Virtual methods;
            //Позволяют уточнить информацию о объекте без выполнения Downcast
            //virtual	override
            for (int i = 0; i < group.Length; i++)
            {
                //group[i].Info();
                Console.WriteLine(group[i]);
            }
            Console.WriteLine(delimiter);
        }
        static void Save(Human[] group, string filename)
        {
            Directory.SetCurrentDirectory("..\\..");

            Console.WriteLine(Directory.GetCurrentDirectory());

            StreamWriter writer = new StreamWriter(filename); //поток автомотически открываеться при создании

            //2) выпоняем апесь в поток
            for (int i = 0; i < group.Length; i++)
            {
                writer.WriteLine(group[i].ToFileString() + ";");
            }

            //1.1) потоки обезательно надо закрывать 
            writer.Close();

            Process.Start("notepad", filename);
        }
        static Human[] load(string filename)
        {
            List<Human> group = new List<Human>();
            try
            {
                Directory.SetCurrentDirectory("..\\..");
                StreamReader reader = new StreamReader(filename);
                Factory factory = new Factory();
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    //Console.WriteLine(line);
                    String[] values = line.Split(";,:".ToCharArray());
                    for (int i = 0; i < values.Length; i++)
                    {
                        Console.Write($"{values[i]}\t");
                    }
                    //десерализация это превращения сплошного потока даных например строки в объект .
                    group.Add(factory.create(values[0]).Init(values));

                    Console.WriteLine();
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            return group.ToArray();
        }
    }
}
