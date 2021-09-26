using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowFrom.Data;

namespace WindowFrom
{
    public partial class f_Login : Form
    {
        public f_Login()
        {
            InitializeComponent();
        }

        private List<User> listUser;
        UserDAO _userDAO;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        //UserDAO _user;

        private void f_Login_Load(object sender, EventArgs e)
        {
            _userDAO = new UserDAO();
            _userDAO.GetUser(Cls_Main.pathfile);
            Cls_Main._listUser = _userDAO.listUser;


            listUser = Cls_Main._listUser;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Kiểm tra đăng nhập
            if (!string.IsNullOrEmpty(txbUserName.Text))
            {
                if (!string.IsNullOrEmpty(txbPassWord.Text))
                {
                    
                    if(Kiemtradangnhap(txbUserName.Text, txbPassWord.Text))
                    {

                        f_Main main = new f_Main();
                        //this.Hide();
                        main.ShowDialog(); 
                    }
                    else
                    {
                        MessageBox.Show("Nhập sai tên đăng nhập hoặc mật khẩu", "Thông báo");
                    }
                }
            }
        }

        private bool Kiemtradangnhap(string userName, string passWord)
        {
            foreach (User item in listUser)
            {
                if (item.UserName.Equals(userName) && item.PassWord.Equals(passWord))
                {
                    item.Remember = chbRemember.Checked;
                    Cls_Main._staticUser = item;
                    return true;
                }

            }
            return false;

        }

        private void f_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        //hàm nhớ mật khẩu
        private void txbUserName_Leave(object sender, EventArgs e)
        {
            foreach (User item in listUser)
            {
                if (item.UserName==txbUserName.Text && item.Remember)
                {
                    chbRemember.Checked = true;
                    txbPassWord.Text = item.PassWord;
                    btnLogin.Focus();
                }
            }
        }
    }
}
