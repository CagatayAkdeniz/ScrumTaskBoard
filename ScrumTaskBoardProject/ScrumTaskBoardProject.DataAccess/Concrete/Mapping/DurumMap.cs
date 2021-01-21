using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScrumTaskBoard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTaskBoard.DataAccess.Concrete.Mapping
{
    public class DurumMap : IEntityTypeConfiguration<Durum>
    {
        public void Configure(EntityTypeBuilder<Durum> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();

            builder.HasMany(x => x.TaskStates).WithOne(x => x.Durum).HasForeignKey(x => x.DurumId);
        }
    }
}
