using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProsysExam.API.Models;

namespace ProsysExam.API.Data.Configurations
{
    public class ExamConfiguration : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.LessonCode).IsRequired().HasMaxLength(3).IsFixedLength();
            builder.Property(e => e.StudentNumber).IsRequired();
            builder.Property(e => e.ExamDate).IsRequired();
            builder.Property(e => e.Price).IsRequired();
        }
    }
}
