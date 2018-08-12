using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Order_by_Age
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Person> persons = new List<Person>();

            while (input!= "End")
            {

                List<string> personProp = input.Split(' ').ToList();

                Person person = new Person
                {
                    Name = personProp[0],
                    ID = personProp[1],
                    Age = int.Parse(personProp[2])
                };

                persons.Add(person);

                input = Console.ReadLine();
            }

            persons = persons.OrderBy(p => p.Age).ToList();

            for (int i = 0; i < persons.Count; i++)
            {
                Console.WriteLine($"{persons[i].Name} with ID: {persons[i].ID} is {persons[i].Age} years old.");
            }
                
            
        }
    }
}
