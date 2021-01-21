using ScrumTaskBoard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTaskBoard.Business.Interfaces
{
    public interface IUserService: IGenericService<User>
    {
        User GetirAdIle(string userName);
    }
}
