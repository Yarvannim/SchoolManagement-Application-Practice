using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    public class Person
    {
        private int _age;
        private string _name;
        private int _pcn;
        private int _yearsAtSchool;

        public int PCN
        {
            get { return _pcn; }
        }
        public string Name
        {
            get { return _name; }
        }
        public int Years
        {
            get { return _yearsAtSchool; }
        }

        public Person(int age, string name, int pcn, int years) 
        {
            this._age = age;
            this._name = name;
            this._pcn = pcn;
            this._yearsAtSchool = years;
        }  
        public virtual string ToString()
        {
            return $"PCN: {this._pcn} Name: {this._name} Age: {this._age} Years at school: {_yearsAtSchool}";
        }
        public void CelebrateBirthday()
        {
            _age++;
        }
        public virtual void StartAnotherYearAtSchool()
        {
            _yearsAtSchool++;
        }
    }
}
