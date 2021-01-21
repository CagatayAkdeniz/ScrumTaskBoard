using ScrumTaskBoard.DataAccess.Concrete.Contexts;
using ScrumTaskBoard.DataAccess.Interfaces;
using ScrumTaskBoard.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ScrumTaskBoard.DataAccess.Concrete.Repositories
{
    public class GenericRepository<Entity> : IGenericDal<Entity>
        where Entity : class, IEntity, new()
    {
        public void Ekle(Entity entity)
        {
            using (var context = new ScrumTaskBoardContext())
            {
                context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                context.SaveChanges();
            }
        }

        public Entity GetirByFilter(Expression<Func<Entity, bool>> filter)
        {
            using (var context = new ScrumTaskBoardContext())
            {
                return context.Set<Entity>().FirstOrDefault(filter);
            }
        }

        public List<Entity> GetirHepsi()
        {
            using (var context = new ScrumTaskBoardContext())
            {
                return context.Set<Entity>().ToList();
            }
        }

        public Entity GetirIdile(int id)
        {
            using (var context = new ScrumTaskBoardContext())
            {
                return context.Set<Entity>().Find(id);
            }
        }

        public void Guncelle(Entity entity)
        {
            using (var context = new ScrumTaskBoardContext())
            {
                context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Sil(Entity entity)
        {
            using (var context = new ScrumTaskBoardContext())
            {
                context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
