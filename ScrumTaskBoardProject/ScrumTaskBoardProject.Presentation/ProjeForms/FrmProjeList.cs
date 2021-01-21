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

namespace ScrumTaskBoardProject.Presentation.ProjeForms
{
    public partial class FrmProjeList : Form
    {
        private IProjeService _projeService;
        public FrmProjeList(IProjeService projeService)
        {
            InitializeComponent();
            _projeService = projeService;
        }

        private void FrmProjeList_Load(object sender, EventArgs e)
        {
            dgwProjeList.DataSource = _projeService.GetirHepsi();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAnaMenu frmAnaMenu = new FrmAnaMenu();
            frmAnaMenu.Show();
            this.Close();
        }
    }
}
