using System;

namespace Exercise_1_2
{
    public class Application
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person("Jason Smith", new DateTime(1980, 12,03), Gender.MALE);
            Console.WriteLine(person1.Gender);
            Console.WriteLine(person1);
        }
    }
}