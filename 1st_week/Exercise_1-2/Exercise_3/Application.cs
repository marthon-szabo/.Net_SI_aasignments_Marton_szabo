using System;
using Exercise_1_2.person;

namespace Exercise_1_2
{
    public class Application
    {
        public static void Main(string[] args)
        {
            Employee emp1 = new Employee(Profession.ELECTRIC_ENGINEER, "Josephine Smith", 
                new DateTime(1990, 10, 20), Gender.MALE);
            emp1.Room = new Room(10);
            Employee emp1Clone = (Employee) emp1.Clone();
            Console.WriteLine(emp1Clone);
        }
    }
}