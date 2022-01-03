using System;
using System.Windows.Forms;
using WindowsFormsApp.Data;
namespace WindowsFormsApp
{
    public partial class FormThemMonHoc : Form
    {
        public FormThemMonHoc()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        MonHoc mh = new MonHoc();

        private void FormThemMonHoc_Load(object sender, EventArgs e)
        {

            foreach (MonHoc m in Cls_Main.monDow.lstMon)
            {
                guna2ComboBox2.Items.Add(m.ten);
            }
        }
        private void FormThemMonHoc_Click(object sender, EventArgs e)
        {
            guna2ComboBox2.Items.Clear();
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
            guna2TextBox3.Text = "";
            guna2TextBox5.Text = "";
            guna2TextBox4.Text = "";
            Cls_Main.monDow.getMon();
            foreach (MonHoc m in Cls_Main.monDow.lstMon)
            {
                guna2ComboBox2.Items.Add(m.ten);
            }
            
        }       

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (MonHoc m in Cls_Main.monDow.lstMon)
            {
                if (guna2ComboBox2.SelectedItem.ToString() == m.ten)
                {
                    mh = m;
                }
            }
            guna2TextBox1.Text = mh.id.ToString();
            guna2TextBox2.Text = mh.mamonhoc;
            guna2TextBox3.Text = mh.ten;
            guna2TextBox5.Text = mh.heso.ToString();
            guna2TextBox4.Text = mh.sotiet.ToString();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (guna2TextBox9.Text == "" || guna2TextBox8.Text == "" || guna2TextBox6.Text == "" || guna2TextBox7.Text == "")
            {
                MessageBox.Show("Vui lòng Nhập Đầy Đủ Thông Tin");
            }
            else
            {

                if (Cls_Main.monDow.addMonHoc(guna2TextBox8.Text, guna2TextBox9.Text, guna2TextBox7.Text, guna2TextBox6.Text))
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
            if(guna2TextBox1.Text == ""|| guna2TextBox2.Text==""|| guna2TextBox3.Text==""|| guna2TextBox5.Text==""|| guna2TextBox4.Text=="")
            {
                MessageBox.Show("Vui lòng Nhập Đầy Đủ Thông Tin");
            }
            else
            {
                int id = Int32.Parse(guna2TextBox1.Text.ToString());
                int sotiet = Int32.Parse(guna2TextBox4.Text.ToString());
                int heso = Int32.Parse(guna2TextBox5.Text.ToString());
                if (Cls_Main.monDow.editMonHoc(id, guna2TextBox3.Text, guna2TextBox2.Text, sotiet, heso))
                {

                    MessageBox.Show("Sửa Thành Công");
                
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "")
            {
                MessageBox.Show("Vui lòng Chọn Môn Học cần Xóa");
            }
            else
            {
                int id = Int32.Parse(guna2TextBox1.Text.ToString());
                Cls_Main.monDow.xoaMonHoc(id);
                MessageBox.Show("Bạn Cần Có Quyền Cao Hơn Để Xóa");
            }
        }
    }
}
