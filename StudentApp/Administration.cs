using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    public class Administration
    {
        private List<Person> persons = new List<Person>();
        public Administration() { }
        public void AddPerson(Person p)
        {
            if (!persons.Any(existingPerson => existingPerson.PCN == p.PCN))
            {
                persons.Add(p);
            }
            else
            {
                MessageBox.Show("Person with that pcn already exists");
            }
        }
        public Person GetPerson(int pcn)
        {
            return persons.FirstOrDefault(p => p.PCN == pcn);
        }
        public Person[] GetPeople()
        {
            return persons.OrderBy(p => p.Name).ToArray();
        }
        public Person[] GetPartialNamesPeople(string containString)
        {
            return persons.Where(p => p.Name.Contains(containString, StringComparison.OrdinalIgnoreCase)).OrderBy(p=> p.Name).ToArray();
        }
    }
}
