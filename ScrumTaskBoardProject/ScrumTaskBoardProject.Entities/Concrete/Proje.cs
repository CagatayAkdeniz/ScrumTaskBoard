using ScrumTaskBoard.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTaskBoard.Entities.Concrete
{
    public class Proje: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<User> Users { get; set; }
    }
}
