using ScrumTaskBoard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTaskBoard.DataAccess.Interfaces
{
    public interface ITaskStateDal: IGenericDal<TaskState>
    {
        List<TaskState> GetirTumTablolarla(string durumName);
    }
}
