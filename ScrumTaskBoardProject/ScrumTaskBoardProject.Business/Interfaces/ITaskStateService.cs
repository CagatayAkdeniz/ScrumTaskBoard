using ScrumTaskBoard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTaskBoard.Business.Interfaces
{
    public interface ITaskStateService: IGenericService<TaskState>
    {
        TaskState GetirByTaskId(int taskId);
        List<TaskState> GetirTumTablolarla(string durumName);
    }
}
