using ScrumTaskBoard.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTaskBoard.Business.Interfaces
{
    public interface IGenericService<Entity> where Entity:class,IEntity,new()
    {
        void Ekle(Entity entity);
        void Sil(Entity entity);
        void Guncelle(Entity entity);
        Entity GetirIdile(int id);
        List<Entity> GetirHepsi();
    }
}
