using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProsysExam.API.Models;

namespace ProsysExam.API.Data.Configurations
{
    public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.LessonCode).IsRequired().HasMaxLength(3).IsFixedLength();
            builder.Property(e => e.LessonName).IsRequired().HasMaxLength(30);
            builder.Property(e => e.Class).IsRequired();
            builder.Property(e => e.TeacherFirstName).IsRequired().HasMaxLength(20);
            builder.Property(e => e.TeacherLastName).IsRequired().HasMaxLength(20);
        }
    }
}
