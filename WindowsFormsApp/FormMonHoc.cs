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
    public partial class FormMonHoc : UserControl
    {
        public FormMonHoc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Separator4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        MonHoc mh = new MonHoc();
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2TextBox2.Text = "";
            guna2TextBox3.Text = "";
            foreach (MonHoc m in Cls_Main.monDow.lstMon)
            {
                if(guna2ComboBox3.SelectedItem.ToString() == m.ten)
                {
                    mh = m;
                }
            }
            guna2TextBox2.Text = mh.mamonhoc;
            guna2TextBox3.Text = mh.ten; 
        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            
            foreach (Khoa khoa in Cls_Main.khoaDowStc.lstKhoa)
            {
                guna2ComboBox1.Items.Add(khoa.ten);
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Cls_Main.lopDowStc.getLop();
            int mskhoa = Cls_Main.khoaDowStc.lstKhoa[guna2ComboBox1.SelectedIndex].id;

            guna2ComboBox2.Items.Clear();
            //lstma.Clear();
            foreach (Lop lop in Cls_Main.lopDowStc.lstlop)
            {

                if (Int32.Parse(lop.Khoa_id) == mskhoa)
                {
                    guna2ComboBox2.Items.Add(lop.ten);
                    //lstma.Add(lop.khoa_id);
                }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            SinhVien sv = Cls_Main.svDow.timsinhVien(guna2TextBox4.Text);
            Diem dm = new Diem(1,"",sv.id, mh.id, 0, 0, 0, 0);
            Cls_Main.diemDow.add(dm);
        }

        private void guna2ComboBox2_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button1_Click(sender, e);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(guna2ComboBox2.SelectedIndex !=-1)
            {
                foreach (Lop lop in Cls_Main.lopDowStc.lstlop)
                {
                    if(guna2ComboBox2.SelectedItem.ToString() == lop.ten)
                    {
                        List<SinhVien> lst = Cls_Main.lopDowStc.getSv(lop.id.ToString());
                        foreach(SinhVien sv in lst)
                        {
                            Diem dm = new Diem(1,"", sv.id, mh.id, 0, 0, 0, 0);
                            Cls_Main.diemDow.add(dm);

                        }
                        MessageBox.Show("Đã thêm điểm");
                    }
                }
            }
        }

        private void guna2ComboBox3_Click(object sender, EventArgs e)
        {
            guna2ComboBox3.Items.Clear();
            Cls_Main.monDow.getMon();

            foreach (MonHoc m in Cls_Main.monDow.lstMon)
            {
                guna2ComboBox3.Items.Add(m.ten);
            }
        }

        private void guna2ComboBox1_Click(object sender, EventArgs e)
        {
            Cls_Main.khoaDowStc.getKhoa();
            foreach (Khoa khoa in Cls_Main.khoaDowStc.lstKhoa)
            {
                guna2ComboBox1.Items.Add(khoa.ten);
            }
        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (MonHoc m in Cls_Main.monDow.lstMon)
            {
                if (guna2ComboBox3.SelectedItem.ToString() == m.ten)
                {
                    mh = m;
                }
            }
            guna2TextBox2.Text = mh.mamonhoc;
            guna2TextBox3.Text = mh.ten;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            FormThemMonHoc n = new FormThemMonHoc();
            n.Show();
        }
    }
}
