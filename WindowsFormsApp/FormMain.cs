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
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formSinhVien1.Visible = true;
            formMonHoc1.Visible = false;
        }


        private void formMonHoc1_Load(object sender, EventArgs e)
        {

        }

        private void gunaContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            formSinhVien1.Visible = false;
            formMonHoc1.Visible = true;
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            formSinhVien1.Visible = true;
            formMonHoc1.Visible = false;
        }
    }
}
