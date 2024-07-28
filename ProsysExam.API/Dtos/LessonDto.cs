namespace ProsysExam.API.Dtos
{
    public class LessonDto
    {
        public int Id { get; set; }
        public string LessonCode { get; set; }
        public string LessonName { get; set; }
        public int Class { get; set; }
        public string TeacherFirstName { get; set; }
        public string TeacherLastName { get; set; }
    }
}
