using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScrumTaskBoard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTaskBoard.DataAccess.Concrete.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();

            builder.HasMany(x => x.Tasks).WithOne(x => x.User).HasForeignKey(x => x.UserId);
            builder.HasMany(x => x.TaskStates).WithOne(x => x.User).HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.Proje).WithMany(x => x.Users).HasForeignKey(x => x.ProjeId);
        }
    }
}
