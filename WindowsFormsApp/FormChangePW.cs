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

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if(textBox4.Text == ""|| textBox8.Text == ""|| textBox7.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhâp Đủ Thông Tin");

            }
            else
            {
                if(textBox4.Text!= textBox8.Text)
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu trung nhau");
                }    
                else
                {
                    if(textBox7.Text!= Cls_Main.adminStc.passWord)
                    {
                        MessageBox.Show("Mật khẩu xác nhận sai");
                    }    
                    else
                    {

                    }    
                }    
            }
        }
    }
}
