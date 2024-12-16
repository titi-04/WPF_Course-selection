using System.Collections.ObjectModel;

namespace WPF_5
{
    class Teacher
    {
        public string TeacherName { get; set; }//教師姓名

        public ObservableCollection<Course> TeachingCourse { get; set; }
        //ObservableCollection<T> 類別是一個泛型集合，提供通知項目變更的功能。
        //宣告教授課程

        //建構函式
        public Teacher(string teacherName)
        {
            TeacherName = teacherName;
            TeachingCourse = new ObservableCollection<Course>();//定義教授課程
        }
    }
}
