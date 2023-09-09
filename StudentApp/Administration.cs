using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    public class Administration
    {
        private List<Student> students = new List<Student>();
        private List<Person> persons = new List<Person>();
        private List<Teacher> teachers = new List<Teacher>();
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
        public void AddStudent(Student s)
        {
            if (!persons.Any(existingPerson => existingPerson.PCN == s.PCN))
            {
                persons.Add(s);
                students.Add(s);
            }
            else
            {
                MessageBox.Show("Student with that pcn already exists");
            }
        }
        public void AddTeacher(Teacher t)
        {
            if (!persons.Any(existingPerson => existingPerson.PCN == t.PCN))
            {
                persons.Add(t);
                teachers.Add(t);
            }
            else
            {
                MessageBox.Show("Teacher with that pcn already exists");
            }
        }
        public Person GetPerson(int pcn)
        {
            return persons.FirstOrDefault(p => p.PCN == pcn);
        }
        public Student GetStudent(int pcn)
        {
            return students.FirstOrDefault(p => p.PCN == pcn);
        }
        public Teacher GetTeacher(int pcn)
        {
            return teachers.FirstOrDefault(p => p.PCN == pcn);
        }
        public Person[] GetPeople()
        {
            return persons.ToArray();
        }
        public Student[] GetStudents()
        {
            return students.ToArray();
        }
        public Teacher[] GetTeachers()
        {
            return teachers.ToArray();
        }
    }
}
