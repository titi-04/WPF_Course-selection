namespace WPF_5
{
    internal class Record
    {
        public Student SelectedStudent { get; set; }
        public Course SelectedCourse { get; set; }
        public override string ToString()
        {
            return $"{SelectedStudent.StudentName} / {SelectedCourse.CourseName}";
        }

        public bool Equals(Record record)
        {
            return SelectedStudent.StudentName == record.SelectedStudent.StudentName && SelectedCourse.CourseName == record.SelectedCourse.CourseName;
        }
    }
}
