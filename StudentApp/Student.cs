using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    public class Student: Person
    {
        private int _nrOfECs;
        
        public Student(int age, string name, int pcn, int years, int ECs):base(age, name, pcn, years) 
        {
            this._nrOfECs = ECs;
        }
        public override string ToString()
        {
            return $"{base.ToString()} Role: Student with {this._nrOfECs} ECs";
        }
        public void AddECs(int n)
        {
            _nrOfECs += n;
        }
    }
}
