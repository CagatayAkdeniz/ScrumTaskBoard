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

namespace ScrumTaskBoardProject.Presentation.UserForms
{
    public partial class FrmUserEkle : Form
    {
        FrmAnaMenu frmAnaMenu = new FrmAnaMenu();
        private IUserService _userService;
        public FrmUserEkle(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void btnVazgec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAnaMenu.Show();
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.ToString();
            var kontrolEt = _userService.GetirAdIle(userName);
            if(kontrolEt!=null)
            {
                MessageBox.Show("Bu Kullanıcı Bulunmaktadır.");
            }
            else
            {
                _userService.Ekle(new User
                {
                    Name = userName
                });
                MessageBox.Show("Kullanıcı Başarıyla Eklendi.");
                txtUserName.Text = "";
            }           
        }
    }
}
