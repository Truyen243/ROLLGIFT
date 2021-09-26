using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowFrom.Data;

namespace WindowFrom
{
    public partial class f_ChangedPassWord : Form
    {
        public f_ChangedPassWord()
        {
            InitializeComponent();
        }
        List<User> _listUser;
        bool statusLoad = false;
        private int IdUserType = 0;

        int idUser = 0;

        UserDAO userDAO;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void f_ChangedPassWord_Load(object sender, EventArgs e)
        {
            userDAO = new UserDAO();
            IdUserType = Cls_Main._staticUser.IdUserType;

            idUser = Cls_Main._staticUser.ID;

            lblUserName.Text = string.Format("{0} - {1}", idUser.ToString(), Cls_Main._staticUser.UserName.ToUpper());

            //Kiểm tra loại người dùng
            switch (IdUserType)
            {
                case 1:
                    grbAdmin.Enabled = true;

                    _listUser = Cls_Main._listUser;
                    LoadCombouser();
                    break;
                case 2:
                    grbAdmin.Enabled = false;
                    break;
                default:
                    grbAdmin.Enabled = false;
                    break;
            }

        }

        private void LoadCombouser()
        {
            cboUser.DataSource = _listUser;
            cboUser.DisplayMember = "UserName";
            cboUser.ValueMember = "ID";
            cboUser.SelectedIndex = -1;
            statusLoad = true;
        }

        private void cboUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUser.SelectedIndex >= -1 && statusLoad)
            {
                idUser = Convert.ToInt32(cboUser.SelectedValue);
            }
        }

        private void btnRestPassword_Click(object sender, EventArgs e)
        {
            foreach (User item in Cls_Main._listUser)
            {
                if (item.ID == idUser)
                {
                    item.PassWord = item.UserName;
                    userDAO.listUser = Cls_Main._listUser;
                    userDAO.WriteUser(Cls_Main.pathfile);
                }
            }
        }

        private void btnChangedPassword_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbPasswordNewOne.Text))
            {
                if(!string.IsNullOrEmpty(txbPasswordNewTow.Text))
                {
                    if (txbPasswordNewOne.Text.Equals(txbPasswordNewTow.Text))
                    {
                        if (ChangedPassword(txbPasswordNewOne.Text))
                        {
                            MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ChangedPassword(string passNew)
        {
            foreach (User item in Cls_Main._listUser)
            {
                if (item.ID == idUser)
                {
                    item.PassWord = passNew;
                    userDAO.listUser = Cls_Main._listUser;
                    userDAO.WriteUser(Cls_Main.pathfile);
                    return true;
                }
            }
            return false;
        }

        private void grbAdmin_Enter(object sender, EventArgs e)
        {

        }
    }
}
