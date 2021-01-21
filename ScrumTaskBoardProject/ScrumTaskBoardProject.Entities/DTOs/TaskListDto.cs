using ScrumTaskBoard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTaskBoardProject.Entities.DTOs
{
    public class TaskListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public DateTime TaskDate { get; set; } = DateTime.Now;
        public DateTime PreDate { get; set; }
        public DateTime FinishDate { get; set; }

        public int? UserId { get; set; }
        public string UserName { get; set; }

        public int DurumId { get; set; }
        public string Durum { get; set; }

    }
}
