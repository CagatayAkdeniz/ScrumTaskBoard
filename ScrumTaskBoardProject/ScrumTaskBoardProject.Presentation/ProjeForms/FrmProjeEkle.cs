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

namespace ScrumTaskBoardProject.Presentation.ProjeForms
{
    public partial class FrmProjeEkle : Form
    {
        private IProjeService _projeService;
        public FrmProjeEkle(IProjeService projeService)
        {
            InitializeComponent();
            _projeService = projeService;
        }

        private void btnVazgec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAnaMenu frmAnaMenu = new FrmAnaMenu();
            frmAnaMenu.Show();
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string projeName = txtProjeName.Text.ToString();
            var kontrolEt = _projeService.GetirAdIle(projeName);
            if(kontrolEt!=null)
            {
                MessageBox.Show("Bu Proje Bulunmaktadır.");
            }
            else
            {
                _projeService.Ekle(new Proje()
                {
                    Name = projeName
                });
                MessageBox.Show("Proje Başarıyla Eklendi.");
                txtProjeName.Text = "";
            }
        }

        private void FrmProjeEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
