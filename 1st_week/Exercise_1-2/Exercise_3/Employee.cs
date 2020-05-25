using System;
using System.Globalization;

namespace Exercise_1_2.person
{
    internal class Employee : Person, ICloneable
    {
        Profession _profession;
        private Room _room;

        public Employee(Profession profession, string name, DateTime birthDate, Gender gender) 
            : base(name, birthDate, gender)
        {
            _profession = profession;
        }

        
        public Profession Profession
        {
            get => _profession;
            set => _profession = value;
        }

        public Room Room
        {
            get => _room;
            set => _room = value;
        }

        public override string ToString()
        {
            return $"Employee: [{base.ToString()}\nEmployee datas: [" +
                   $"profession {_profession}" +
                   $", room: {_room}]";
        }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.Number);
            return newEmployee;
        }
    }
}