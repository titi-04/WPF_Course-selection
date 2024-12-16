using System.Windows;

namespace WPF_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        List<Teacher> teachers = new List<Teacher>();
        List<Course> courses = new List<Course>();
        List<Record> records = new List<Record>();
        public MainWindow()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            //新增學生資料 連結至cmbStudent
            students.Add(new Student { StudentId = "S001", StudentName = "陳小明" });
            students.Add(new Student { StudentId = "S002", StudentName = "林小華" });
            students.Add(new Student { StudentId = "S003", StudentName = "張小英" });
            cmbStudent.ItemsSource = students;
            cmbStudent.SelectedIndex = 0;//預設選取第一筆資料

            //新增教師資料及所授課程
            Teacher teacher1 = new Teacher("陳定宏");
            teacher1.TeachingCourse.Add(new Course { CourseName ="視窗程式設計",OpeningClass ="四技資工二甲",Point = 3, Tutor=teacher1,Type="選修"});
            teacher1.TeachingCourse.Add(new Course { CourseName = "網頁程式設計", OpeningClass = "四技資工二乙", Point = 3, Tutor = teacher1, Type = "選修" });
            teacher1.TeachingCourse.Add(new Course { CourseName = "資料庫系統", OpeningClass = "四技資工二丙", Point = 3, Tutor = teacher1, Type = "必修" });
            teachers.Add(teacher1);

            Teacher teacher2 = new Teacher("張財榮");
            teacher2.TeachingCourse.Add(new Course { CourseName = "資料結構", OpeningClass = "四技資工二甲", Point = 3, Tutor = teacher2, Type = "必修" });
            teacher2.TeachingCourse.Add(new Course { CourseName = "作業系統", OpeningClass = "四技資工二乙", Point = 3, Tutor = teacher2, Type = "必修" });
            teacher2.TeachingCourse.Add(new Course { CourseName = "網路程式設計", OpeningClass = "四技資工二丙", Point = 3, Tutor = teacher2, Type = "選修" });
            teachers.Add(teacher2);

            Teacher teacher3 = new Teacher("吳建中");
            teacher3.TeachingCourse.Add(new Course { CourseName = "計算機概論", OpeningClass = "四技資工二甲", Point = 3, Tutor = teacher3, Type = "必修" });
            teacher3.TeachingCourse.Add(new Course { CourseName = "C#程式設計", OpeningClass = "四技資工二乙", Point = 3, Tutor = teacher3, Type = "必修" });
            teacher3.TeachingCourse.Add(new Course { CourseName = "資訊管理", OpeningClass = "四技資工二丙", Point = 3, Tutor = teacher3, Type = "選修" });
            teachers.Add(teacher3);

            tvTeacher.ItemsSource = teachers;
        }
    }
}