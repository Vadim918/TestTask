using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestTask.Core.Entities;

namespace TestTask.Infrastructure.Configurations
{
    internal sealed class MainConfiguration : IEntityTypeConfiguration<Main>
    {
        public void Configure(EntityTypeBuilder<Main> builder)
        {
            builder.ToTable("Main");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.LongUrl).IsRequired().HasMaxLength(1024);
            builder.Property(x => x.EditableUrl).IsRequired().HasMaxLength(500);
            builder.Property(x => x.Count).HasColumnType("int");
            builder.Property(x => x.Date).HasColumnType("date");
        }
    }
}