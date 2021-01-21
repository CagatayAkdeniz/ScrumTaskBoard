using ScrumTaskBoard.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ScrumTaskBoard.DataAccess.Interfaces
{
    public interface IGenericDal<Entity> where Entity : class,IEntity,new()
    {
        void Ekle(Entity entity);
        void Sil(Entity entity);
        void Guncelle(Entity entity);
        Entity GetirByFilter(Expression<Func<Entity, bool>> filter);
        Entity GetirIdile(int id);
        List<Entity> GetirHepsi();
    }
}
