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
    public partial class FormSinhVien : UserControl
    {
        public FormSinhVien()
        {
            InitializeComponent();
        }

        public delegate void Send();

        public void wrote()
        {
            Console.WriteLine("Xin chào");
        }

        List<SinhVien> lstsv = new List<SinhVien>();
        
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (guna2TextBox6.Text != "")
            {
                SinhVien sv = Cls_Main.svDow.timsinhVien(guna2TextBox6.Text);

                if (sv == null)
                {
                    MessageBox.Show("Không tìm thấy sinh viên, vui lòng nhập lại");
                }
                else
                {
                    int n = 0;

                    foreach (SinhVien s in lstsv)
                    {
                        if (s.id == sv.id)
                        {
                            n = 1;
                        }

                    }
                    if (n == 0)
                    {
                        lstsv.Insert(0, sv);
                    }

                }

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = lstsv;
                guna2DataGridView1.DataSource = bindingSource;
            }
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            FormThemSinhVien formThemSinhVien = new FormThemSinhVien(wrote);
            formThemSinhVien.Show();
        }

        private void btnUpDel_Click(object sender, EventArgs e)
        {
            Form_update up = new Form_update();
            up.Show();
        }
      
        private void guna2Button4_Click_1(object sender, EventArgs e)
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
                saveFileDialog.FileName = "Danh sách sinh viên được chọn "; //{0}-{1:00}-{2:00}-{3:00}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Minute)//trungthuong2021101801
                if (saveFileDialog.ShowDialog() == DialogResult.OK)//kiểm tra nếu nhấn vào button save trên hộp thoại
                {
                    XuatFileExcel.XuatExcel(saveFileDialog.FileName, guna2DataGridView1, "Danh sách học sinh ", " ");
                    MessageBox.Show("Xuất file thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi: ", ex.Message);
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();
        }
    }
}
