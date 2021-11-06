
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowFrom.Data;

using LibraryClass.Dao;
using LibraryClass.EF;
namespace WindowFrom
{
    public partial class f_quaysomayman : Form
    {
        List<Employee> employees;
        EmployeeDao employeeDao;
        public f_quaysomayman()
        {
            InitializeComponent();
        }
        bool isOpen = fasle;//Diều khiển button, dừng và quay
        List<NhanVienNhanGiai> nhanVienNhanGiais;
        NhanVienNhanGiaiDAO nhanVienNhanGiaiDAO;
        private void f_quaysomayman_Load(object sender, EventArgs e)
        {
            
            employees = new List<Employee>();
            employeeDao = new EmployeeDao(Cls_Main.typeDatabase,Cls_Main.pathGiaiThuong);
            nhanVienNhanGiais = new List<NhanVienNhanGiai>();
            nhanVienNhanGiaiDAO = new NhanVienNhanGiaiDAO();
            LoadComboGiaiThuong();
            GiaiThuongDAO giaiThuong = new GiaiThuongDAO();
            giaiThuong.DocFileDanhSachGiaiThuong(Cls_Main.pathGiaiThuong);

            cbGiai.DataSource = giaiThuong.giaiThuongs;

            cbGiai.DisplayMember = "tenGiai";
            cbGiai.ValueMember = "iD";
            

        }
        private void LoadComboGiaiThuong()
        {
            GiaiThuongDAO giaiThuong = new GiaiThuongDAO();
            giaiThuong.DocFileDanhSachGiaiThuong(Cls_Main.pathGiaiThuong);

            cbGiai.DataSource = giaiThuong.giaiThuongs;

            cbGiai.DisplayMember = "TenGiai";
            cbGiai.ValueMember = "ID";
            
        }
        /* private void f_quaysomayman_Load(object sender, EventArgs e)
         {
              nhanviens= new List<Nhanvien>();
             NhanVienDAO= new NhanVienDAO();
         }*/
        int EmployeeID = 0;
        private void btQuay_Click(object sender, EventArgs e)
        {
            if (employees.Count > 0)
            {
                if (isOpen)
                {
                    timer1.Enabled = true;
                    btQuay.Text = "Dừng";
                    isOpen = false;

                }
                else
                {
                    timer1.Enabled = false;
                    btQuay.Text = "Quay";
                    isOpen = true;
                    ThemDanhSachGiai(EmployeeID);
                }
            }
            else
            {
                MessageBox.Show("Chua chon danh sach");
            }
            
        }
        private void ThemDanhSachGiai(int ID)
        {
            //Lấy danh sách nhân viên sau khi quay được giải theo mã số
            Employee employee = employeeDao.GetNhanNhanTheoID(ID);
            //Tạo một đối tượng nhân viên giải
            NhanVienNhanGiai nhanVienNhanGiai = new NhanVienNhanGiai()
            {
                ID = employee.ID,
                HoTen = employee.HoTen,
                PhongBan = employee.PhongBan,
                Giai = cboGiaiThuong.Text
            };
            //Thêm vào danh sách
            nhanVienNhanGiais.Add(nhanVienNhanGiai);
            HienThiDanhsachNhanGiai();
        }

        private void btLayDanhSach_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.ini)|*.ini|All files (*.*)|*.*";
            openFileDialog.Title = "Chọn danh sách quay";
            openFileDialog.InitialDirectory = Application.StartupPath;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                //Gọi hàm đọc file
                employeeDao.ReadData(path);
                employees = employeeDao.employees;
                HienThiDanhSachNhanVien();
            }
            //openFileDialog.ShowDialog();
        }

        private void HienThiDanhSachNhanVien()
        {
            int i = 1;
            foreach (Employee item in employees)
            {
                item.STT = i++;
            }
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = employees;
            dsQuay.DataSource = bindingSource;
        }

        private void CbGiai_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
               /* GiaiThuongDAO giaiThuong = new GiaiThuongDAO();
                giaiThuong.DocFileDanhSachGiaiThuong(Cls_Main.pathGiaiThuong);

                cbGiai.DataSource = giaiThuong.giaiThuongs;

                cbGiai.DisplayMember = "tenGiai";
                cbGiai.ValueMember = "iD";
                */
            }
            bool isOpen = true;
        }
        private void btInDanhSach_Click(object sender, EventArgs e)
        {
            if (nhanVienNhanGiais.Count > 0)
            {
                try
                {
                    //Đối tường SaveFileDialog cho phép hiển thị một hộp thoại saveFile. Hộp thoại này cho phép nhập tên file và nơi lưu file Excel 
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    //Hien thi thu muc khoi tao
                    saveFileDialog.InitialDirectory = @"d:\";
                    //xác định vị trí có được nhớ lại khi mở tiếp hộp thoại này hay không 
                    saveFileDialog.RestoreDirectory = true;

                    saveFileDialog.Filter = "Text files (*.xls)|*.xls|All files (*.*)|*.*";//Lọc loại file
                    saveFileDialog.DefaultExt = "xls";//Phần mở rộng mặc định
                    saveFileDialog.AddExtension = true;

                    saveFileDialog.Title = "Lưu file Excel";//Tiêu đề của hộp thoại
                    saveFileDialog.FileName = string.Format("TrungThuong_{0}{1:00}{2:00}{3:00}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Minute);//trungthuong2021101801
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)//kiểm tra nếu nhấn vào button save trên hộp thoại
                    {
                        //Thực hiện lấy danh sách nhân viên nhận giải
                        nhanVienNhanGiaiDAO.nhanVienNhanGiais = nhanVienNhanGiais;
                        //Luu danh sachs nhan vien nhan giai vào file NhanVienNhanGiai.ini
                        nhanVienNhanGiaiDAO.GhiNoiDung(Cls_Main.pathNhanVienNhanGiai);
                        //thực hiện thao tác ghi nội dung vào file Excel 
                        nhanVienNhanGiaiDAO.XuatExcel(saveFileDialog.FileName);
                        MessageBox.Show("Xuất file thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi: ", ex.Message);
                }

            }

        }
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dsQuay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dgtDanhsachtrunggiai_Enter(object sender, EventArgs e)
        {

        }

        private void cbGiai_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();//đối tượng sinh số ngẫu nhiên.
            int a = random.Next(1, employees.Count);
            EmployeeID = employees[a].ID;
            TachID(EmployeeID);
        }
        private void TachID(int iD)
        {
            int number = iD;//1234
            if (number > 0)
            {
                lbl1.Text = (number % 10).ToString();
                number = number / 10;
            }
            if (number > 0)
            {
                lbl2.Text = (number % 10).ToString();
                number = number / 10;
            }
            if (number > 0)
            {
                lbl3.Text = (number % 10).ToString();
                number = number / 10;
            }
            if (number > 0)
            {
                lbl4.Text = (number % 10).ToString();
                number = number / 10;
            }
            if (number > 0)
            {
                lbl5.Text = (number % 10).ToString();
                number = number / 10;
            }

        }
        private void TachID(int iD)
        {
            int number = iD;//1234
            if (number > 0)
            {
                lbl1.Text = (number % 10).ToString();
                number = number / 10;
            }
            if (number > 0)
            {
                lbl2.Text = (number % 10).ToString();
                number = number / 10;
            }
            if (number > 0)
            {
                lbl3.Text = (number % 10).ToString();
                number = number / 10;
            }
            if (number > 0)
            {
                lbl4.Text = (number % 10).ToString();
                number = number / 10;
            }
            if (number > 0)
            {
                lbl5.Text = (number % 10).ToString();
                number = number / 10;
            }

        }
    }
}

