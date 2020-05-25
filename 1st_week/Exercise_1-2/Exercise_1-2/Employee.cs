using System;
using System.Globalization;

namespace Exercise_1_2.person
{
    internal class Employee : Person
    {
        decimal salary;
        Profession _profession;

        public Employee(decimal salary, Profession profession, string name, DateTime birthDate, Gender gender) 
            : base(name, birthDate, gender)
        {
            this.salary = salary;
            _profession = profession;
        }

        public decimal Salary
        {
            get => salary;
            set => salary = value;
        }
        

        public Profession Profession
        {
            get => _profession;
            set => _profession = value;
        }

        public override string ToString()
        {
            return $"Employee: [{base.ToString()}\nEmployee datas: salary: {salary.ToString(CultureInfo.CurrentCulture):000:000.00$} profession: {_profession}.]";
        }
    }
}