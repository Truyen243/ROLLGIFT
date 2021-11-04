using f_quaysomayman;
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
using WindowsFormsQuaySo;

namespace WindowFrom
{
    public partial class f_quaysomayman : Form
    {
        List<Nhanvien> nhanviens;
        NhanVienDAO NhanVienDAO;

        public f_quaysomayman()
        {
            InitializeComponent();
        }

        List<NhanVienNhanGiai> nhanVienNhanGiais;
        NhanVienNhanGiaiDAO nhanVienNhanGiaiDAO;
        private void frmQuaySoMayMan_Load(object sender, EventArgs e)
        {
            Nhanviens = new List<Nhanvien>();
            NhanVienDAO = new NhanVienDAO();
            nhanVienNhanGiais = new List<NhanVienNhanGiai>();
            nhanVienNhanGiaiDAO = new NhanVienNhanGiaiDAO();
            cbGiai();


        }
        private void f_quaysomayman_Load(object sender, EventArgs e)
        {
             nhanviens= new List<Nhanvien>();
            NhanVienDAO= new NhanVienDAO();
        }
        private void btQuay_Click(object sender, EventArgs e)
        {
            if (Nhanviens.Count > 0)
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
                    ThemDSGiai(NhanvienID);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn danh sách");
            }

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
                NhanVienDAO.DocFileDanhSach(path);
                nhanviens = NhanVienDAO.nhanviens;
                HienThiDanhSachNhanVien();
            }
            //openFileDialog.ShowDialog();
        }

        private void HienThiDanhSachNhanVien()
        {
            dsQuay.DataSource = nhanviens;
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = bindingSource;
        }

        private void CbGiai_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                GiaiThuongDAO giaiThuong = new GiaiThuongDAO();
                giaiThuong.DocFileDanhSachGiaiThuong(Application.StartupPath + @"\GiaiThuong.ini");

                cbGiai.DataSource = giaiThuong.giaiThuongs;

                cbGiai.DisplayMember = "TenGiai";
                cbGiai.ValueMember = "ID";
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

        private void label7_Click(object sender, EventArgs e)
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
    }
}

