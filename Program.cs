using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkSanya
{
    public class Student
    {
        private int keystudent;
        static private int max_id = 0;
        public int keyStudent { get => keystudent; }

        public Student(int key, string fullname, int studentRecordbook, string group)
        {
            keystudent = key;
            if (keystudent > max_id) max_id = keystudent;
            Fullname = fullname;
            StudentRecordbook = studentRecordbook;
            Group = group;
        }

        public Student(string fullname, int studentRecordbook, string group)
        {
            keystudent = ++max_id;
            if (keystudent > max_id) max_id = keystudent;
            Fullname = fullname;
            StudentRecordbook = studentRecordbook;
            Group = group;
        }

        public string Fullname { get; set; }
        public int StudentRecordbook { get; set; }
        public string Group { get; set; }
    }

    public class Lecturer
    {
        public Lecturer(int key, string fullname, string degree, string experience)
        {
            Key = key;
            Fullname = fullname;
            Degree = degree;
            Experience = experience;
        }

        public int Key { get; set; }
        public string Fullname { get; set; }
        public string Degree { get; set; }
        public string Experience { get; set; }
    }

    public class Theme
    {
        public Theme(int key, string name, string reporting)
        {
            Key = key;
            Name = name;
            Reporting = reporting;
        }

        public int Key { get; set; }
        public string Name { get; set; }
        public string Reporting { get; set; }
    }

    public class Statement
    {
        public Statement(int keyStudent, int keyLecturer, int keyTheme, DateTime date, double grade)
        {
            KeyStudent = keyStudent;
            KeyLecturer = keyLecturer;
            KeyTheme = keyTheme;
            Date = date;
            Grade = grade;
        }

        public int KeyStudent { get; set; }
        public int KeyLecturer { get; set; }
        public int KeyTheme { get; set; }
        public DateTime Date { get; set; }
        public double Grade { get; set; }

    }

    public class Dean
    {
        public static Dean dean;
        private Dean()
        {
            StudentList = new List<Student>();
            LecturerList = new List<Lecturer>();
            ThemeList = new List<Theme>();
            StatementList = new List<Statement>();
        }
        public static Dean GetDean()
        {
            if (dean == null) dean = new Dean();
            return dean;
        }
        private List<Student> StudentList;
        private List<Lecturer> LecturerList;
        private List<Theme> ThemeList;
        private List<Statement> StatementList;

        public List<Student> students { get => StudentList; }
        public List<Lecturer> lecturers { get => LecturerList; }
        public List<Theme> themes { get => ThemeList; }
        public List<Statement> statement { get => StatementList; }

        public void AddStudent(int key, string fullname, int studentrecordbook, string group)
        {
            StudentList.Add(new Student(key, fullname, studentrecordbook, group));
        }
        public void AddStudent(string fullname, int studentrecordbook, string group)
        {
            StudentList.Add(new Student(fullname, studentrecordbook, group));
        }
        public void AddLecturer(int key, string fullname, string degree, string experience)
        {
            LecturerList.Add(new Lecturer(key, fullname, degree, experience));
        }
        public void AddTheme(int key, string name, string reporting)
        {
            ThemeList.Add(new Theme(key, name, reporting));
        }
        public void AddStatement(int keyStudent, int keyLecturer, int KeyTheme, DateTime date, double grade)
        {
            StatementList.Add(new Statement(keyStudent, keyLecturer, KeyTheme, date, grade));
        }
    }

    internal static class Program
    { 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void FileRead_Student(string path)
        {
            Dean dean = Dean.GetDean();
            StreamReader file = new StreamReader(path, System.Text.Encoding.UTF8);
            string studentdata;
            while ((studentdata = file.ReadLine()) != null)
            {
                string[] studentdataSplit = new string[3];
                studentdataSplit = studentdata.Split(';');
                dean.AddStudent(
                    Convert.ToInt32(studentdataSplit[0]),
                    studentdataSplit[1],
                    Convert.ToInt32(studentdataSplit[2]),
                    studentdataSplit[3]);
            }
            file.Close();
        }
        public static void FileWrite_Student(string path)
        {
            Dean dean = Dean.GetDean();
            StreamWriter file = new StreamWriter(path, false, System.Text.Encoding.UTF8);
            System.Globalization.CultureInfo enCultureInfo = System.Globalization.CultureInfo.InvariantCulture;
            foreach (Student st in dean.students)
            {
                file.WriteLine(st.keyStudent.ToString() + ";" + st.Fullname + ";" + st.StudentRecordbook + ";" + st.Group);
            }
            file.Close();
        }
        public static void FileRead_Lecturer(string path)
        {
            Dean dean = Dean.GetDean();
            StreamReader file = new StreamReader(path, System.Text.Encoding.UTF8);
            string lecturerdata;
            while ((lecturerdata = file.ReadLine()) != null)
            {
                string[] lecturerdataSplit = new string[3];
                lecturerdataSplit = lecturerdata.Split(';');
                dean.AddLecturer(
                    Convert.ToInt32(lecturerdataSplit[0]),
                    lecturerdataSplit[1],
                    lecturerdataSplit[2],
                    lecturerdataSplit[3]);
            }
            file.Close();
        }
        public static void FileRead_Theme(string path)
        {
            Dean dean = Dean.GetDean();
            StreamReader file = new StreamReader(path, System.Text.Encoding.UTF8);
            string themedata;
            while ((themedata = file.ReadLine()) != null)
            {
                string[] themedataSplit = new string[2];
                themedataSplit = themedata.Split(';');
                dean.AddTheme(Convert.ToInt32(themedataSplit[0]), themedataSplit[1], themedataSplit[2]);
            }
            file.Close();
        }
        public static void FileRead_Statement(string path)
        {
            Dean dean = Dean.GetDean();
            StreamReader file = new StreamReader(path, System.Text.Encoding.UTF8);
            string statementdata;
            while ((statementdata = file.ReadLine()) != null)
            {
                string[] statementdataSplit = new string[4];
                statementdataSplit = statementdata.Split(';');
                dean.AddStatement(
                    Convert.ToInt32(statementdataSplit[0]),
                    Convert.ToInt32(statementdataSplit[1]),
                    Convert.ToInt32(statementdataSplit[2]),
                    DateTime.ParseExact(statementdataSplit[3], "dd-MM-yyyy", null),
                    Convert.ToDouble(statementdataSplit[4]));
            }
            file.Close();
        }
    }
}
