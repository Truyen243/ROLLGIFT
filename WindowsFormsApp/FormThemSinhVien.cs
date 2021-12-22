using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Data;
namespace WindowsFormsApp
{
    public partial class FormThemSinhVien : Form
    {
        public FormThemSinhVien()
        {
            InitializeComponent();
        }
        List<String> lstma = new List<string>();
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


            if (textBox2.Text ==""|| textBox4.Text == ""|| textBox5.Text == "" || textBox3.Text == "" || textBox6.Text == "" || guna2ComboBox1.SelectedIndex == -1|| guna2ComboBox2.SelectedIndex == -1)
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
                    
                    if(Cls_Main.svDow.addSv(textBox2.Text, textBox5.Text, textBox6.Text, textBox4.Text, textBox3.Text, sex, lstma[guna2ComboBox1.SelectedIndex], Cls_Main.khoaDowStc.lstKhoa[guna2ComboBox2.SelectedIndex].makhoa))
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
            foreach (Khoa khoa in Cls_Main.khoaDowStc.lstKhoa)
            {
                guna2ComboBox2.Items.Add(khoa.ten);
            }    
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mskhoa = Cls_Main.khoaDowStc.lstKhoa[guna2ComboBox2.SelectedIndex].id;

            guna2ComboBox1.Items.Clear();
            lstma.Clear();
            foreach (Lop lop in Cls_Main.lopDowStc.lstlop)
            {

                if(Int32.Parse(lop.Khoa_id) == mskhoa)
                {
                    guna2ComboBox1.Items.Add(lop.ten);
                    lstma.Add(lop.khoa_id);
                }    
            }    
        }
    }
}
