using System.Windows;

namespace WPF_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
           students.Add(new Student { StudentId = "S001", StudentName = "陳小明" });
           students.Add(new Student { StudentId = "S002", StudentName = "林小華" });
           students.Add(new Student { StudentId = "S003", StudentName = "張小英" });
            cmbStudent.ItemsSource = students;
            cmbStudent.SelectedIndex = 0;//預設選取第一筆資料
        }
    }
}