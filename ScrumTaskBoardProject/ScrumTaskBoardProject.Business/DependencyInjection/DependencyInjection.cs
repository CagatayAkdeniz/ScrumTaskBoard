using Ninject.Modules;
using ScrumTaskBoard.Business.Concrete;
using ScrumTaskBoard.Business.Interfaces;
using ScrumTaskBoard.DataAccess.Concrete.Repositories;
using ScrumTaskBoard.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTaskBoard.Business.DependencyInjection
{
    public class DependencyInjection : NinjectModule
    {
        public override void Load()
        {
            Bind<IProjeDal>().To<ProjeRepository>();
            Bind<IProjeService>().To<ProjeManager>();

            Bind<IUserDal>().To<UserRepository>();
            Bind<IUserService>().To<UserManager>();

            Bind<ITaskDal>().To<TaskRepository>();
            Bind<ITaskService>().To<TaskManager>();

            Bind<IDurumDal>().To<DurumRepository>();
            Bind<IDurumService>().To<DurumManager>();

            Bind<ITaskStateDal>().To<TaskStateRepository>();
            Bind<ITaskStateService>().To<TaskStateManager>();
        }
    }
}
