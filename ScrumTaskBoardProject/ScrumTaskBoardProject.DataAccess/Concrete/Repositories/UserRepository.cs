using ScrumTaskBoard.DataAccess.Interfaces;
using ScrumTaskBoard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTaskBoard.DataAccess.Concrete.Repositories
{
    public class UserRepository: GenericRepository<User>, IUserDal
    {
    }
}
