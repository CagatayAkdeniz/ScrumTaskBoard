using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScrumTaskBoard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTaskBoard.DataAccess.Concrete.Mapping
{
    public class TaskMap : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(2000).IsRequired();
            builder.Property(x => x.Note).HasMaxLength(2000);

            builder.HasOne(x => x.Durum).WithMany(x => x.Tasks).HasForeignKey(x => x.DurumId);
            builder.HasMany(x => x.TaskStates).WithOne(x => x.Task).HasForeignKey(x => x.TaskId);
        }
    }
}
