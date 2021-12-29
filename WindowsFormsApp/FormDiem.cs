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
    public partial class FormDiem : UserControl
    {
        public FormDiem()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(guna2TextBox1.Text!= "")
            {
                SinhVien sv = Cls_Main.svDow.timsinhVien(guna2TextBox1.Text);
                if(sv ==null)
                {
                    MessageBox.Show("Không tìm thấy sinh viên");
                }
                else
                {
                    guna2TextBox3.Text = sv.name;
                    List<Diem> lst = Cls_Main.diemDow.laydiem(sv.id);
                    foreach (Diem s in lst)
                    {
                        Console.WriteLine(s.tenmon);
                    }    
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = lst;
                    guna2DataGridView1.DataSource = bindingSource;

                }
               
            }
          
        }

        private void guna2Button2_Click(object sender, EventArgs e)
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
                saveFileDialog.FileName = "Điểm Của Sinh Viên " + guna2TextBox3.Text; //{0}-{1:00}-{2:00}-{3:00}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Minute)//trungthuong2021101801
                if (saveFileDialog.ShowDialog() == DialogResult.OK)//kiểm tra nếu nhấn vào button save trên hộp thoại
                {
                    XuatFileExcel.XuatExcel(saveFileDialog.FileName, guna2DataGridView1, "Điểm Của học sinh:" + guna2TextBox3.Text, " ");
                    MessageBox.Show("Xuất file thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi: ", ex.Message);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < guna2DataGridView1.RowCount - 1; row++)
            {
                int id = (int)guna2DataGridView1.Rows[row].Cells[0].Value;
                float d10 = (float)guna2DataGridView1.Rows[row].Cells[4].Value;
                float d30 = (float)guna2DataGridView1.Rows[row].Cells[5].Value;
                float d60 = (float)guna2DataGridView1.Rows[row].Cells[6].Value;
                float dtong = (float)guna2DataGridView1.Rows[row].Cells[7].Value;
                Cls_Main.diemDow.suadiem(id, d10, d30, d60, dtong);
            }
            MessageBox.Show("Đã Sửa Điểm");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            List<int> lst = new List<int>();

            foreach (DataGridViewRow row in guna2DataGridView1.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    lst.Add((int)(row.Cells[0].Value));
                }


            }
            foreach (int n in lst)
            {
                Cls_Main.diemDow.xoaDiem(n);
            }
            guna2Button1_Click(sender, e);
            MessageBox.Show("Đã Xóa");
        }
    }
}
