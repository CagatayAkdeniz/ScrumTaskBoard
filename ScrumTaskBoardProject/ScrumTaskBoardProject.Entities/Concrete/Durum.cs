using ScrumTaskBoard.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTaskBoard.Entities.Concrete
{
    public  class Durum: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Task> Tasks { get; set; }
        
        public List<TaskState> TaskStates { get; set; }
    }
}
