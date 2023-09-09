using System.Text.RegularExpressions;

namespace StudentApp
{
    public partial class Form1 : Form
    {
        private Administration admin = new Administration();
        private Button Lastclicked;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewPerson_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbAddFormName.Text) && !string.IsNullOrWhiteSpace(tbAddFormPCN.Text) && nmrAddFormAge.Value != 0)
            {
                string name = tbAddFormName.Text;
                int pcn = Convert.ToInt32(tbAddFormPCN.Text);
                int age = Convert.ToInt32(nmrAddFormAge.Value);
                int years = Convert.ToInt32(nmrAddFormYearAtSchool.Value);
                Person NewPerson = new Person(age, name, pcn, years);
                admin.AddPerson(NewPerson);
            }
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbAddFormName.Text) && !string.IsNullOrWhiteSpace(tbAddFormPCN.Text) && nmrAddFormAge.Value != 0)
            {
                string name = tbAddFormName.Text;
                int pcn = Convert.ToInt32(tbAddFormPCN.Text);
                int age = Convert.ToInt32(nmrAddFormAge.Value);
                int years = Convert.ToInt32(nmrAddFormYearAtSchool.Value);
                int ECs = Convert.ToInt32(nmrAddFormECS.Value);
                Student NewPerson = new Student(age, name, pcn, years, ECs);
                admin.AddStudent(NewPerson);
            }
        }

        private void btnNewTeacher_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbAddFormName.Text) && !string.IsNullOrWhiteSpace(tbAddFormPCN.Text) && nmrAddFormAge.Value != 0)
            {
                string name = tbAddFormName.Text;
                int pcn = Convert.ToInt32(tbAddFormPCN.Text);
                int age = Convert.ToInt32(nmrAddFormAge.Value);
                int years = Convert.ToInt32(nmrAddFormYearAtSchool.Value);
                int salary = Convert.ToInt32(nmrAddFormSalary.Value);
                Teacher NewPerson = new Teacher(age, name, pcn, years, JobPosition.JUNIOR_TEACHER, salary);
                admin.AddTeacher(NewPerson);
            }
        }

        private void btnShowAllPersons_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Person person in admin.GetPeople())
            {
                listBox1.Items.Add(person.ToString());
            }
            Lastclicked = btnShowAllPersons;
        }

        private void btnShowAllStudents_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Student person in admin.GetStudents())
            {
                listBox1.Items.Add(person.ToString());
            }
            Lastclicked = btnShowAllStudents;
        }

        private void btnShowAllTeachers_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Teacher person in admin.GetTeachers())
            {
                listBox1.Items.Add(person.ToString());
            }
            Lastclicked = btnShowAllTeachers;
        }

        private void btnPersonsFormShowInfo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbPersonsFormPCN.Text))
            {
                Person p = admin.GetPerson(Convert.ToInt32(tbPersonsFormPCN.Text));
                if (p != null)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add(p.ToString());
                    Lastclicked = btnPersonsFormShowInfo;
                }
                else
                {
                    MessageBox.Show("No person with that PCN found");
                }
            }
            else
            {
                MessageBox.Show("No PCN filled in");
            }
        }

        private void btnStudentFormShowInfo_Click(object sender, EventArgs e)
        {
            Student s = StudentChecker();
            if (s != null)
            {
                listBox1.Items.Add(s.ToString());
                Lastclicked = btnStudentFormShowInfo;
            }
        }

        private void btnStudentNewYear_Click(object sender, EventArgs e)
        {
            Student s = StudentChecker();
            if (s != null)
            {
                s.StartAnotherYearAtSchool();
                btnStudentFormShowInfo.PerformClick();
            }
        }

        private void btnStudentFormAddECS_Click(object sender, EventArgs e)
        {
            Student s = StudentChecker();
            if (s != null)
            {
                s.AddECs(Convert.ToInt32(nmrStudentFormECS.Value));
                btnStudentFormShowInfo.PerformClick();
            }
        }

        private void btnTeacherFormShowInfo_Click(object sender, EventArgs e)
        {
            Teacher t = TeacherChecker();
            if (t != null)
            {
                listBox1.Items.Add(t.ToString());
                Lastclicked = btnTeacherFormShowInfo;
            }

        }

        private void btnTeacherFormNewYear_Click(object sender, EventArgs e)
        {
            Teacher t = TeacherChecker();
            if (t != null)
            {
                t.StartAnotherYearAtSchool();
                btnTeacherFormShowInfo.PerformClick();
            }
        }

        private void btnTeacherPromote_Click(object sender, EventArgs e)
        {
            Teacher t = TeacherChecker();
            if (t != null)
            {
                t.Promote();
                btnTeacherFormShowInfo.PerformClick();
            }
        }
        private Teacher TeacherChecker()
        {
            if (!string.IsNullOrWhiteSpace(tbTeacherFormPCN.Text))
            {
                Teacher t = admin.GetTeacher(Convert.ToInt32(tbTeacherFormPCN.Text));
                if (t != null)
                {
                    listBox1.Items.Clear();
                    return t;
                }
                else
                {
                    MessageBox.Show("No person with that PCN found");
                }
            }
            else
            {
                MessageBox.Show("No PCN filled in");
            }
            return null;
        }
        private Student StudentChecker()
        {
            if (!string.IsNullOrWhiteSpace(tbStudentFormPCN.Text))
            {
                Student s = admin.GetStudent(Convert.ToInt32(tbStudentFormPCN.Text));
                if (s != null)
                {
                    listBox1.Items.Clear();
                    return s;
                }
                else
                {
                    MessageBox.Show("No person with that PCN found");
                }
            }
            else
            {
                MessageBox.Show("No PCN filled in");
            }
            return null;
        }

        private void btnBirthday_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string line = listBox1.SelectedItem as string;
                string pattern = @"PCN:\s*(\d+)";
                int pcnNumber = int.Parse(Regex.Match(line, pattern).Groups[1].Value);
                Person selectedPerson = admin.GetPerson(pcnNumber);
                selectedPerson.CelebrateBirthday();
                Lastclicked.PerformClick();
            }
        }
    }
}