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
    public partial class FormSinhVien : UserControl
    {
        DataTable dtSV;
        int index;
        String flag;

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
        public bool CheckData()
        {
            if (String.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSV.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sinh viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtNgaySinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh cho sinh viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNgaySinh.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ cho sinh viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtSoDT.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại cho sinh viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoDT.Focus();
                return false;
            }
            return true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            UnLockControl();
            UNLockTextBox();
            flag = "add";

            txtMaSV.Text = "";
            txtHoTen.Text = "";
            txtNgaySinh.Text = "";
            cmbGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtSoDT.Text = "";
        }

        private void FormSinhVien_Load(object sender, EventArgs e)
        {
            LockControl();
            //LockTextBox();
            dtSV = createTable();
        }
        public void UnLockControl()
        {
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;

            txtMaSV.ReadOnly = false;
            txtHoTen.ReadOnly = false;
            txtNgaySinh.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtSoDT.ReadOnly = false;

            txtMaSV.Focus();
        }
        public void UNLockTextBox()
        {
            txtMaSV.Enabled = true;
            txtHoTen.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSoDT.Enabled = true;
            cmbGioiTinh.Enabled = true;
        }
        public void LockTextBox()
        {
            txtMaSV.Enabled = false;
            txtHoTen.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSoDT.Enabled = false;
            cmbGioiTinh.Enabled = false;
        }
        public void LockControl()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;

            txtMaSV.ReadOnly = true;
            txtHoTen.ReadOnly = true;
            txtNgaySinh.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtSoDT.ReadOnly = true;
            cmbGioiTinh.Enabled = true;
            

            btnSave.Focus();
        }
        public DataTable createTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSV");
            dt.Columns.Add("HoTen");

            dt.Columns.Add("NgaySinh");
            dt.Columns.Add("GioiTinh");

            dt.Columns.Add("DiaChi");
            dt.Columns.Add("SoDienThoai");
            return dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if (CheckData())
                {
                    dtSV.Rows.Add(txtMaSV.Text, txtHoTen.Text, txtNgaySinh.Text, cmbGioiTinh.Text, txtDiaChi.Text, txtSoDT.Text);
                    DataGridViewSinhVien.DataSource = dtSV;
                    DataGridViewSinhVien.RefreshEdit();

                }

            }
            else if (flag == "edit")
            {
                if (CheckData())
                {
                    dtSV.Rows[index][0] = txtMaSV.Text;
                    dtSV.Rows[index][1] = txtHoTen.Text;
                    dtSV.Rows[index][2] = txtNgaySinh.Text;
                    dtSV.Rows[index][3] = cmbGioiTinh.Text;
                    dtSV.Rows[index][3] = txtDiaChi.Text;
                    dtSV.Rows[index][3] = txtSoDT.Text;
                    DataGridViewSinhVien.DataSource = dtSV;
                    DataGridViewSinhVien.RefreshEdit();
                }
            }
            LockControl();
        }
    }

}
