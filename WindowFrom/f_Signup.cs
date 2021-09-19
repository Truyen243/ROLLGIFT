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
    public partial class f_Signup : Form
    {
        public f_Signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {

            if (txbUserName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào tên đăng nhập", "Thông báo");
                txbUserName.Focus();//Đưa con trỏ chuột về lại
            }
            else if (txbPassWord.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào mật khẩu", "Thông báo");
                txbPassWord.Focus();//Đưa con trỏ chuột về lại
            }
            else
            {
                MessageBox.Show("Đăng ký thành công", "Thông báo");
            }
        }


    }
}
