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
    public partial class FormKhoa : UserControl
    {
        public FormKhoa()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btcUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
             
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click_2(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
        private void FormKhoa_Load(object sender, EventArgs e)
        {
            foreach (Khoa khoa in Cls_Main.khoaDowStc.lstKhoa)
            {
                guna2ComboBox2.Items.Add(khoa.ten);
                
            }
            
        }
        List<String> lstlop = new List<string>();
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mskhoa = Cls_Main.khoaDowStc.lstKhoa[guna2ComboBox2.SelectedIndex].id;

            guna2ComboBox2.Items.Clear();
            lstlop.Clear();
            foreach (Lop lop in Cls_Main.lopDowStc.lstlop)
            {

                if (Int32.Parse(lop.Khoa_id) == mskhoa)
                {
                    guna2ComboBox2.Items.Add(lop.ten);
                    lstlop.Add(lop.malop);
                }
            }
        }

        
    }
}
