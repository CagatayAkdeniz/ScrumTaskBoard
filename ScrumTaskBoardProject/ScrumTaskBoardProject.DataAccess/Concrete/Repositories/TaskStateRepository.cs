using Microsoft.EntityFrameworkCore;
using ScrumTaskBoard.DataAccess.Concrete.Contexts;
using ScrumTaskBoard.DataAccess.Interfaces;
using ScrumTaskBoard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScrumTaskBoard.DataAccess.Concrete.Repositories
{
    public class TaskStateRepository : GenericRepository<TaskState>, ITaskStateDal
    {
        public List<TaskState> GetirTumTablolarla(string durumName)
        {
            using (var context = new ScrumTaskBoardContext())
            {
                return context.TaskStates.Include(x => x.Durum).Include(x => x.User).Include(x => x.Task)
                    .Where(x => x.Durum.Name == durumName).ToList();
            }
        }
    }
}
