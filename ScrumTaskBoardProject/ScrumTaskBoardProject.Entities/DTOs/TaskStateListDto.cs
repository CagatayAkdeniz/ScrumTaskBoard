using ScrumTaskBoard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTaskBoardProject.Entities.DTOs
{
    public class TaskStateListDto
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public int? TaskId { get; set; }

        public int? DurumId { get; set; }
        public string Durum { get; set; }

        public int? UserId { get; set; }
        public string User { get; set; }
    }
}
