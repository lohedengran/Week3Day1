using System;

namespace Week3Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            // byt plats på första och sista värdet
            var names = new[] { "Håkan", "Pontus", "Bo" };
            var firstValue = names[0]; // Håkan
            var lastValue = names[names.Length - 1]; // Bo
            names[0] = lastValue;
            names[names.Length - 1] = firstValue;

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Person p = new Person();
            p.Name = "Bo";
            Console.WriteLine(p.Name);
        }
    }

    class Person
    {
        public Person(string name)
        {
            Name = name; //set
        }
        public string Name { get;  set; }


    }
}
