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


        // Tạo tabcontrol
        /*public bool CheckOpen(string name)
        {
            for (int i = 0;i< tabControl2.TabCount;i++)
            {
                if(tabControl2.Tabs[i])
            }    
            return false;
        }    */




        UserDAO _userDAO;
        private void mnSignupAccount_Click(object sender, EventArgs e)
        {
            f_User_Modifile f_UserModifile = new f_User_Modifile();
            f_UserModifile.isAdd = true;
            f_UserModifile.ShowDialog();
        }
        private void f_Main_Load(object sender, EventArgs e)
        {
            f_Login flog = new f_Login();
            flog.ShowDialog();
            _userDAO = new UserDAO();

            tsslblInFo.Text = string.Format("Login by {0} - {1}", Cls_Main._staticUser.ID, Cls_Main._staticUser.FullName);
            if(Cls_Main._staticUser.ID!= 1)
            {
                mnUserList.Enabled = false;
                rollGiftToolStripMenuItem.Enabled = false;
            }   
            
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
            this.Hide();
            changedPassWord.ShowDialog();
            this.Show();
        }

        private void mnSaveList_Click(object sender, EventArgs e)
        {
            //_userDAO.WriteUser(Cls_Main.pathfile);
        }

        private void mnUserList_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_User_Main f_UserMain = new f_User_Main();
            f_UserMain.ShowDialog();
            this.Show();
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

        private void rollGiftToolStripMenuItem_Click(object sender, EventArgs e)
        {                 
            f_quaysomayman frm = new f_quaysomayman();
            this.Hide();
            frm.ShowDialog();
            this.Show();



        }

        private void mnFile_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_information f_infor = new f_information();
            this.Hide();
            f_infor.ShowDialog();
            this.Show();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_contact f_infor = new f_contact();
            this.Hide();
            f_infor.ShowDialog();
            this.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void gradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_grade f_infor = new f_grade();
            this.Hide();
            f_infor.ShowDialog();
            this.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_print f_infor = new f_print();
            this.Hide();
            f_infor.ShowDialog();
            this.Show();
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_image f_infor = new f_image();
            this.Hide();
            f_infor.ShowDialog();
            this.Show();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_setting f_infor = new f_setting();
            this.Hide();
            f_infor.ShowDialog();
            this.Show();
        }

    }
}
