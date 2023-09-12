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
            rbTeacher = new RadioButton();
            rbStudent = new RadioButton();
            label8 = new Label();
            nmrAddFormSalary = new NumericUpDown();
            nmrAddFormECS = new NumericUpDown();
            nmrAddFormYearAtSchool = new NumericUpDown();
            nmrAddFormAge = new NumericUpDown();
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
            listBox1 = new ListBox();
            groupBox2 = new GroupBox();
            btnTeacherPromote = new Button();
            btnBirthday = new Button();
            nmrStudentFormECS = new NumericUpDown();
            tbActionsFormPCN = new TextBox();
            btnActionFormAddECS = new Button();
            btnActionFormShowInfo = new Button();
            btnActionFormNewYear = new Button();
            label7 = new Label();
            btnPartialSearch = new Button();
            cbRoles = new ComboBox();
            tbSearchBox = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrAddFormSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrAddFormECS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrAddFormYearAtSchool).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrAddFormAge).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrStudentFormECS).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbTeacher);
            groupBox1.Controls.Add(rbStudent);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(nmrAddFormSalary);
            groupBox1.Controls.Add(nmrAddFormECS);
            groupBox1.Controls.Add(nmrAddFormYearAtSchool);
            groupBox1.Controls.Add(nmrAddFormAge);
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
            groupBox1.Size = new Size(222, 287);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add form";
            // 
            // rbTeacher
            // 
            rbTeacher.AutoSize = true;
            rbTeacher.Location = new Point(96, 41);
            rbTeacher.Name = "rbTeacher";
            rbTeacher.Size = new Size(65, 19);
            rbTeacher.TabIndex = 21;
            rbTeacher.Text = "Teacher";
            rbTeacher.UseVisualStyleBackColor = true;
            rbTeacher.CheckedChanged += radio_buttonCheckedChanged;
            // 
            // rbStudent
            // 
            rbStudent.AutoSize = true;
            rbStudent.Checked = true;
            rbStudent.Location = new Point(95, 16);
            rbStudent.Name = "rbStudent";
            rbStudent.Size = new Size(66, 19);
            rbStudent.TabIndex = 20;
            rbStudent.TabStop = true;
            rbStudent.Text = "Student";
            rbStudent.UseVisualStyleBackColor = true;
            rbStudent.CheckedChanged += radio_buttonCheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 27);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 19;
            label8.Text = "Type:";
            // 
            // nmrAddFormSalary
            // 
            nmrAddFormSalary.Enabled = false;
            nmrAddFormSalary.Location = new Point(96, 233);
            nmrAddFormSalary.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
            nmrAddFormSalary.Name = "nmrAddFormSalary";
            nmrAddFormSalary.Size = new Size(120, 23);
            nmrAddFormSalary.TabIndex = 18;
            // 
            // nmrAddFormECS
            // 
            nmrAddFormECS.Location = new Point(96, 204);
            nmrAddFormECS.Name = "nmrAddFormECS";
            nmrAddFormECS.Size = new Size(120, 23);
            nmrAddFormECS.TabIndex = 17;
            // 
            // nmrAddFormYearAtSchool
            // 
            nmrAddFormYearAtSchool.Location = new Point(96, 175);
            nmrAddFormYearAtSchool.Name = "nmrAddFormYearAtSchool";
            nmrAddFormYearAtSchool.Size = new Size(120, 23);
            nmrAddFormYearAtSchool.TabIndex = 16;
            // 
            // nmrAddFormAge
            // 
            nmrAddFormAge.Location = new Point(96, 146);
            nmrAddFormAge.Name = "nmrAddFormAge";
            nmrAddFormAge.Size = new Size(120, 23);
            nmrAddFormAge.TabIndex = 15;
            // 
            // btnNewPerson
            // 
            btnNewPerson.Location = new Point(11, 257);
            btnNewPerson.Name = "btnNewPerson";
            btnNewPerson.Size = new Size(196, 23);
            btnNewPerson.TabIndex = 12;
            btnNewPerson.Text = "Add to administration";
            btnNewPerson.UseVisualStyleBackColor = true;
            btnNewPerson.Click += btnNewPerson_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 233);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 11;
            label6.Text = "Salary:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 210);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 10;
            label5.Text = "ECS:";
            // 
            // tbAddFormName
            // 
            tbAddFormName.Location = new Point(96, 111);
            tbAddFormName.Name = "tbAddFormName";
            tbAddFormName.Size = new Size(120, 23);
            tbAddFormName.TabIndex = 5;
            // 
            // tbAddFormPCN
            // 
            tbAddFormPCN.Location = new Point(96, 82);
            tbAddFormPCN.Name = "tbAddFormPCN";
            tbAddFormPCN.Size = new Size(120, 23);
            tbAddFormPCN.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 177);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 3;
            label4.Text = "Year at school:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 148);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "Age:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 119);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 90);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "PCN:";
            // 
            // btnShowAllPersons
            // 
            btnShowAllPersons.Location = new Point(454, 192);
            btnShowAllPersons.Name = "btnShowAllPersons";
            btnShowAllPersons.Size = new Size(196, 23);
            btnShowAllPersons.TabIndex = 15;
            btnShowAllPersons.Text = "Show all persons";
            btnShowAllPersons.UseVisualStyleBackColor = true;
            btnShowAllPersons.Click += btnShowAllPersons_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(235, 17);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(552, 169);
            listBox1.TabIndex = 18;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTeacherPromote);
            groupBox2.Controls.Add(btnBirthday);
            groupBox2.Controls.Add(nmrStudentFormECS);
            groupBox2.Controls.Add(tbActionsFormPCN);
            groupBox2.Controls.Add(btnActionFormAddECS);
            groupBox2.Controls.Add(btnActionFormShowInfo);
            groupBox2.Controls.Add(btnActionFormNewYear);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(793, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 201);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Action form";
            // 
            // btnTeacherPromote
            // 
            btnTeacherPromote.Location = new Point(11, 162);
            btnTeacherPromote.Name = "btnTeacherPromote";
            btnTeacherPromote.Size = new Size(180, 23);
            btnTeacherPromote.TabIndex = 23;
            btnTeacherPromote.Text = "Promote";
            btnTeacherPromote.UseVisualStyleBackColor = true;
            btnTeacherPromote.Click += btnTeacherPromote_Click;
            // 
            // btnBirthday
            // 
            btnBirthday.Location = new Point(11, 74);
            btnBirthday.Name = "btnBirthday";
            btnBirthday.Size = new Size(180, 24);
            btnBirthday.TabIndex = 21;
            btnBirthday.Text = "Birthday\r\n";
            btnBirthday.UseVisualStyleBackColor = true;
            btnBirthday.Click += btnBirthday_Click;
            // 
            // nmrStudentFormECS
            // 
            nmrStudentFormECS.Location = new Point(11, 133);
            nmrStudentFormECS.Name = "nmrStudentFormECS";
            nmrStudentFormECS.Size = new Size(99, 23);
            nmrStudentFormECS.TabIndex = 21;
            // 
            // tbActionsFormPCN
            // 
            tbActionsFormPCN.Location = new Point(46, 16);
            tbActionsFormPCN.Name = "tbActionsFormPCN";
            tbActionsFormPCN.Size = new Size(145, 23);
            tbActionsFormPCN.TabIndex = 25;
            // 
            // btnActionFormAddECS
            // 
            btnActionFormAddECS.Location = new Point(116, 133);
            btnActionFormAddECS.Name = "btnActionFormAddECS";
            btnActionFormAddECS.Size = new Size(75, 23);
            btnActionFormAddECS.TabIndex = 20;
            btnActionFormAddECS.Text = "Add ECS";
            btnActionFormAddECS.UseVisualStyleBackColor = true;
            btnActionFormAddECS.Click += btnAddECS_Click;
            // 
            // btnActionFormShowInfo
            // 
            btnActionFormShowInfo.Location = new Point(11, 45);
            btnActionFormShowInfo.Name = "btnActionFormShowInfo";
            btnActionFormShowInfo.Size = new Size(180, 23);
            btnActionFormShowInfo.TabIndex = 16;
            btnActionFormShowInfo.Text = "Show info";
            btnActionFormShowInfo.UseVisualStyleBackColor = true;
            btnActionFormShowInfo.Click += btnActionFormShowInfo_Click;
            // 
            // btnActionFormNewYear
            // 
            btnActionFormNewYear.Location = new Point(11, 104);
            btnActionFormNewYear.Name = "btnActionFormNewYear";
            btnActionFormNewYear.Size = new Size(180, 23);
            btnActionFormNewYear.TabIndex = 18;
            btnActionFormNewYear.Text = "Start new schoolyear";
            btnActionFormNewYear.UseVisualStyleBackColor = true;
            btnActionFormNewYear.Click += btnNewYear_Click;
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
            // btnPartialSearch
            // 
            btnPartialSearch.Location = new Point(454, 221);
            btnPartialSearch.Name = "btnPartialSearch";
            btnPartialSearch.Size = new Size(196, 23);
            btnPartialSearch.TabIndex = 20;
            btnPartialSearch.Text = "Search via partial name";
            btnPartialSearch.UseVisualStyleBackColor = true;
            btnPartialSearch.Click += btnPartialSearch_Click;
            // 
            // cbRoles
            // 
            cbRoles.FormattingEnabled = true;
            cbRoles.Items.AddRange(new object[] { "Students", "Teachers" });
            cbRoles.Location = new Point(235, 192);
            cbRoles.Name = "cbRoles";
            cbRoles.Size = new Size(213, 23);
            cbRoles.TabIndex = 21;
            // 
            // tbSearchBox
            // 
            tbSearchBox.Location = new Point(235, 224);
            tbSearchBox.Name = "tbSearchBox";
            tbSearchBox.Size = new Size(213, 23);
            tbSearchBox.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 588);
            Controls.Add(tbSearchBox);
            Controls.Add(cbRoles);
            Controls.Add(btnPartialSearch);
            Controls.Add(groupBox2);
            Controls.Add(listBox1);
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
            ((System.ComponentModel.ISupportInitialize)nmrStudentFormECS).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnNewPerson;
        private Label label6;
        private Label label5;
        private TextBox textBox6;
        private Button btnShowAllPersons;
        private ListBox listBox1;
        private GroupBox groupBox2;
        private Button btnActionFormShowInfo;
        private TextBox textBox7;
        private Button btnActionFormAddECS;
        private TextBox textBox9;
        private Button btnActionFormNewYear;
        private TextBox textBox8;
        private Button btnTeacherPromote;
        private NumericUpDown nmrAddFormSalary;
        private NumericUpDown nmrAddFormECS;
        private NumericUpDown nmrAddFormYearAtSchool;
        private NumericUpDown nmrAddFormAge;
        private NumericUpDown nmrStudentFormECS;
        private TextBox tbActionsFormPCN;
        private Button btnBirthday;
        private RadioButton rbTeacher;
        private RadioButton rbStudent;
        private Label label8;
        private Button btnPartialSearch;
        private ComboBox cbRoles;
        private TextBox tbSearchBox;
    }
}