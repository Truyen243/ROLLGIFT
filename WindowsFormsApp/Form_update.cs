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
    public partial class Form_update : Form
    {
        public Form_update()
        {
            InitializeComponent();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SinhVien sv = new SinhVien();
        
        List<String> lstma = new List<string>();
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mskhoa = Cls_Main.khoaDowStc.lstKhoa[guna2ComboBox1.SelectedIndex].id;

            guna2ComboBox2.Items.Clear();
            lstma.Clear();
            foreach (Lop lop in Cls_Main.lopDowStc.lstlop)
            {

                if (Int32.Parse(lop.Khoa_id) == mskhoa)
                {
                    guna2ComboBox2.Items.Add(lop.ten);
                   lstma.Add(lop.khoa_id);
                    
                }
            }
        }        
        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Cls_Main.svDow.xoasinhVien(sv.id);
            guna2ComboBox1.Items.Clear();
            guna2ComboBox2.Items.Clear();
            textBox9.Text = "";//Mã 
            textBox13.Text = "";//tên
            textBox12.Text = "";//adreess
            textBox14.Text = "";//email
            textBox16.Text = "";//Phone
            textBox15.Text = "";//date
            radioButton1.Checked = false;//nam
            radioButton2.Checked = false;//nu
            guna2ComboBox2.Items.Clear();
            guna2ComboBox1.Items.Clear();
            MessageBox.Show("Xóa thành Công");
        }
        //public bool updateSv(int Id, String Name, String Email, String Address, String Date, String Phone, String Sex, int Lop_id)
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (textBox13.Text == "" || textBox12.Text == "" || textBox14.Text == "" || textBox16.Text == "" || textBox15.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            else
            {
                if (radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                }
                else
                {
                    if (guna2ComboBox1.SelectedIndex == -1 || guna2ComboBox2.SelectedIndex == -1)
                    {

                        MessageBox.Show("Vui lòng nhập đủ thông tin");
                    }
                    else
                    {
                        int lopid = Cls_Main.lopDowStc.getidlop(guna2ComboBox2.SelectedItem.ToString());
                        string gioi = "";
                        if (radioButton1.Checked == true)
                        {
                            gioi = "Nam";
                        }
                        else
                        {
                            gioi = "Nu";
                        }
                        Cls_Main.svDow.updateSv(sv.id, textBox13.Text, textBox14.Text, textBox12.Text, textBox15.Text, textBox16.Text, gioi, lopid);

                        MessageBox.Show("Update Thành Công");
                    }
                }
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text != "")
            {

                sv = Cls_Main.svDow.timsinhVien(guna2TextBox2.Text);
                if (sv != null)
                {
                    guna2ComboBox1.Items.Clear();
                    guna2ComboBox2.Items.Clear();
                    textBox9.Text = sv.mssv;
                    textBox13.Text = sv.name;
                    textBox12.Text = sv.adress;
                    textBox14.Text = sv.email;
                    textBox16.Text = sv.phone;
                    textBox15.Text = sv.ngaysinh;
                    if (sv.gioitinh == "Nam")
                    {
                        radioButton1.Checked = true;
                    }
                    else
                    {
                        radioButton2.Checked = true;
                    }
                    foreach (Khoa khoa in Cls_Main.khoaDowStc.lstKhoa)
                    {
                        guna2ComboBox1.Items.Add(khoa.ten);
                        if (khoa.makhoa == sv.mskhoa)
                        {
                            guna2ComboBox1.SelectedIndex = guna2ComboBox1.FindStringExact(khoa.ten);
                        }
                    }
                    guna2ComboBox2.SelectedIndex = guna2ComboBox2.FindStringExact(sv.mslop);

                    /*public int id;
                    public string name;
                    public string phone;
                    public string mssv;
                    public string email;
                    public string ngaysinh;
                    public string adress;
                    public string mslop;
                    public string mskhoa;
                    public string gioitinh;*/
                }
                else
                {
                    MessageBox.Show("Không tồn tại sinh viên");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập vào");
            }
        }
    }
}
