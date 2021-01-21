using ScrumTaskBoard.Business.DependencyInjection;
using ScrumTaskBoard.Business.Interfaces;
using ScrumTaskBoard.Entities.Concrete;
using ScrumTaskBoardProject.Entities.DTOs;
using ScrumTaskBoardProject.Presentation.ProjeForms;
using ScrumTaskBoardProject.Presentation.TaskForms;
using ScrumTaskBoardProject.Presentation.UserForms;
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
    public partial class FrmAnaMenu : Form
    {
        private IProjeService _projeService;
        private IUserService _userService;
        private ITaskService _taskService;
        private ITaskStateService _taskStateService;
        private IDurumService _durumService;

        public FrmAnaMenu()
        {
            InitializeComponent();
            _projeService = KernelFactory.GetService<IProjeService>();
            _userService = KernelFactory.GetService<IUserService>();
            _taskService = KernelFactory.GetService<ITaskService>();
            _durumService = KernelFactory.GetService<IDurumService>();
            _taskStateService = KernelFactory.GetService<ITaskStateService>();
        }

        private void btnProjeEkle_Click(object sender, EventArgs e)
        {
            FrmProjeEkle frmProjeEkle = new FrmProjeEkle(_projeService);        
            frmProjeEkle.Show();
            this.Hide();
        }

        private void FrmAnaMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            FrmUserEkle frmUserEkle = new FrmUserEkle(_userService);
            frmUserEkle.Show();
            this.Hide();
        }

        private void btnProjeListe_Click(object sender, EventArgs e)
        {
            FrmProjeList frmProjeList = new FrmProjeList(_projeService);
            frmProjeList.Show();
            this.Hide();
        }

        private void btnKullaniciListe_Click(object sender, EventArgs e)
        {
            FrmUserList frmUserList = new FrmUserList(_userService);
            frmUserList.Show();
            this.Hide();
        }

        private void btnTaskEkle_Click(object sender, EventArgs e)
        {
            FrmTaskEkle frmTaskEkle = new FrmTaskEkle(_taskService,_projeService,_userService,_durumService,_taskStateService);
            frmTaskEkle.Show();
            this.Hide();
        }

        private void btnTaskList_Click(object sender, EventArgs e)
        {
            FrmTaskList frmTaskList = new FrmTaskList(_taskService);
            frmTaskList.Show();
            this.Hide();
        }

        private void btnTaskGuncelle_Click(object sender, EventArgs e)
        {
            FrmTaskListGuncelle frmTaskListGuncelle = new FrmTaskListGuncelle(_taskService,_userService,_projeService,_durumService,_taskStateService);
            frmTaskListGuncelle.Show();
            this.Hide();
        }

        private void btnTaskBoard_Click(object sender, EventArgs e)
        {
            FrmTaskBoard frmTaskBoard = new FrmTaskBoard(_taskService, _userService, _projeService, _durumService, _taskStateService);
            frmTaskBoard.Show();
            this.Hide();
        }
    }
}
