using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkSanya
{
    public partial class Form1 : Form
    {
        readonly Dean dean;
        public Form1()
        {
            dean = Dean.GetDean();
            InitializeComponent();
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            dataGridViewStudent.DataSource = null;
            dataGridViewLecturer.DataSource = null;
            dataGridViewTheme.DataSource = null;
            dataGridViewStatement.DataSource = null;

            dean.students.Clear();
            dean.lecturers.Clear();
            dean.themes.Clear();
            dean.students.Clear();

            string filesdir = textBoxDirection.Text.Trim();

            Program.FileRead_Student(filesdir + "\\студенты.txt");
            Program.FileRead_Lecturer(filesdir + "\\преподаватели.txt");
            Program.FileRead_Theme(filesdir + "\\предметы.txt");
            Program.FileRead_Statement(filesdir + "\\ведомость.txt");

            dataGridViewStudent.DataSource = dean.students;
            dataGridViewStudent.Columns[0].Visible = false;
            dataGridViewStudent.Columns[1].HeaderText = "ФИО";
            dataGridViewStudent.Columns[2].HeaderText = "№ зачётки";
            dataGridViewStudent.Columns[3].HeaderText = "Группа";

            dataGridViewLecturer.DataSource = dean.lecturers;
            dataGridViewLecturer.Columns[0].Visible = false;
            dataGridViewLecturer.Columns[1].HeaderText = "ФИО";
            dataGridViewLecturer.Columns[2].HeaderText = "Степень";
            dataGridViewLecturer.Columns[3].HeaderText = "Стаж";

            dataGridViewTheme.DataSource = dean.themes;
            dataGridViewTheme.Columns[0].Visible = false;
            dataGridViewTheme.Columns[1].HeaderText = "Название";
            dataGridViewTheme.Columns[2].HeaderText = "Отчётность";

            var qstatement = from statementLinq in dean.statement
                             join student in dean.students on statementLinq.KeyStudent equals student.keyStudent
                             join lecturer in dean.lecturers on statementLinq.KeyLecturer equals lecturer.Key
                             join theme in dean.themes on statementLinq.KeyTheme equals theme.Key
                             select new
                             {
                                 student = student.Fullname,
                                 lecturer = lecturer.Fullname,
                                 theme = theme.Name,
                                 date = statementLinq.Date,
                                 grade = statementLinq.Grade
                             };
            dataGridViewStatement.DataSource = qstatement.ToList();
            dataGridViewStatement.Columns[0].HeaderText = "Студент";
            dataGridViewStatement.Columns[1].HeaderText = "Преподаватель";
            dataGridViewStatement.Columns[2].HeaderText = "Предмет";
            dataGridViewStatement.Columns[3].HeaderText = "Дата";
            dataGridViewStatement.Columns[4].HeaderText = "Оценка %";

            var qgroup = (from student in dean.students
                          select student.Group).Distinct();
            comboBoxReq1.Items.Clear();
            comboBoxReq1.Items.AddRange(qgroup.ToArray());

            var qthemes = from theme in dean.themes
                            select theme.Name;
            comboBoxReq2.Items.Clear();
            comboBoxReq2.Items.AddRange(qthemes.ToArray());

            var qstudents = from student in dean.students
                          select student.Fullname;
            comboBoxReq3.Items.Clear();
            comboBoxReq3.Items.AddRange(qstudents.ToArray());

            comboBoxReq4.Items.Clear();
            comboBoxReq4.Items.AddRange(qthemes.ToArray());

            var qlecturer = from lecturer in dean.lecturers
                            select lecturer.Fullname;
            comboBoxReq5.Items.Clear();
            comboBoxReq5.Items.AddRange(qlecturer.ToArray());
        }

        private void comboBoxReq1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelReq1.ForeColor = Color.Green;
            labelReq2.ForeColor = Color.Black;
            labelReq3.ForeColor = Color.Black;
            labelReq4.ForeColor = Color.Black;
            labelReq5.ForeColor = Color.Black;

            var qreq1 = (from student in dean.students
                         join statement in dean.statement on student.keyStudent equals statement.KeyStudent
                         where student.Group == comboBoxReq1.SelectedItem.ToString()
                         select statement.Grade).Average();

            MessageBox.Show($"Средний балл студентов по группе {comboBoxReq1.SelectedItem.ToString()} - {qreq1}%", "Информация");
        }

        private void comboBoxReq2_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelReq1.ForeColor = Color.Black;
            labelReq2.ForeColor = Color.Green;
            labelReq3.ForeColor = Color.Black;
            labelReq4.ForeColor = Color.Black;
            labelReq5.ForeColor = Color.Black;

            var qreq2 = (from theme in dean.themes
                         join statement in dean.statement on theme.Key equals statement.KeyTheme
                         where theme.Name == comboBoxReq2.SelectedItem.ToString()
                         select statement.Grade).Average();

            MessageBox.Show($"Средний балл по предмету {comboBoxReq2.SelectedItem.ToString()} - {qreq2}%", "Информация");
        }

        private void comboBoxReq3_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelReq1.ForeColor = Color.Black;
            labelReq2.ForeColor = Color.Black;
            labelReq3.ForeColor = Color.Green;
            labelReq4.ForeColor = Color.Black;
            labelReq5.ForeColor = Color.Black;

            var qstatement = from statementLinq in dean.statement
                             join student in dean.students on statementLinq.KeyStudent equals student.keyStudent
                             join lecturer in dean.lecturers on statementLinq.KeyLecturer equals lecturer.Key
                             join theme in dean.themes on statementLinq.KeyTheme equals theme.Key
                             where student.Fullname == comboBoxReq3.SelectedItem.ToString()
                             select new
                             {
                                 student = student.Fullname,
                                 lecturer = lecturer.Fullname,
                                 theme = theme.Name,
                                 date = statementLinq.Date,
                                 grade = statementLinq.Grade
                             };

            dataGridViewReq.DataSource = qstatement.ToList();
            dataGridViewReq.Columns[0].HeaderText = "Студент";
            dataGridViewReq.Columns[1].HeaderText = "Преподаватель";
            dataGridViewReq.Columns[2].HeaderText = "Предмет";
            dataGridViewReq.Columns[3].HeaderText = "Дата";
            dataGridViewReq.Columns[4].HeaderText = "Оценка %";
        }

        private void comboBoxReq4_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelReq1.ForeColor = Color.Black;
            labelReq2.ForeColor = Color.Black;
            labelReq3.ForeColor = Color.Black;
            labelReq4.ForeColor = Color.Green;
            labelReq5.ForeColor = Color.Black;

            var qstatement = from statementLinq in dean.statement
                             join student in dean.students on statementLinq.KeyStudent equals student.keyStudent
                             join lecturer in dean.lecturers on statementLinq.KeyLecturer equals lecturer.Key
                             join theme in dean.themes on statementLinq.KeyTheme equals theme.Key
                             where theme.Name == comboBoxReq4.SelectedItem.ToString()
                             select new
                             {
                                 student = student.Fullname,
                                 lecturer = lecturer.Fullname,
                                 theme = theme.Name,
                                 date = statementLinq.Date,
                                 grade = statementLinq.Grade
                             };

            dataGridViewReq.DataSource = qstatement.ToList();
            dataGridViewReq.Columns[0].HeaderText = "Студент";
            dataGridViewReq.Columns[1].HeaderText = "Преподаватель";
            dataGridViewReq.Columns[2].HeaderText = "Предмет";
            dataGridViewReq.Columns[3].HeaderText = "Дата";
            dataGridViewReq.Columns[4].HeaderText = "Оценка %";
        }

        private void comboBoxReq5_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelReq1.ForeColor = Color.Black;
            labelReq2.ForeColor = Color.Black;
            labelReq3.ForeColor = Color.Black;
            labelReq4.ForeColor = Color.Black;
            labelReq5.ForeColor = Color.Green;

            var qstatement = from statementLinq in dean.statement
                             join student in dean.students on statementLinq.KeyStudent equals student.keyStudent
                             join lecturer in dean.lecturers on statementLinq.KeyLecturer equals lecturer.Key
                             join theme in dean.themes on statementLinq.KeyTheme equals theme.Key
                             where lecturer.Fullname == comboBoxReq5.SelectedItem.ToString()
                             select new
                             {
                                 student = student.Fullname,
                                 lecturer = lecturer.Fullname,
                                 theme = theme.Name,
                                 date = statementLinq.Date,
                                 grade = statementLinq.Grade
                             };

            dataGridViewReq.DataSource = qstatement.ToList();
            dataGridViewReq.Columns[0].HeaderText = "Студент";
            dataGridViewReq.Columns[1].HeaderText = "Преподаватель";
            dataGridViewReq.Columns[2].HeaderText = "Предмет";
            dataGridViewReq.Columns[3].HeaderText = "Дата";
            dataGridViewReq.Columns[4].HeaderText = "Оценка %";
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            textBoxFullnameStudent.Text = "";
            numericUpDownRecordStudent.Value = 1;
            textBoxGroupStudent.Text = "";

            groupBox1.Visible = true;
        }

        private void buttonSaveStudent_Click(object sender, EventArgs e)
        {
            dean.AddStudent(textBoxFullnameStudent.Text, Convert.ToInt32(numericUpDownRecordStudent.Value), textBoxGroupStudent.Text);

            dataGridViewStudent.DataSource = null;
            dataGridViewStudent.DataSource = dean.students;
            dataGridViewStudent.CurrentCell = dataGridViewStudent[1, dataGridViewStudent.Rows.Count - 1];
            dataGridViewStudent.Refresh();
            dataGridViewStudent.Columns[0].Visible = false;
            dataGridViewStudent.Columns[1].HeaderText = "ФИО";
            dataGridViewStudent.Columns[2].HeaderText = "№ зачётки";
            dataGridViewStudent.Columns[3].HeaderText = "Группа";

            textBoxFullnameStudent.Text = "";
            numericUpDownRecordStudent.Value = 1;
            textBoxGroupStudent.Text = "";

            MessageBox.Show("Студент добавлен!", "Успех");
            groupBox1.Visible = false;
            buttonRewrite.Enabled = true;
        }

        private void buttonRewrite_Click(object sender, EventArgs e)
        {
            string filesdir = textBoxDirection.Text.Trim();

            Program.FileWrite_Student(filesdir + "\\студенты.txt");
            Program.FileRead_Lecturer(filesdir + "\\преподаватели.txt");
            Program.FileRead_Theme(filesdir + "\\предметы.txt");
            Program.FileRead_Statement(filesdir + "\\ведомость.txt");

            MessageBox.Show("Файл перезаписан!", "Успех");
            buttonRewrite.Enabled = false;
        }

        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            int key = (int)(dataGridViewStudent.CurrentRow.Cells[0].Value);
            string name = (string)(dataGridViewStudent.CurrentRow.Cells[1].Value);
            int recordbook = (int)(dataGridViewStudent.CurrentRow.Cells[2].Value);
            string group = (string)(dataGridViewStudent.CurrentRow.Cells[3].Value);


            if (MessageBox.Show($"Отчислить студента \"{name}\"?", "Отчисление студента", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                foreach (Student st in dean.students)
                {
                    if (st.keyStudent == key)
                    {
                        dean.students.Remove(st);
                        break;
                    }
                }
            }
            dean.statement.RemoveAll(st => (st.KeyStudent == key));

            dataGridViewStudent.DataSource = null;
            dataGridViewStudent.DataSource = dean.students;
            dataGridViewStudent.Columns[0].Visible = false;
            dataGridViewStudent.Columns[1].HeaderText = "ФИО";
            dataGridViewStudent.Columns[2].HeaderText = "№ зачётки";
            dataGridViewStudent.Columns[3].HeaderText = "Группа";

            var qstatement = from statementLinq in dean.statement
                             join student in dean.students on statementLinq.KeyStudent equals student.keyStudent
                             join lecturer in dean.lecturers on statementLinq.KeyLecturer equals lecturer.Key
                             join theme in dean.themes on statementLinq.KeyTheme equals theme.Key
                             select new
                             {
                                 student = student.Fullname,
                                 lecturer = lecturer.Fullname,
                                 theme = theme.Name,
                                 date = statementLinq.Date,
                                 grade = statementLinq.Grade
                             };

            dataGridViewStatement.DataSource = null;
            dataGridViewStatement.DataSource = qstatement.ToList();
            dataGridViewStatement.Columns[0].HeaderText = "Студент";
            dataGridViewStatement.Columns[1].HeaderText = "Преподаватель";
            dataGridViewStatement.Columns[2].HeaderText = "Предмет";
            dataGridViewStatement.Columns[3].HeaderText = "Дата";
            dataGridViewStatement.Columns[4].HeaderText = "Оценка %";

            buttonRewrite.Enabled = true;
        }

        private void buttonCancelStudent_Click(object sender, EventArgs e)
        {
            textBoxFullnameStudent.Text = "";
            numericUpDownRecordStudent.Value = 1;
            textBoxGroupStudent.Text = "";

            groupBox1.Visible = false;
        }
    }
}

// C:\Users\Вадим\Desktop\Саня ИС