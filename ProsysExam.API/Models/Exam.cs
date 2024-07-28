namespace ProsysExam.API.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string LessonCode { get; set; }
        public int StudentNumber { get; set; }
        public DateTime ExamDate { get; set; }
        public int Price { get; set; }
    }
}
