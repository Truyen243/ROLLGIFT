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
    
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            
        }
        static Admin stcadmin = Cls_Main.adminStc;
        #region Lấy thông tin admin stactic từ user control
        static Admin ad = Cls_Main.adminStc;
        public FormMain frm;
        public delegate void getStcadmin();

        public void get2()
        {
            Console.WriteLine("Xin chào");
        }
        #endregion 
        #region form load
        private void Form1_Load(object sender, EventArgs e)
        { 
            formSinhVien1.Visible = true;
            formMonHoc1.Visible = false;
            formDiem1.Visible = false;
            formLop1.Visible = false;
            formKhoa1.Visible = false;

            gunaLabel3.Text = Cls_Main.adminStc.fullName;

            Cls_Main.lopDowStc.getLop();
            Cls_Main.monDow.getMon();
        }
        #endregion

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
            formDiem1.Visible = false;
            formLop1.Visible = false;
            formKhoa1.Visible = false;

        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            formSinhVien1.Visible = true;
            formMonHoc1.Visible = false;
            formDiem1.Visible = false;
            formLop1.Visible = false;
            formKhoa1.Visible = false;

        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            formSinhVien1.Visible = false;
            formMonHoc1.Visible = false;
            formDiem1.Visible = true;
            formLop1.Visible = false;
            formKhoa1.Visible = false;

        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            formSinhVien1.Visible = false;
            formMonHoc1.Visible = false;
            formDiem1.Visible = false;
            formLop1.Visible = true;
            formKhoa1.Visible = false;
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void formSinhVien1_Load(object sender, EventArgs e)
        {

        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void informationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            FormThongTin formThongTin = new FormThongTin();
            formThongTin.ShowDialog();

            
            

        }
        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Admin ad = new Form_Admin();
            ad.ShowDialog();
        }

        private void changePassWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChangePW ch = new FormChangePW();
            ch.ShowDialog();
        }

        private void formKhoa1_Load(object sender, EventArgs e)
        {
            
        }

        private void formKhoa1_Load_1(object sender, EventArgs e)
        {
            
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            formSinhVien1.Visible = false;
            formMonHoc1.Visible = false;
            formDiem1.Visible = false;
            formLop1.Visible = false;
            formKhoa1.Visible = true;
        }
    }
}
