using ScrumTaskBoard.Business.Interfaces;
using ScrumTaskBoardProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumTaskBoardProject.Presentation.TaskForms
{
    public partial class FrmTaskListGuncelle : Form
    {
        private ITaskService _taskService;
        private IUserService _userService;
        private IProjeService _projeService;
        private IDurumService _durumService;
        private ITaskStateService _taskStateService;

        public FrmTaskListGuncelle(ITaskService taskService, IUserService userService, IProjeService projeService
            , IDurumService durumService, ITaskStateService taskStateService)
        {
            InitializeComponent();
            _taskService = taskService;
            _userService = userService;
            _projeService = projeService;
            _durumService = durumService;
            _taskStateService = taskStateService;
        }

        private void FrmTaskListGuncelle_Load(object sender, EventArgs e)
        {
            var tasks = _taskService.GetirTumTablolarla();

            List<TaskListDto> models = new List<TaskListDto>();
            foreach (var item in tasks)
            {
                TaskListDto model = new TaskListDto();
                model.Id = item.Id;
                model.Name = item.Name;
                model.Description = item.Description;
                model.Note = item.Note;
                model.FinishDate = item.FinishDate;
                model.PreDate = item.PreDate;
                model.TaskDate = item.TaskDate;
                model.UserId = item.UserId;
                model.DurumId = item.DurumId;
                model.UserName = item.User.Name;
                model.Durum = item.Durum.Name;
                models.Add(model);
            }

            dgwTaskList.DataSource = models;
        }

        private void dgwTaskList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgwTaskList.CurrentRow.Cells[0].Value;
            FrmTaskGuncelle frmTaskGuncelle = new FrmTaskGuncelle(_taskService,_userService,_projeService,_durumService,_taskStateService);
            frmTaskGuncelle._Id = id;
            frmTaskGuncelle.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAnaMenu frmAnaMenu = new FrmAnaMenu();
            frmAnaMenu.Show();
            this.Close();
        }
    }
}
