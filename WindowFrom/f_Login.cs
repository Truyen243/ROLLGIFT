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
    public partial class f_Login : Form
    {
        public f_Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
        UserDAO _user;

        private void f_Login_Load(object sender, EventArgs e)
        {
            _user = new UserDAO();
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

                        //Nhớ nhật khẩu
                        _user.user.Remember = chbRemember.Checked;

                        Cls_Main._staticUser = _user.user;
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
            if (_user.user.UserName.Equals(userName)&& _user.user.PassWord.Equals(passWord))
            {
                return true;
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
            if (_user.user.Remember)
            {
                chbRemember.Checked = true;
                txbPassWord.Text = _user.user.PassWord;
                btnLogin.Focus();
            }
        }
    }
}
