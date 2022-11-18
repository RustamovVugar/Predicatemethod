using Homeworktask1.Models;
using System;
using System.Collections.Generic;

namespace Homeworktask1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { Name = "Eli", Surname = "Eliyev", Addres = "Xirdalan", Salary = 1503 });
            people.Add(new Person { Name = "Hesen", Surname = "Nuruyev", Addres = "Sumqayit", Salary = 800 });
            people.Add(new Person { Name = "Anar", Surname = "Ceferov", Addres = "Masazir", Salary = 2678 });

            var result = people.FindAll(m => m.Salary > 1000);
            foreach (var person in result)
            {
                Console.WriteLine($"{person.Name} - {person.Surname} - {person.Addres}");
            }
        }
    }
}
