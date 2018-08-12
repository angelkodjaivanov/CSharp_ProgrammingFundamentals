using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _08.Mentor_Group
{
    class Program
    {

        class Student
        {
            public string Name { get; set; }
            public List<DateTime> StudentDates { get; set; }
            public List<string> StudentComments = new List<string>();
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (input != "end of dates")
            {
                List<string> studentProp = input.Split(' ', ',').ToList();
                List<DateTime> parsedDates = new List<DateTime>();
                bool haveName = false;
                int saveIndex = 0;

                for (int i = 1; i < studentProp.Count; i++)
                {
                    parsedDates.Add(DateTime.ParseExact(studentProp[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].Name == studentProp[0])
                    {
                        haveName = true;
                        saveIndex = i;
                    }
                }
                if (haveName)
                {
                    for (int i = 0; i < parsedDates.Count; i++)
                    {
                        students[i].StudentDates.Add(parsedDates[i]);
                    }
                }
                else
                {
                    students.Add(new Student { Name = studentProp[0], StudentDates = parsedDates });
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "end of comments")
            {
                List<string> studentProp = input.Split('-').ToList();
                string comment = studentProp[1];
                string saveName = studentProp[0];

                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].Name == studentProp[0])
                    {
                        students[i].StudentComments.Add(comment);
                    }
                }
                input = Console.ReadLine();

            }

            students = students.OrderBy(p => p.Name).ToList();

            for (int i = 0; i < students.Count; i++)
            {
                students[i].StudentDates = students[i].StudentDates.OrderBy( p => p).ToList();
                Console.WriteLine(students[i].Name);
                Console.WriteLine("Comments:");
                try
                {
                    for (int j = 0; j < students[i].StudentComments.Count; j++)
                    {
                        Console.WriteLine("- " + students[i].StudentComments[j]);
                    }
                }
                catch
                {

                }
                Console.WriteLine("Dates attended:");
                for (int j = 0; j < students[i].StudentDates.Count; j++)
                {
                    Console.WriteLine("-- {0:dd/MM/yyyy}", students[i].StudentDates[j]);
                }
            }

        }
    }
}
