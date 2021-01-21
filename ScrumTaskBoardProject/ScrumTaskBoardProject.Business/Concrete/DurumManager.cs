using ScrumTaskBoard.Business.Interfaces;
using ScrumTaskBoard.DataAccess.Interfaces;
using ScrumTaskBoard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTaskBoard.Business.Concrete
{
    public class DurumManager : IDurumService
    {
        private IDurumDal _durumDal;
        public DurumManager(IDurumDal durumDal)
        {
            _durumDal = durumDal;
        }

        public void Ekle(Durum entity)
        {
            _durumDal.Ekle(entity);
        }

        public Durum GetirAdIle(string durumName)
        {
            return _durumDal.GetirByFilter(x => x.Name == durumName);
        }

        public List<Durum> GetirHepsi()
        {
            return _durumDal.GetirHepsi();
        }

        public Durum GetirIdile(int id)
        {
            return _durumDal.GetirIdile(id);
        }

        public void Guncelle(Durum entity)
        {
            _durumDal.Guncelle(entity);
        }

        public void Sil(Durum entity)
        {
            _durumDal.Sil(entity);
        }
    }
}

