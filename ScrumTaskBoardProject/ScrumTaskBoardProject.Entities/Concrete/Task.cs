using ScrumTaskBoard.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTaskBoard.Entities.Concrete
{
    public class Task: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public DateTime TaskDate { get; set; } = DateTime.Now;
        public DateTime PreDate { get; set; }
        public DateTime FinishDate { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }

        public int DurumId { get; set; }
        public Durum Durum { get; set; }

        public List<TaskState> TaskStates { get; set; }
    }
}
