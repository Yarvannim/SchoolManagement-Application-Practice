namespace StudentApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            nmrAddFormSalary = new NumericUpDown();
            nmrAddFormECS = new NumericUpDown();
            nmrAddFormYearAtSchool = new NumericUpDown();
            nmrAddFormAge = new NumericUpDown();
            btnNewTeacher = new Button();
            btnNewStudent = new Button();
            btnNewPerson = new Button();
            label6 = new Label();
            label5 = new Label();
            tbAddFormName = new TextBox();
            tbAddFormPCN = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnShowAllPersons = new Button();
            btnShowAllStudents = new Button();
            btnShowAllTeachers = new Button();
            listBox1 = new ListBox();
            groupBox2 = new GroupBox();
            tbPersonsFormPCN = new TextBox();
            btnPersonsFormShowInfo = new Button();
            label7 = new Label();
            groupBox3 = new GroupBox();
            tbStudentFormPCN = new TextBox();
            nmrStudentFormECS = new NumericUpDown();
            btnStudentFormAddECS = new Button();
            btnStudentNewYear = new Button();
            btnStudentFormShowInfo = new Button();
            label8 = new Label();
            groupBox4 = new GroupBox();
            btnTeacherPromote = new Button();
            btnTeacherFormNewYear = new Button();
            btnTeacherFormShowInfo = new Button();
            tbTeacherFormPCN = new TextBox();
            label9 = new Label();
            btnBirthday = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrAddFormSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrAddFormECS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrAddFormYearAtSchool).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrAddFormAge).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrStudentFormECS).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nmrAddFormSalary);
            groupBox1.Controls.Add(nmrAddFormECS);
            groupBox1.Controls.Add(nmrAddFormYearAtSchool);
            groupBox1.Controls.Add(nmrAddFormAge);
            groupBox1.Controls.Add(btnNewTeacher);
            groupBox1.Controls.Add(btnNewStudent);
            groupBox1.Controls.Add(btnNewPerson);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbAddFormName);
            groupBox1.Controls.Add(tbAddFormPCN);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(7, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(781, 182);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add form";
            // 
            // nmrAddFormSalary
            // 
            nmrAddFormSalary.Location = new Point(557, 117);
            nmrAddFormSalary.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
            nmrAddFormSalary.Name = "nmrAddFormSalary";
            nmrAddFormSalary.Size = new Size(120, 23);
            nmrAddFormSalary.TabIndex = 18;
            // 
            // nmrAddFormECS
            // 
            nmrAddFormECS.Location = new Point(294, 117);
            nmrAddFormECS.Name = "nmrAddFormECS";
            nmrAddFormECS.Size = new Size(120, 23);
            nmrAddFormECS.TabIndex = 17;
            // 
            // nmrAddFormYearAtSchool
            // 
            nmrAddFormYearAtSchool.Location = new Point(91, 117);
            nmrAddFormYearAtSchool.Name = "nmrAddFormYearAtSchool";
            nmrAddFormYearAtSchool.Size = new Size(120, 23);
            nmrAddFormYearAtSchool.TabIndex = 16;
            // 
            // nmrAddFormAge
            // 
            nmrAddFormAge.Location = new Point(91, 88);
            nmrAddFormAge.Name = "nmrAddFormAge";
            nmrAddFormAge.Size = new Size(120, 23);
            nmrAddFormAge.TabIndex = 15;
            // 
            // btnNewTeacher
            // 
            btnNewTeacher.Location = new Point(510, 153);
            btnNewTeacher.Name = "btnNewTeacher";
            btnNewTeacher.Size = new Size(185, 23);
            btnNewTeacher.TabIndex = 14;
            btnNewTeacher.Text = "New teacher";
            btnNewTeacher.UseVisualStyleBackColor = true;
            btnNewTeacher.Click += btnNewTeacher_Click;
            // 
            // btnNewStudent
            // 
            btnNewStudent.Location = new Point(259, 152);
            btnNewStudent.Name = "btnNewStudent";
            btnNewStudent.Size = new Size(180, 23);
            btnNewStudent.TabIndex = 13;
            btnNewStudent.Text = "New student";
            btnNewStudent.UseVisualStyleBackColor = true;
            btnNewStudent.Click += btnNewStudent_Click;
            // 
            // btnNewPerson
            // 
            btnNewPerson.Location = new Point(6, 152);
            btnNewPerson.Name = "btnNewPerson";
            btnNewPerson.Size = new Size(196, 23);
            btnNewPerson.TabIndex = 12;
            btnNewPerson.Text = "New person";
            btnNewPerson.UseVisualStyleBackColor = true;
            btnNewPerson.Click += btnNewPerson_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(510, 119);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 11;
            label6.Text = "Salary:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(258, 119);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 10;
            label5.Text = "ECS:";
            // 
            // tbAddFormName
            // 
            tbAddFormName.Location = new Point(102, 53);
            tbAddFormName.Name = "tbAddFormName";
            tbAddFormName.Size = new Size(100, 23);
            tbAddFormName.TabIndex = 5;
            // 
            // tbAddFormPCN
            // 
            tbAddFormPCN.Location = new Point(102, 24);
            tbAddFormPCN.Name = "tbAddFormPCN";
            tbAddFormPCN.Size = new Size(100, 23);
            tbAddFormPCN.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 119);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 3;
            label4.Text = "Year at school:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 90);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "Age:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 61);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 32);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "PCN:";
            // 
            // btnShowAllPersons
            // 
            btnShowAllPersons.Location = new Point(13, 197);
            btnShowAllPersons.Name = "btnShowAllPersons";
            btnShowAllPersons.Size = new Size(196, 23);
            btnShowAllPersons.TabIndex = 15;
            btnShowAllPersons.Text = "Show all persons";
            btnShowAllPersons.UseVisualStyleBackColor = true;
            btnShowAllPersons.Click += btnShowAllPersons_Click;
            // 
            // btnShowAllStudents
            // 
            btnShowAllStudents.Location = new Point(266, 197);
            btnShowAllStudents.Name = "btnShowAllStudents";
            btnShowAllStudents.Size = new Size(196, 23);
            btnShowAllStudents.TabIndex = 16;
            btnShowAllStudents.Text = "Show all students";
            btnShowAllStudents.UseVisualStyleBackColor = true;
            btnShowAllStudents.Click += btnShowAllStudents_Click;
            // 
            // btnShowAllTeachers
            // 
            btnShowAllTeachers.Location = new Point(517, 197);
            btnShowAllTeachers.Name = "btnShowAllTeachers";
            btnShowAllTeachers.Size = new Size(196, 23);
            btnShowAllTeachers.TabIndex = 17;
            btnShowAllTeachers.Text = "Show all teachers";
            btnShowAllTeachers.UseVisualStyleBackColor = true;
            btnShowAllTeachers.Click += btnShowAllTeachers_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(13, 243);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(698, 124);
            listBox1.TabIndex = 18;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbPersonsFormPCN);
            groupBox2.Controls.Add(btnPersonsFormShowInfo);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(18, 389);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 173);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Persons form";
            // 
            // tbPersonsFormPCN
            // 
            tbPersonsFormPCN.Location = new Point(46, 16);
            tbPersonsFormPCN.Name = "tbPersonsFormPCN";
            tbPersonsFormPCN.Size = new Size(145, 23);
            tbPersonsFormPCN.TabIndex = 25;
            // 
            // btnPersonsFormShowInfo
            // 
            btnPersonsFormShowInfo.Location = new Point(11, 45);
            btnPersonsFormShowInfo.Name = "btnPersonsFormShowInfo";
            btnPersonsFormShowInfo.Size = new Size(180, 23);
            btnPersonsFormShowInfo.TabIndex = 16;
            btnPersonsFormShowInfo.Text = "Show info";
            btnPersonsFormShowInfo.UseVisualStyleBackColor = true;
            btnPersonsFormShowInfo.Click += btnPersonsFormShowInfo_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 19);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 15;
            label7.Text = "PCN:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tbStudentFormPCN);
            groupBox3.Controls.Add(nmrStudentFormECS);
            groupBox3.Controls.Add(btnStudentFormAddECS);
            groupBox3.Controls.Add(btnStudentNewYear);
            groupBox3.Controls.Add(btnStudentFormShowInfo);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(266, 389);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 173);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Student form";
            // 
            // tbStudentFormPCN
            // 
            tbStudentFormPCN.Location = new Point(46, 21);
            tbStudentFormPCN.Name = "tbStudentFormPCN";
            tbStudentFormPCN.Size = new Size(145, 23);
            tbStudentFormPCN.TabIndex = 24;
            // 
            // nmrStudentFormECS
            // 
            nmrStudentFormECS.Location = new Point(11, 107);
            nmrStudentFormECS.Name = "nmrStudentFormECS";
            nmrStudentFormECS.Size = new Size(63, 23);
            nmrStudentFormECS.TabIndex = 21;
            // 
            // btnStudentFormAddECS
            // 
            btnStudentFormAddECS.Location = new Point(80, 107);
            btnStudentFormAddECS.Name = "btnStudentFormAddECS";
            btnStudentFormAddECS.Size = new Size(75, 23);
            btnStudentFormAddECS.TabIndex = 20;
            btnStudentFormAddECS.Text = "Add ECS";
            btnStudentFormAddECS.UseVisualStyleBackColor = true;
            btnStudentFormAddECS.Click += btnStudentFormAddECS_Click;
            // 
            // btnStudentNewYear
            // 
            btnStudentNewYear.Location = new Point(11, 79);
            btnStudentNewYear.Name = "btnStudentNewYear";
            btnStudentNewYear.Size = new Size(180, 23);
            btnStudentNewYear.TabIndex = 18;
            btnStudentNewYear.Text = "Start new schoolyear";
            btnStudentNewYear.UseVisualStyleBackColor = true;
            btnStudentNewYear.Click += btnStudentNewYear_Click;
            // 
            // btnStudentFormShowInfo
            // 
            btnStudentFormShowInfo.Location = new Point(11, 50);
            btnStudentFormShowInfo.Name = "btnStudentFormShowInfo";
            btnStudentFormShowInfo.Size = new Size(180, 23);
            btnStudentFormShowInfo.TabIndex = 17;
            btnStudentFormShowInfo.Text = "Show info";
            btnStudentFormShowInfo.UseVisualStyleBackColor = true;
            btnStudentFormShowInfo.Click += btnStudentFormShowInfo_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 24);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 17;
            label8.Text = "PCN:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnTeacherPromote);
            groupBox4.Controls.Add(btnTeacherFormNewYear);
            groupBox4.Controls.Add(btnTeacherFormShowInfo);
            groupBox4.Controls.Add(tbTeacherFormPCN);
            groupBox4.Controls.Add(label9);
            groupBox4.Location = new Point(517, 389);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 173);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            groupBox4.Text = "Teacher form";
            // 
            // btnTeacherPromote
            // 
            btnTeacherPromote.Location = new Point(12, 104);
            btnTeacherPromote.Name = "btnTeacherPromote";
            btnTeacherPromote.Size = new Size(180, 23);
            btnTeacherPromote.TabIndex = 23;
            btnTeacherPromote.Text = "Promote";
            btnTeacherPromote.UseVisualStyleBackColor = true;
            btnTeacherPromote.Click += btnTeacherPromote_Click;
            // 
            // btnTeacherFormNewYear
            // 
            btnTeacherFormNewYear.Location = new Point(10, 75);
            btnTeacherFormNewYear.Name = "btnTeacherFormNewYear";
            btnTeacherFormNewYear.Size = new Size(180, 23);
            btnTeacherFormNewYear.TabIndex = 22;
            btnTeacherFormNewYear.Text = "Start new schoolyear";
            btnTeacherFormNewYear.UseVisualStyleBackColor = true;
            btnTeacherFormNewYear.Click += btnTeacherFormNewYear_Click;
            // 
            // btnTeacherFormShowInfo
            // 
            btnTeacherFormShowInfo.Location = new Point(12, 45);
            btnTeacherFormShowInfo.Name = "btnTeacherFormShowInfo";
            btnTeacherFormShowInfo.Size = new Size(180, 23);
            btnTeacherFormShowInfo.TabIndex = 21;
            btnTeacherFormShowInfo.Text = "Show info";
            btnTeacherFormShowInfo.UseVisualStyleBackColor = true;
            btnTeacherFormShowInfo.Click += btnTeacherFormShowInfo_Click;
            // 
            // tbTeacherFormPCN
            // 
            tbTeacherFormPCN.Location = new Point(47, 16);
            tbTeacherFormPCN.Name = "tbTeacherFormPCN";
            tbTeacherFormPCN.Size = new Size(145, 23);
            tbTeacherFormPCN.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 21);
            label9.Name = "label9";
            label9.Size = new Size(34, 15);
            label9.TabIndex = 21;
            label9.Text = "PCN:";
            // 
            // btnBirthday
            // 
            btnBirthday.Location = new Point(717, 243);
            btnBirthday.Name = "btnBirthday";
            btnBirthday.Size = new Size(75, 124);
            btnBirthday.TabIndex = 21;
            btnBirthday.Text = "Birthday\r\n";
            btnBirthday.UseVisualStyleBackColor = true;
            btnBirthday.Click += btnBirthday_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 588);
            Controls.Add(btnBirthday);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(listBox1);
            Controls.Add(btnShowAllTeachers);
            Controls.Add(btnShowAllStudents);
            Controls.Add(btnShowAllPersons);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrAddFormSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrAddFormECS).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrAddFormYearAtSchool).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrAddFormAge).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrStudentFormECS).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbAddFormName;
        private TextBox tbAddFormPCN;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label7;
        private Button btnNewTeacher;
        private Button btnNewStudent;
        private Button btnNewPerson;
        private Label label6;
        private Label label5;
        private TextBox textBox6;
        private Button btnShowAllPersons;
        private Button btnShowAllStudents;
        private Button btnShowAllTeachers;
        private ListBox listBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button btnPersonsFormShowInfo;
        private TextBox textBox7;
        private Button btnStudentFormAddECS;
        private TextBox textBox9;
        private Button btnStudentNewYear;
        private Button btnStudentFormShowInfo;
        private TextBox textBox8;
        private Label label8;
        private Button btnTeacherPromote;
        private Button btnTeacherFormNewYear;
        private Button btnTeacherFormShowInfo;
        private TextBox tbTeacherFormPCN;
        private Label label9;
        private NumericUpDown nmrAddFormSalary;
        private NumericUpDown nmrAddFormECS;
        private NumericUpDown nmrAddFormYearAtSchool;
        private NumericUpDown nmrAddFormAge;
        private NumericUpDown nmrStudentFormECS;
        private TextBox tbPersonsFormPCN;
        private TextBox tbStudentFormPCN;
        private Button btnBirthday;
    }
}