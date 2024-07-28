using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProsysExam.API.Models;

namespace ProsysExam.API.Data.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Number).IsRequired();
            builder.Property(e => e.FirstName).IsRequired().HasMaxLength(30);
            builder.Property(e => e.LastName).IsRequired().HasMaxLength(30);
            builder.Property(e => e.Class).IsRequired();
        }
    }
}
