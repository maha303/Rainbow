using System;
using System.IO;

namespace exo11
{
    class Teacher
    {
        private int Id;
        private string Name, Class, Section;

        public Teacher(int id, string name, string cLass , string section)
        {
            this.Id = id;
            this.Name = name;
            this.Class = cLass;
            this.Section = section;
        }

        const string filename = "teacherData.txt";
        public void AddData() 
        {
            StreamWriter sw = new StreamWriter(filename, true);
            sw.WriteLine($"The teacher id is {Id} , Name {Name}, class {Class} and section {Section} ");
            sw.Close();
        }

        static void ReadData() 
        {
            Console.WriteLine("Teacher list : ");
            StreamReader sr = new StreamReader(filename);
            string s = sr.ReadToEnd();
            Console.WriteLine(s);
            sr.Close();
        }

        static void Update() 
        {
            StreamReader reader = new StreamReader(filename);
            string fileContent = reader.ReadToEnd();
            reader.Close();
            Console.WriteLine("Enter the word to update :");
            var w1 = Console.ReadLine();
            Console.WriteLine("Enter the new word :");
            var w2 = Console.ReadLine();
            fileContent = fileContent.Replace(w1, w2);
            StreamWriter writer = new StreamWriter(filename);
            writer.Write(fileContent);
            Console.WriteLine("Updated successfully.............");
            writer.Close();
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Rinbow school system " +
                    " \n Enter 's' to store teacher data " +
                    " \n Enter 'r' to retrieve teacher data" +
                    " \n Enter 'u' to update teacher data ");

                string enter = Console.ReadLine();
                if (enter == "s")
                {
                    Console.WriteLine("How many teacher do you want to enter : ");
                    int w = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= w; i++)
                    {

                        Console.WriteLine("Enter teacher Id : ");
                        int Id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter teacher Name : ");
                        string Name = Console.ReadLine();

                        Console.WriteLine("Enter teacher Class : ");
                        string Class = Console.ReadLine();

                        Console.WriteLine("Enter teacher Section : ");
                        string Section = Console.ReadLine();

                        Teacher t = new Teacher(Id, Name, Class, Section);

                        t.AddData();
                    }

                }
                else if (enter == "r")
                {
                    ReadData();
                    Console.ReadLine();
                }
                else if (enter == "u")
                {
                    Update();
                }

                Console.WriteLine("///////Thanks for using the system//////");

            }

        }
       
    }
}

