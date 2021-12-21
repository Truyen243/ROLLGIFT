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
    public partial class FormThemSinhVien : Form
    {
        public FormThemSinhVien()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

            string[] lops = { "19CT113", "19CT114", "19CT115", "19CT116" };
            if (textBox2.Text ==""|| textBox4.Text == ""|| textBox5.Text == "" || textBox3.Text == "" || textBox6.Text == "" || guna2ComboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng Nhập Đầy Đủ Thông Tin1");
            }
            else
            {
                if (radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    MessageBox.Show("Vui lòng Nhập Đầy Đủ Thông Tin2");
                }
                else
                {
                    String sex;
                    if (radioButton1.Checked)
                    {
                        sex = "Nam";
                    }
                    else
                    {
                        sex = "Nu";
                    }
                    
                    if(Cls_Main.svDow.addSv(textBox2.Text, textBox5.Text, textBox6.Text, textBox4.Text, textBox3.Text, sex, lops[guna2ComboBox1.SelectedIndex]))
                    {
                        MessageBox.Show("Tạo Thành Công");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    } 
                        
                 }
            }
        }

        private void FormThemSinhVien_Load(object sender, EventArgs e)
        {
            string[] lops = { "19CT113", "19CT114", "19CT115", "19CT116" };
            foreach (String lop in lops)
            {
                guna2ComboBox1.Items.Add(lop);
            }    
        }
    }
}
