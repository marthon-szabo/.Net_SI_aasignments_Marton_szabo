using System;
using System.Globalization;

namespace Exercise_1_2.person
{
    internal class Employee : Person 
    {
        decimal salary;
        Profession _profession;
        private Room _room;

        public Employee(decimal salary, Profession profession, string name, DateTime birthDate, Gender gender, Room room) 
            : base(name, birthDate, gender)
        {
            this._room = room;
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

        public int Room
        {
            get => _room.Number;
            set => _room.Number = value;
        }

        public override string ToString()
        {
            return $"Employee: [{base.ToString()}\nEmployee datas: salary: " +
                   $"{salary.ToString(CultureInfo.CurrentCulture):000:000.00$} profession: {_profession}" +
                   $", room: {_room}.]";
        }
    }
}