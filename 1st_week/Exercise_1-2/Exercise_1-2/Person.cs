using System;

namespace Exercise_1_2
{
    internal class Person
    {
        string name;
        DateTime birthDate;
        

        public Person(string name, DateTime birthDate)
        {
            this.name = name;
            this.birthDate = birthDate;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public DateTime BirthDate => birthDate;

        public override string ToString()
        {
            return $"Name: {name}, birth: {birthDate}.";
        }
    }
}