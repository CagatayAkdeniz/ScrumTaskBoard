using ScrumTaskBoard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTaskBoard.DataAccess.Interfaces
{
    public interface ITaskDal: IGenericDal<Task>
    {
        List<Task> GetirTumTablolarla();
        Task GetirUsersById(int id);
    }
}
