using ScrumTaskBoard.Business.Interfaces;
using ScrumTaskBoard.DataAccess.Interfaces;
using ScrumTaskBoard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTaskBoard.Business.Concrete
{
    public class ProjeManager: IProjeService
    {
        private IProjeDal _projeDal;
        public ProjeManager(IProjeDal projeDal)
        {
            _projeDal = projeDal;
        }

        public void Ekle(Proje entity)
        {
            _projeDal.Ekle(entity);
        }

        public Proje GetirAdIle(string projeName)
        {
            return _projeDal.GetirByFilter(x=>x.Name==projeName);
        }

        public List<Proje> GetirHepsi()
        {
            return _projeDal.GetirHepsi();
        }

        public Proje GetirIdile(int id)
        {
            return _projeDal.GetirIdile(id);
        }

        public void Guncelle(Proje entity)
        {
            _projeDal.Guncelle(entity);
        }

        public void Sil(Proje entity)
        {
            _projeDal.Sil(entity);
        }
    }
}
