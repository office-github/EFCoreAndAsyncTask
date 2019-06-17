using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreAndAsyncTask.Models
{
  public class StudentMap : IEntityTypeConfiguration<Student>
  {
    public void Configure(EntityTypeBuilder<Student> builder)
    {
      builder.HasKey(s => s.Id);
      builder.Property(s => s.Name).IsRequired().HasMaxLength(250);
      builder.Property(s => s.CreatedBy);
      builder.Property(s => s.UpdatedBy);
      builder.Property(s => s.CreatedDate);
      builder.Property(s => s.UpdatedDate);
    }
  }
}
