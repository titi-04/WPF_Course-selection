namespace WPF_5
{
    internal class Record
    {
        public Student SelectedStudent { get; set; }//選擇的學生
        public Course SelectedCourse { get; set; }//選擇的課程
        public override string ToString()//覆寫ToString方法
        {
            return $"{SelectedStudent.StudentName} / {SelectedCourse.CourseName}";//回傳學生姓名/課程名稱
        }

        public bool Equals(Record record)//定義Equals方法 用來比較兩個Record物件是否相等
        {
            //如果選擇的學生名稱等於record物件的選擇學生名稱 且 選擇的課程名稱等於record物件的選擇課程名稱
            return SelectedStudent.StudentName == record.SelectedStudent.StudentName && SelectedCourse.CourseName == record.SelectedCourse.CourseName;
        }
    }
}
