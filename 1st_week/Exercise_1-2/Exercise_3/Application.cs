using System;
using Exercise_1_2.person;

namespace Exercise_1_2
{
    public class Application
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person("Jason Smith", new DateTime(1980, 12,03), Gender.MALE);
            Console.WriteLine(person1.Gender);
            Console.WriteLine(person1);
            
            Employee emp1 = new Employee(10000, Profession.ELECTRIC_ENGINEER, "Josephine Smith", 
                new DateTime(1990, 10, 20), Gender.FEMALE, new Room(10));
            
            Console.WriteLine(emp1);
        }
    }
}