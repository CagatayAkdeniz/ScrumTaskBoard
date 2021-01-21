using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScrumTaskBoard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTaskBoard.DataAccess.Concrete.Mapping
{
    public class ProjeMap : IEntityTypeConfiguration<Proje>
    {
        public void Configure(EntityTypeBuilder<Proje> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}
