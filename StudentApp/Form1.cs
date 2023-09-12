using System.Text.RegularExpressions;

namespace StudentApp
{
    public partial class Form1 : Form
    {
        private Administration admin = new Administration();
        public Form1()
        {
            InitializeComponent();
            cbRoles.Items.Insert(0, "All");
            cbRoles.SelectedIndex = 0;
        }

        private void btnNewPerson_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbAddFormName.Text) && !string.IsNullOrWhiteSpace(tbAddFormPCN.Text) && nmrAddFormAge.Value != 0)
            {
                string name = tbAddFormName.Text;
                int pcn = Convert.ToInt32(tbAddFormPCN.Text);
                int age = Convert.ToInt32(nmrAddFormAge.Value);
                int years = Convert.ToInt32(nmrAddFormYearAtSchool.Value);
                int ECs = Convert.ToInt32(nmrAddFormECS.Value);
                int salary = Convert.ToInt32(nmrAddFormSalary.Value);
                Person NewPerson;
                if (rbStudent.Checked)
                {
                    NewPerson = new Student(age, name, pcn, years, ECs);
                }
                else
                {
                    NewPerson = new Teacher(age, name, pcn, years, JobPosition.JUNIOR_TEACHER, salary);
                }
                admin.AddPerson(NewPerson);
            }
        }

        private void btnShowAllPersons_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Person person in admin.GetPeople())
            {
                switch (cbRoles.SelectedIndex)
                {
                    case 0:
                        listBox1.Items.Add(person.ToString());
                        break;
                    case 1:
                        if (person is Student)
                        {
                            listBox1.Items.Add(person.ToString());
                        }
                        break;
                    case 2:
                        if (person is Teacher)
                        {
                            listBox1.Items.Add(person.ToString());
                        }
                        break;
                }
            }
        }

        private void btnTeacherPromote_Click(object sender, EventArgs e)
        {
            Person p = personChecker();
            if (p != null && p is Teacher)
            {
                ((Teacher)p).Promote();
                btnActionFormShowInfo.PerformClick();
            }
            else
            {
                MessageBox.Show("No teacher found with that PCN");
            }
        }

        private void btnBirthday_Click(object sender, EventArgs e)
        {
            Person p = personChecker();
            if (p != null)
            {
                p.CelebrateBirthday();
                btnActionFormShowInfo.PerformClick();
            }
        }

        private void btnActionFormShowInfo_Click(object sender, EventArgs e)
        {
            Person p = personChecker();
            if (p != null)
            {
                listBox1.Items.Add(p.ToString());
            }
        }

        private void btnNewYear_Click(object sender, EventArgs e)
        {
            Person p = personChecker();
            if (p != null)
            {
                p.StartAnotherYearAtSchool();
                btnActionFormShowInfo.PerformClick();
            }
        }

        private void btnAddECS_Click(object sender, EventArgs e)
        {
            Person p = personChecker();
            if (p != null && p is Student)
            {
                ((Student)p).AddECs(Convert.ToInt32(nmrAddFormECS.Value));
                btnActionFormShowInfo.PerformClick();
            }
            else
            {
                MessageBox.Show("No student found with that PCN");
            }
        }

        private void radio_buttonCheckedChanged(object sender, EventArgs e)
        {
            string sendername = ((RadioButton)sender).Name;
            if (sendername == "rbStudent")
            {
                nmrAddFormSalary.Enabled = false;
                nmrAddFormECS.Enabled = true;
            }
            else
            {
                nmrAddFormSalary.Enabled = true;
                nmrAddFormECS.Enabled = false;
            }
        }
        private Person personChecker()
        {
            if (!string.IsNullOrWhiteSpace(tbActionsFormPCN.Text))
            {
                Person p = admin.GetPerson(Convert.ToInt32(tbActionsFormPCN.Text));
                if (p != null)
                {
                    listBox1.Items.Clear();
                    return p;
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

        private void btnPartialSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Person person in admin.GetPartialNamesPeople(tbSearchBox.Text))
            {
                listBox1.Items.Add(person.ToString());
            }
        }
    }
}