using ScrumTaskBoard.Business.Interfaces;
using ScrumTaskBoard.DataAccess.Interfaces;
using ScrumTaskBoard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTaskBoard.Business.Concrete
{
    public class TaskManager: ITaskService
    {
        private ITaskDal _taskDal;
        public TaskManager(ITaskDal taskDal)
        {
            _taskDal = taskDal;
        }

        public void Ekle(Task entity)
        {
            _taskDal.Ekle(entity);
        }

        public List<Task> GetirHepsi()
        {
            return _taskDal.GetirHepsi();
        }

        public Task GetirIdile(int id)
        {
            return _taskDal.GetirIdile(id);
        }

        public List<Task> GetirTumTablolarla()
        {
            return _taskDal.GetirTumTablolarla();
        }

        public Task GetirUsersById(int id)
        {
            return _taskDal.GetirUsersById(id);
        }

        public void Guncelle(Task entity)
        {
            _taskDal.Guncelle(entity);
        }

        public void Sil(Task entity)
        {
            _taskDal.Sil(entity);
        }
    }
}
