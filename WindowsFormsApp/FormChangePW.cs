using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormChangePW : Form
    {
        public FormChangePW()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public delegate void getStcadmin();
        public getStcadmin get2;
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            get2();
            if(textBox4.Text == ""|| textBox8.Text == ""|| textBox7.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhâp Đủ Thông Tin");

            }
            else
            {
                if(textBox4.Text!= textBox8.Text)
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu trùng nhau");
                }    
                else
                {
                    if(textBox7.Text!= Cls_Main.adminStc.passWord)
                    {
                        MessageBox.Show("Mật khẩu sai");
                    }    
                    else
                    {
                        if(Cls_Main.adStc.changePassWord(textBox8.Text, textBox4.Text))
                        {
                            MessageBox.Show("Đổi Mật Khẩu Thành Công");
                            

                        }    
                        else
                        {
                            MessageBox.Show("Error");
                        }    
                    }    
                }    
            }
        }
    }
}
