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
using WindowsFormsApp.Common;

namespace WindowsFormsApp
{
    public partial class FormLop : UserControl
    {
        public FormLop()
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
                guna2ComboBox1.Items.Add(khoa.ten);
            }
        }
        List<string> lstma = new List<string>();

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Cls_Main.lopDowStc.getLop();
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

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Lop lop in Cls_Main.lopDowStc.lstlop)
            {

                if (lop.ten == guna2ComboBox2.SelectedItem.ToString())
                {
                    List<SinhVien> lst = new List<SinhVien>();

                    lst = Cls_Main.lopDowStc.getSv((Convert.ToString(lop.id)));
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = lst;
                    guna2DataGridView2.DataSource = bindingSource;
                }
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (guna2ComboBox2.SelectedIndex!= -1)
            {
            try
            {
                //Đối tường SaveFileDialog cho phép hiển thị một hộp thoại saveFile. Hộp thoại này cho phép nhập tên file và nơi lưu file Excel 
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                //Hien thi thu muc khoi tao
                saveFileDialog.InitialDirectory = @"d:\";
                //xác định vị trí có được nhớ lại khi mở tiếp hộp thoại này hay không 
                saveFileDialog.RestoreDirectory = true;

                saveFileDialog.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*";//Lọc loại file
                saveFileDialog.DefaultExt = "xls";//Phần mở rộng mặc định
                saveFileDialog.AddExtension = true;

                saveFileDialog.Title = "Lưu file Excel";//Tiêu đề của hộp thoại
                saveFileDialog.FileName = "Danh sách sinh viên lớp " + guna2ComboBox2.SelectedItem.ToString(); //{0}-{1:00}-{2:00}-{3:00}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Minute)//trungthuong2021101801
                if (saveFileDialog.ShowDialog() == DialogResult.OK)//kiểm tra nếu nhấn vào button save trên hộp thoại
                {
                    XuatFileExcel.XuatExcel(saveFileDialog.FileName, guna2DataGridView2, "Danh sách học sinh lớp" + guna2ComboBox2.SelectedItem.ToString(), "Khoa " + guna2ComboBox1.SelectedItem.ToString());
                    MessageBox.Show("Xuất file thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi: ", ex.Message);
            }
            }
        }

        private void guna2ComboBox1_Click(object sender, EventArgs e)
        {
            guna2ComboBox1.Items.Clear();
            Cls_Main.khoaDowStc.getKhoa();
            foreach (Khoa khoa in Cls_Main.khoaDowStc.lstKhoa)
            {
                guna2ComboBox1.Items.Add(khoa.ten);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            FormThemLop f = new FormThemLop();
            f.Show();
        }
    }
}
