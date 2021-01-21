using ScrumTaskBoard.Business.Interfaces;
using ScrumTaskBoard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumTaskBoardProject.Presentation
{
    public partial class FrmDurumDegis : Form
    {
        public int _Id { get; set; }

        private ITaskService _taskService;
        private IUserService _userService;
        private IProjeService _projeService;
        private IDurumService _durumService;
        private ITaskStateService _taskStateService;

        public FrmDurumDegis(ITaskService taskService, IUserService userService, IProjeService projeService
            , IDurumService durumService, ITaskStateService taskStateService)
        {
            InitializeComponent();
            _taskService = taskService;
            _userService = userService;
            _projeService = projeService;
            _durumService = durumService;
            _taskStateService = taskStateService;
        }

        private void FormKapa()
        {
            FrmTaskBoard taskBoard = new FrmTaskBoard(_taskService, _userService, _projeService, _durumService, _taskStateService);
            taskBoard.Show();
            this.Hide();
        }

        private void Guncelle(string durumName)
        {
            var durum = _durumService.GetirAdIle(durumName);
            var taskState = _taskStateService.GetirIdile(_Id);
            var task = _taskService.GetirIdile(taskState.TaskId);

            _taskService.Guncelle(new ScrumTaskBoard.Entities.Concrete.Task
            {
                Id = task.Id,
                Name = task.Name,
                Description = task.Description,
                Note = task.Note,
                TaskDate = task.TaskDate,
                PreDate = task.PreDate,
                FinishDate = task.FinishDate,
                UserId = task.UserId,
                DurumId = durum.Id
            });

            _taskStateService.Guncelle(new TaskState
            {
                Id = _Id,
                DurumId = durum.Id,
                Description = taskState.Description,
                UserId = taskState.UserId,
                TaskId = taskState.TaskId
            });
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            Guncelle("Todo");

            FormKapa();
        }

        private void btnInProgress_Click(object sender, EventArgs e)
        {
            Guncelle("In Progress");

            FormKapa();
        }

        private void btnRevision_Click(object sender, EventArgs e)
        {
            Guncelle("Revision");

            FormKapa();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Guncelle("Check");

            FormKapa();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Guncelle("Done");

            FormKapa();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormKapa();
        }
    }
}
