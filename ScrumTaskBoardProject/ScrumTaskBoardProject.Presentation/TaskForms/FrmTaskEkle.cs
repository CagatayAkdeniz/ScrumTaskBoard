using Microsoft.Identity.Client;
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
using ScrumTaskBoard.Entities.Concrete;

namespace ScrumTaskBoardProject.Presentation.TaskForms
{
    public partial class FrmTaskEkle : Form
    {
        private ITaskService _taskService;
        private IProjeService _projeService;
        private IUserService _userService;
        private IDurumService _durumService;
        private ITaskStateService _taskStateService;
        public FrmTaskEkle(ITaskService taskService,IProjeService projeService,
            IUserService userService, IDurumService durumService, ITaskStateService taskStateService)
        {
            InitializeComponent();
            _taskService = taskService;
            _projeService = projeService;
            _userService = userService;
            _durumService = durumService;
            _taskStateService = taskStateService;
        }

        private void FrmTaskEkle_Load(object sender, EventArgs e)
        {
            var projeler = _projeService.GetirHepsi();
            var users = _userService.GetirHepsi();

            foreach (var item in projeler)
            {
                cmbProje.Items.Add(item.Name);
            }

            foreach (var item in users)
            {
                cmbUser.Items.Add(item.Name);
            }

            lblTarih.Text = DateTime.Now.ToLongDateString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string userName = cmbUser.Text;
            var projeName = cmbProje.Text;
            var proje = _projeService.GetirAdIle(projeName);
            var user = _userService.GetirAdIle(userName);
            var durum = _durumService.GetirAdIle("Todo");

            var projeUzunluk = cmbProje.Text.Length;
            var userUzunluk = cmbUser.Text.Length;
            var aciklamaUzunluk = txtDescription.Text.Length;
            var noteUzunluk = txtNotes.Text.Length;

            int finishDate = (projeUzunluk * userUzunluk * (aciklamaUzunluk/3) * (noteUzunluk/3) ) / 60;

            DateTime date = DateTime.Now.AddDays(finishDate);

            datePreDate.Text = date.ToString();

            if(user==null)
            {
                MessageBox.Show("Böyle Bir Teknik Uzman Sistemde Yok...");
            }
            else if(proje==null)
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
                    ScrumTaskBoard.Entities.Concrete.Task task = new ScrumTaskBoard.Entities.Concrete.Task
                    {
                        Name = projeName,
                        Description = txtDescription.Text,
                        Note = txtNotes.Text,
                        PreDate = date,
                        FinishDate = Convert.ToDateTime(dateFinishDate.Text),
                        UserId = user.Id,
                        DurumId = durum.Id,
                    };

                    _taskService.Ekle(task);

                        _taskStateService.Ekle(new TaskState
                        {
                            Description = task.Description,
                            TaskId = task.Id,
                            DurumId = task.DurumId,
                            UserId = task.UserId
                        });

                    MessageBox.Show("Task Başarıyla Eklendi.");

                    Temizle();
                }
            }                     
        }

        private void Temizle()
        {
            cmbUser.Text = "";
            cmbProje.Text = "";
            lblTarih.Text = DateTime.Now.ToLongDateString();
            dateFinishDate.Text = "";
            datePreDate.Text = "";
            txtNotes.Text = "";
            txtDescription.Text = "";
        }

        private void btnVazgec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAnaMenu frmAnaMenu = new FrmAnaMenu();
            frmAnaMenu.Show();
            this.Close();
        }

        private bool KontrolEt()
        {
            if (string.IsNullOrEmpty(cmbProje.Text))
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurun...");
                return false;
            }
            else if (string.IsNullOrEmpty(cmbUser.Text))
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurun...");
                return false;
            }
            else if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurun...");
                return false;
            }
            else if (string.IsNullOrEmpty(txtNotes.Text))
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
