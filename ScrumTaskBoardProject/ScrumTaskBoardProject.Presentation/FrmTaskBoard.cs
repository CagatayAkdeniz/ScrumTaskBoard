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

namespace ScrumTaskBoardProject.Presentation
{
    public partial class FrmTaskBoard : Form
    {
        private ITaskService _taskService;
        private IUserService _userService;
        private IProjeService _projeService;
        private IDurumService _durumService;
        private ITaskStateService _taskStateService;

        public FrmTaskBoard(ITaskService taskService, IUserService userService, IProjeService projeService
            , IDurumService durumService, ITaskStateService taskStateService)
        {
            InitializeComponent();
            _taskService = taskService;
            _userService = userService;
            _projeService = projeService;
            _durumService = durumService;
            _taskStateService = taskStateService;
        }

        private List<TaskStateListDto> Listele(string durumName)
        {
            var taskStates = _taskStateService.GetirTumTablolarla(durumName);
            List<TaskStateListDto> models = new List<TaskStateListDto>();
            foreach (var item in taskStates)
            {
                TaskStateListDto model = new TaskStateListDto();
                model.Id = item.Id;
                model.Description = item.Description;
                model.TaskId = item.TaskId;
                model.UserId = item.UserId;
                model.User = item.User.Name;
                model.DurumId = item.DurumId;
                model.Durum = item.Durum.Name;
                models.Add(model);
            }

            return models;
        }

        private void ListToDo()
        {
            dgwToDo.DataSource = Listele("Todo");
        }

        private void ListInProgress()
        {
            dgwInProgress.DataSource = Listele("In Progress");
        }

        private void ListDone()
        {
            dgwDone.DataSource = Listele("Done");
        }

        private void ListRevision()
        {
            dgwRevision.DataSource = Listele("Revision");
        }

        private void ListCheck()
        {
            dgwCheck.DataSource = Listele("Check");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAnaMenu frmAnaMenu = new FrmAnaMenu();
            frmAnaMenu.Show();
            this.Close();
        }

        private void FrmTaskBoard_Load(object sender, EventArgs e)
        {
            ListToDo();
            ListInProgress();
            ListRevision();
            ListCheck();
            ListDone();
        }

        private void dgwToDo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgwToDo.CurrentRow.Cells[0].Value;
            FrmDurumDegis durumDegis = new FrmDurumDegis(_taskService,_userService,_projeService,_durumService,_taskStateService);
            durumDegis._Id = id;
            durumDegis.Show();
            this.Hide();
        }

        private void dgwInProgress_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgwInProgress.CurrentRow.Cells[0].Value;
            FrmDurumDegis durumDegis = new FrmDurumDegis(_taskService, _userService, _projeService, _durumService, _taskStateService);
            durumDegis._Id = id;
            durumDegis.Show();
            this.Hide();
        }

        private void dgwRevision_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgwRevision.CurrentRow.Cells[0].Value;
            FrmDurumDegis durumDegis = new FrmDurumDegis(_taskService, _userService, _projeService, _durumService, _taskStateService);
            durumDegis._Id = id;
            durumDegis.Show();
            this.Hide();
        }

        private void dgwCheck_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgwCheck.CurrentRow.Cells[0].Value;
            FrmDurumDegis durumDegis = new FrmDurumDegis(_taskService, _userService, _projeService, _durumService, _taskStateService);
            durumDegis._Id = id;
            durumDegis.Show();
            this.Hide();
        }

        private void dgwDone_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgwDone.CurrentRow.Cells[0].Value;
            FrmDurumDegis durumDegis = new FrmDurumDegis(_taskService, _userService, _projeService, _durumService, _taskStateService);
            durumDegis._Id = id;
            durumDegis.Show();
            this.Hide();
        }
    }
}
