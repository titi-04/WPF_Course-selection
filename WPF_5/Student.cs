namespace WPF_5
{
    class Student
    {   //定義所需要的資料
        public string StudentId { get; set; }//public一個存取的方法 字串 學號 get set可存可取
        public string StudentName { get; set; }//public一個存取的方法 字串 學生姓名 get set可存可取
        public override string ToString()//覆寫ToString方法
        {
            return $"{StudentId} {StudentName}";//回傳學號+學生姓名
        }
    }
}
