using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowFrom
{
    public partial class f_Main : Form
    {
        public f_Main()
        {
            InitializeComponent();
        }
        private void mnSignupAccount_Click(object sender, EventArgs e)
        {
            f_Signup signup = new f_Signup();
            signup.ShowDialog();
        }
        private void f_Main_Load(object sender, EventArgs e)
        {

            tsslblInFo.Text = string.Format("Login by {0} - {1}", Cls_Main._staticUser.ID, Cls_Main._staticUser.UserName);
        }

        

        private void mnExit_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}
