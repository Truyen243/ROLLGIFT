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
            f_User_Modifile f_UserModifile = new f_User_Modifile();
            f_UserModifile.isAdd = true;
            f_UserModifile.ShowDialog();
        }
        private void f_Main_Load(object sender, EventArgs e)
        {
            _userDAO = new UserDAO();

            tsslblInFo.Text = string.Format("Login by {0} - {1}", Cls_Main._staticUser.ID, Cls_Main._staticUser.FullName);
        }

        

        private void mnExit_Click(object sender, EventArgs e)
        {

            // Xóa thông tin User trong lần đăng nhập trước
            Cls_Main._staticUser = null;
            //Application.Exit();
            Close();

        }

        private void mnChangedPassWord_Click(object sender, EventArgs e)
        {
            f_ChangedPassWord changedPassWord = new f_ChangedPassWord();
            changedPassWord.Show();
        }

        private void mnSaveList_Click(object sender, EventArgs e)
        {
            //_userDAO.WriteUser(Cls_Main.pathfile);
        }

        private void mnUserList_Click(object sender, EventArgs e)
        {
            f_User_Main f_UserMain = new f_User_Main();
            f_UserMain.ShowDialog();
        }

        private void f_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
                
            }
        }

        private void mnSignupAccount_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
