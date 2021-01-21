using ScrumTaskBoard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTaskBoard.Business.Interfaces
{
    public interface ITaskService: IGenericService<Task>
    {
        List<Task> GetirTumTablolarla();
        Task GetirUsersById(int id);
    }
}
