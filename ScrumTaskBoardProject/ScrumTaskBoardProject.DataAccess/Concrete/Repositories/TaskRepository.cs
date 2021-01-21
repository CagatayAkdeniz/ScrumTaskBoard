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
    public class TaskRepository : GenericRepository<Task>, ITaskDal
    {
        public List<Task> GetirTumTablolarla()
        {
            using (var context = new ScrumTaskBoardContext())
            {
                return context.Tasks.Include(x => x.User).Include(x => x.Durum).ToList();
            }
        }

        public Task GetirUsersById(int id)
        {
            using (var context = new ScrumTaskBoardContext())
            {
                return context.Tasks.Include(x => x.User).Where(x => x.Id == id).FirstOrDefault();
            }
        }
    }
}
