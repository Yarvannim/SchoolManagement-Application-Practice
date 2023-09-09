using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StudentApp
{
    public class Teacher: Person
    {
        private JobPosition _position;
        private double _salary;

        public Teacher(int age, string name, int pcn, int years, JobPosition position, double salary) : base(age, name, pcn, years)
        {
            this._position = position;
            this._salary = salary;
        }
        public override string ToString()
        {
            return $"{base.ToString()} Role: {_position} gets paid: {this._salary}";
        }
        public override void StartAnotherYearAtSchool()
        {
            base.StartAnotherYearAtSchool();
            if (base.Years % 3 == 0 || base.Years == 3)
            {
                _salary = Math.Round(_salary * 1.1);

            }
        }
        public void Promote()
        {
            if (_position != JobPosition.DIRECTOR)
            {
                _position++;
            }
        }
    }
}
