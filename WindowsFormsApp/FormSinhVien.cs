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
    public partial class FormSinhVien : UserControl
    {
        public FormSinhVien()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSoDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Separator5_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }
        public delegate void Send();
        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThemSinhVien formThemSinhVien = new FormThemSinhVien(wrote);
            formThemSinhVien.Show();
            this.Show();
        }
        public void wrote()
        {
            Console.WriteLine("Xin chào");
        }

        List<SinhVien> lstsv = new List<SinhVien>();
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(guna2TextBox6.Text != "")
            {
                SinhVien sv = Cls_Main.svDow.timsinhVien(guna2TextBox6.Text);
                
                sv.GetString();
                if (sv ==null)
                {
                    MessageBox.Show("Không tìm thấy sinh viên, vui lòng nhập lại");
                }
                else
                {
                    lstsv.Add(sv);
                }

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = lstsv;
                guna2DataGridView1.DataSource = bindingSource;
            }    
            
        }
    }
}
