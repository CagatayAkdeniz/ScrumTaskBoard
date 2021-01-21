using ScrumTaskBoard.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTaskBoard.Entities.Concrete
{
    public class TaskState: IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public int TaskId { get; set; }
        public Task Task { get; set; }

        public int? DurumId { get; set; }
        public Durum Durum { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }
    }
}
