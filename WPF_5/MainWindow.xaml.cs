using System.Windows;

namespace WPF_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //宣告並定義所需要的資料 
        List<Student> students = new List<Student>();//建立學生清單(所有學生的列表)
        List<Teacher> teachers = new List<Teacher>();//建立教師清單(所有教師的列表)
        List<Course> courses = new List<Course>();//建立課程清單(所有課程的列表)
        List<Record> records = new List<Record>();//建立選課紀錄清單(所有選課紀錄的列表)

        //選取的學生、教師、課程、選課紀錄 初始化為空
        Student selectedStudent = null;
        Teacher selectedTeacher = null;
        Course selectedCourse = null;
        Record selectedRecord = null;

        public MainWindow()
        {
            InitializeComponent();
            InitializeData();//初始化資料
        }

        private void InitializeData()
        {
            //新增學生資料 連結至cmbStudent
            students.Add(new Student { StudentId = "S001", StudentName = "陳小明" });
            students.Add(new Student { StudentId = "S002", StudentName = "林小華" });
            students.Add(new Student { StudentId = "S003", StudentName = "張小英" });
            cmbStudent.ItemsSource = students;//將學生清單連結至cmbStudent
            cmbStudent.SelectedIndex = 0;//預設選取第一筆資料

            //新增教師資料以及所授課程
            Teacher teacher1 = new Teacher("陳定宏");
            teacher1.TeachingCourse.Add(new Course { CourseName ="視窗程式設計",OpeningClass ="四技資工二乙",Point = 3, Tutor=teacher1,Type="選修"});
            teacher1.TeachingCourse.Add(new Course { CourseName = "視窗程式設計", OpeningClass = "四技資工三甲", Point = 3, Tutor = teacher1, Type = "選修" });
            teacher1.TeachingCourse.Add(new Course { CourseName = "資料庫系統", OpeningClass = "四技資工二甲", Point = 3, Tutor = teacher1, Type = "必修" });
            teachers.Add(teacher1);//將教師資料加入教師清單

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

            tvTeacher.ItemsSource = teachers;//將教師清單連結至tvTeacher

            //新增課程資料
            foreach (Teacher teacher in teachers)
            {
                foreach (Course course in teacher.TeachingCourse)
                {
                    courses.Add(course);
                }
            }

            lbCourse.ItemsSource = courses;
        }

        private void tvTeacher_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (tvTeacher.SelectedItem is Teacher)//選取教師
            {
                selectedTeacher = tvTeacher.SelectedItem as Teacher;//將選取的教師資料存入selectedTeacher
                statusLable.Content = $"選取教師：{selectedTeacher.TeacherName}";//顯示選取的教師名稱
            }
            if (tvTeacher.SelectedItem is Course)//選取課程
            {
                selectedCourse = tvTeacher.SelectedItem as Course;//將選取的課程資料存入selectedCourse
                statusLable.Content = $"選取課程：{selectedCourse.CourseName}";//顯示選取的課程名稱
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (selectedStudent == null || selectedCourse == null)//判斷是否選取學生或課程
            {
                MessageBox.Show("請選取學生或課程");
                return;
            }
            else 
            {
                Record record = new Record()//建立選課紀錄
                {
                    SelectedStudent = selectedStudent, 
                    SelectedCourse = selectedCourse//將選取的學生和課程存入選課紀錄
                };

                foreach (Record r in records)//判斷是否已選取此學生和課程
                {
                    if (r.Equals(record))//若已選取此學生和課程，則顯示訊息並返回
                    {
                        MessageBox.Show("此學生已選取此課程");
                        return;
                    }
                }

                records.Add(record);//將選課紀錄加入選課紀錄清單
                lvRecord.ItemsSource = records;//將選課紀錄清單連結至lvRecord
                lvRecord.Items.Refresh();//重新整理lvRecord
            }
        }

        private void cmbStudent_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            selectedStudent = cmbStudent.SelectedItem as Student;//將選取的學生資料存入selectedStudent
            statusLable.Content = $"選取學生：{selectedStudent.StudentName}";//顯示選取的學生名稱
        }

        private void lbCourse_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            selectedCourse = lbCourse.SelectedItem as Course;//將選取的課程資料存入selectedCourse
            statusLable.Content = $"選取課程：{selectedCourse.CourseName}";//顯示選取的課程名稱
        }
    }
}