using Microsoft.EntityFrameworkCore;
using ScrumTaskBoard.DataAccess.Concrete.Mapping;
using ScrumTaskBoard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTaskBoard.DataAccess.Concrete.Contexts
{
    public class ScrumTaskBoardContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ScrumTaskBoardDB;integrated security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DurumMap());
            modelBuilder.ApplyConfiguration(new ProjeMap());
            modelBuilder.ApplyConfiguration(new TaskMap());
            modelBuilder.ApplyConfiguration(new TaskStateMap());
            modelBuilder.ApplyConfiguration(new UserMap());
        }

        public DbSet<Proje> Projeler { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Durum> Durumlar { get; set; }
        public DbSet<TaskState> TaskStates { get; set; }
    }
}
