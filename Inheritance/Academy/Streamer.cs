using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Streamer
    {
        
        public static void Print(Human[] group)
        {
            const string delimiter = "\n------------------------------------\n";

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
        public static void Save(Human[] group, string filename)
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
        public static Human[] load(string filename)
        {
            List<Human> group = new List<Human>();
            try
            {
                Directory.SetCurrentDirectory("..\\..");
                StreamReader reader = new StreamReader(filename);
                //Factory factory = new Factory();
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
                    group.Add(Factory.create(values[0]).Init(values));

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
