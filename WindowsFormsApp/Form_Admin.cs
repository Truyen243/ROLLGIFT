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
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
        }

        private void licensing1_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == ""|| textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Nhập Thiếu Thông Tin");
            }    
            else
            {
                if(textBox3.Text!= textBox4.Text)
                {
                    MessageBox.Show("Mật khẩu không trùng nhau");
                }
                else
                {
                   
                    if(Cls_Main.adminStc.passWord!= textBox5.Text)
                    {
                        MessageBox.Show("Nhập sai mật khẩu xác nhận");
                    }
                    else
                    {
                        
                       if( Cls_Main.adStc.add(textBox1.Text, textBox2.Text, textBox4.Text))
                        {
                            MessageBox.Show("Tạo Tài Khoản Thành Công");
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
