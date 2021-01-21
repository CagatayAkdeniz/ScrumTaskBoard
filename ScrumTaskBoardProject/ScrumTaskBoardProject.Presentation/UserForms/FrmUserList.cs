using ScrumTaskBoard.Business.Interfaces;
using ScrumTaskBoard.Entities.Concrete;
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

namespace ScrumTaskBoardProject.Presentation.UserForms
{
    public partial class FrmUserList : Form
    {
        private IUserService _userService;
        public FrmUserList(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void FrmUserList_Load(object sender, EventArgs e)
        {
            var users = _userService.GetirHepsi();
            List<UserListDto> models = new List<UserListDto>();
            foreach (var item in users)
            {
                UserListDto userListDto = new UserListDto();
                userListDto.Id = item.Id;
                userListDto.Name = item.Name;
                models.Add(userListDto);
            }
            dgwUserList.DataSource = models;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAnaMenu frmAnaMenu = new FrmAnaMenu();
            frmAnaMenu.Show();
            this.Close();
        }
    }
}
