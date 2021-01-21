using Microsoft.Identity.Client;
using ScrumTaskBoard.Business.Interfaces;
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
    public partial class FrmTaskGuncelle : Form
    {
        public int _Id { get; set; }
        private ITaskService _taskService;
        private IUserService _userService;
        private IProjeService _projeService;
        private IDurumService _durumService;
        private ITaskStateService _taskStateService;

        public FrmTaskGuncelle(ITaskService taskService, IUserService userService, IProjeService projeService
            , IDurumService durumService, ITaskStateService taskStateService)
        {
            InitializeComponent();
            _taskService = taskService;
            _userService = userService;
            _projeService = projeService;
            _durumService = durumService;
            _taskStateService = taskStateService;
        }

        private void btnVazgec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAnaMenu frmAnaMenu = new FrmAnaMenu();
            frmAnaMenu.Show();
            this.Hide();
        }

        private void FrmTaskGuncelle_Load(object sender, EventArgs e)
        {
            var users = _userService.GetirHepsi();
            var projeler = _projeService.GetirHepsi();

            foreach (var user in users)
            {
                cmbUser.Items.Add(user.Name);
            }
            foreach (var proje in projeler)
            {
                cmbProje.Items.Add(proje.Name);
            }

            var task = _taskService.GetirUsersById(_Id);
            lblTarih.Text = task.TaskDate.ToString();
            cmbProje.Text = task.Name;
            cmbUser.Text = task.User.Name;
            txtDescription.Text = task.Description;
            txtNotes.Text = task.Note;
            dateFinishDate.Text = task.FinishDate.ToString();
            datePreDate.Text = task.PreDate.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string userName = cmbUser.Text;
            var projeName = cmbProje.Text;
            var proje = _projeService.GetirAdIle(projeName);
            var user = _userService.GetirAdIle(userName);
            var durum = _durumService.GetirAdIle("Todo");
            var taskState = _taskStateService.GetirByTaskId(_Id);

            if (user == null)
            {
                MessageBox.Show("Böyle Bir Kullanıcı Sistemde Yok...");
            }
            else if (proje == null)
            {
                MessageBox.Show("Böyle Bir Proje Sistemde Yok...");
            }
            else
            {

                if (!KontrolEt())
                {

                }
                else
                {
                    _taskService.Guncelle(new ScrumTaskBoard.Entities.Concrete.Task
                    {
                        Id = _Id,
                        Name = projeName,
                        Description = txtDescription.Text,
                        Note = txtNotes.Text,
                        PreDate = Convert.ToDateTime(datePreDate.Text),
                        FinishDate = Convert.ToDateTime(dateFinishDate.Text),
                        UserId = user.Id,
                        DurumId = durum.Id,
                    });

                    _taskStateService.Guncelle(new ScrumTaskBoard.Entities.Concrete.TaskState
                    {
                        Id = taskState.Id,
                        Description = txtDescription.Text,
                        TaskId = _Id,
                        UserId = user.Id,
                        DurumId = durum.Id
                    });

                    MessageBox.Show("Task Başarıyla Güncellendi.");

                    FrmAnaMenu frmAnaMenu = new FrmAnaMenu();
                    frmAnaMenu.Show();
                    this.Hide();
                }
            }
        }

        private bool KontrolEt()
        {
            if (string.IsNullOrEmpty(cmbProje.Text))
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurun...");
                return false;
            }
            else if(string.IsNullOrEmpty(cmbUser.Text))
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurun...");
                return false;
            }
            else if(string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurun...");
                return false;
            }
            else if(string.IsNullOrEmpty(txtNotes.Text))
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurun...");
                return false;
            }
            else
            {
                return true;
            }          
        }
    }
}
