using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp.Data;
namespace WindowsFormsApp
{
    public partial class FormThemLop : Form
    {
        public FormThemLop()
        {
            InitializeComponent();
        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void FormThemLop_Load(object sender, EventArgs e)
        {
            foreach (Khoa khoa in Cls_Main.khoaDowStc.lstKhoa)
            {
                guna2ComboBox2.Items.Add(khoa.ten);
                guna2ComboBox3.Items.Add(khoa.ten);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        List<string> lstma = new List<string>();
        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cls_Main.lopDowStc.getLop();
            int mskhoa = Cls_Main.khoaDowStc.lstKhoa[guna2ComboBox2.SelectedIndex].id;

            guna2ComboBox1.Items.Clear();
            lstma.Clear();
            foreach (Lop lop in Cls_Main.lopDowStc.lstlop)
            {

                if (Int32.Parse(lop.Khoa_id) == mskhoa)
                {
                    guna2ComboBox1.Items.Add(lop.ten);
                    lstma.Add(lop.khoa_id);
                }
            }
        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void guna2ComboBox2_Click(object sender, EventArgs e)
        {
            guna2ComboBox2.Items.Clear();
            guna2ComboBox3.Items.Clear();
            guna2ComboBox1.Items.Clear();
            guna2TextBox4.Text = "";
            guna2TextBox1.Text = "";
            guna2TextBox3.Text = "";
            guna2TextBox5.Text = "";
            Cls_Main.khoaDowStc.getKhoa();
            foreach (Khoa khoa in Cls_Main.khoaDowStc.lstKhoa)
            {
                guna2ComboBox2.Items.Add(khoa.ten);
                guna2ComboBox3.Items.Add(khoa.ten);
            }
        }


        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Lop lop in Cls_Main.lopDowStc.lstlop)
            {

                if (lop.ten == guna2ComboBox1.SelectedItem.ToString())
                {
                    guna2TextBox4.Text = lop.malop;
                    guna2TextBox1.Text = lop.ten;
                }
            }
        }

        private void guna2ComboBox3_Click(object sender, EventArgs e)
        {
            guna2ComboBox2.Items.Clear();
            guna2ComboBox3.Items.Clear();
            guna2ComboBox1.Items.Clear();
            guna2TextBox4.Text = "";
            guna2TextBox1.Text = "";
            guna2TextBox3.Text = "";
            guna2TextBox5.Text = "";
            Cls_Main.khoaDowStc.getKhoa();
            foreach (Khoa khoa in Cls_Main.khoaDowStc.lstKhoa)
            {
                guna2ComboBox2.Items.Add(khoa.ten);
                guna2ComboBox3.Items.Add(khoa.ten);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if(guna2TextBox5.Text =="" || guna2TextBox3.Text == "")
            {
                MessageBox.Show("Vui lòng Nhập Đầy Đủ Thông Tin");
            }
            else
            {
                int mskhoa = Cls_Main.khoaDowStc.lstKhoa[guna2ComboBox3.SelectedIndex].id;
                if(Cls_Main.lopDowStc.addLop(guna2TextBox3.Text, mskhoa, guna2TextBox5.Text))
                {
                    MessageBox.Show("Tạo Thành Công");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "" || guna2TextBox4.Text == "")
            {
                MessageBox.Show("Vui lòng Nhập Đầy Đủ Thông Tin");
            }
            else
            {
                int mskhoa = Cls_Main.khoaDowStc.lstKhoa[guna2ComboBox2.SelectedIndex].id;
                int idlop = Cls_Main.lopDowStc.lstlop[guna2ComboBox1.SelectedIndex].id;
                Console.WriteLine(idlop);
                Console.WriteLine(mskhoa);

                if (Cls_Main.lopDowStc.editLop(idlop, guna2TextBox1.Text, mskhoa, guna2TextBox4.Text))
                {
                    MessageBox.Show("Sửa Thành Công");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
