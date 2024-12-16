using System.Collections.ObjectModel;

namespace WPF_5
{
    class Teacher
    {
        public string TeacherName { get; set; }

        public ObservableCollection<Course> TeachingCourse { get; set; }

        public Teacher(string teacherName)
        {
            TeacherName = teacherName;
            TeachingCourse = new ObservableCollection<Course>();
        }
    }
}
