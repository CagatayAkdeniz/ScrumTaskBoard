using ScrumTaskBoard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTaskBoard.Business.Interfaces
{
    public interface IProjeService: IGenericService<Proje>
    {
        Proje GetirAdIle(string projeName);
    }
}
