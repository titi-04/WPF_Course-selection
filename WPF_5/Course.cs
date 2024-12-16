namespace WPF_5
{
    class Course
    {
        public string CourseName { get; set; }//課程名稱
        public string Type { get; set; }//課程類型(必修/選修)
        public int Point { get; set; }//學分
        public string OpeningClass { get; set; }//開課班級
        public Teacher Tutor { get; set; }//授課教師
    }
}
