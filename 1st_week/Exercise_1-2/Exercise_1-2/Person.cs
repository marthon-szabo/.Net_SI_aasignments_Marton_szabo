using System;

namespace Exercise_1_2.person
{
    internal class Person
    {
        protected string name;
        protected DateTime birthDate;
        protected Gender gender;
        

        public Person(string name, DateTime birthDate, Gender gender)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.gender = gender;
            
        }

        

        public string Name
        {
            get => name;
            set => name = value;
        }

        public Gender Gender { get; }

        public DateTime BirthDate => birthDate;

        public Employee Employee { get; }

        public override string ToString()
        {
            return $"Person: [Name: {name}, birth: {birthDate:dd/MM/yyyy}, gender: {gender}.]";
            
        }
    }
}