using ScrumTaskBoard.Business.Interfaces;
using ScrumTaskBoard.DataAccess.Interfaces;
using ScrumTaskBoard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTaskBoard.Business.Concrete
{
    public class TaskStateManager: ITaskStateService
    {
        private ITaskStateDal _taskStateDal;
        public TaskStateManager(ITaskStateDal taskStateDal)
        {
            _taskStateDal = taskStateDal;
        }

        public void Ekle(TaskState entity)
        {
            _taskStateDal.Ekle(entity);
        }

        public TaskState GetirByTaskId(int taskId)
        {
            return _taskStateDal.GetirByFilter(x => x.TaskId == taskId);
        }

        public List<TaskState> GetirHepsi()
        {
            return _taskStateDal.GetirHepsi();
        }

        public TaskState GetirIdile(int id)
        {
            return _taskStateDal.GetirIdile(id);
        }

        public List<TaskState> GetirTumTablolarla(string durumName)
        {
            return _taskStateDal.GetirTumTablolarla(durumName);
        }

        public void Guncelle(TaskState entity)
        {
            _taskStateDal.Guncelle(entity);
        }

        public void Sil(TaskState entity)
        {
            _taskStateDal.Sil(entity);
        }
    }
}
