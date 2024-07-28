namespace ProsysExam.API.Dtos
{
    public class ExamDto
    {
        public int Id { get; set; }
        public string LessonCode { get; set; }
        public int StudentNumber { get; set; }
        public DateTime ExamDate { get; set; }
        public decimal Price { get; set; }
    }
}
