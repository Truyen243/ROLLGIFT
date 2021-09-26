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
    public partial class f_Main : Form
    {
        public f_Main()
        {
            InitializeComponent();
        }
        UserDAO _userDAO;
        private void mnSignupAccount_Click(object sender, EventArgs e)
        {
            f_Signup signup = new f_Signup();
            signup.ShowDialog();
        }
        private void f_Main_Load(object sender, EventArgs e)
        {
            _userDAO = new UserDAO();
            //_userDAO.GetUser(Cls_Main.pathfile);
            //_userDAO.GetUser("D://listUser.ini");
            //Cls_Main._listUser = _userDAO.listUser;


            tsslblInFo.Text = string.Format("Login by {0} - {1}", Cls_Main._staticUser.ID, Cls_Main._staticUser.UserName);
        }

        

        private void mnExit_Click(object sender, EventArgs e)
        {
        
            // Xóa thông tin User trong lần đăng nhập trước
            Cls_Main._staticUser = null;
            Close();
        }

        private void mnChangedPassWord_Click(object sender, EventArgs e)
        {
            f_ChangedPassWord changedPassWord = new f_ChangedPassWord();
            changedPassWord.Show();
        }

        private void mnSaveList_Click(object sender, EventArgs e)
        {
            _userDAO.WriteUser(Cls_Main.pathfile);
        }
    }
}
