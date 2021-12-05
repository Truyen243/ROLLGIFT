using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowFrom
{
    public partial class f_grade : Form
    {
        String flag;
        public f_grade()
        {
            InitializeComponent();
        }
        DataTable dtSV;
        int index;

        public DataTable createTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSV");
            dt.Columns.Add("TenSV");

            dt.Columns.Add("Diem");
            dt.Columns.Add("Lop");
            return dt;

        }
        public void LockControl()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtMaSV.ReadOnly = true;
            txtTenSV.ReadOnly = true;
            txtDiem.ReadOnly = true;
            txtLop.ReadOnly = true;

            btnThem.Focus();
        }
        public void LockTextBox()
        {
            txtMaSV.Enabled = false;
            txtTenSV.Enabled = false;
            txtDiem.Enabled = false;
            txtLop.Enabled = false;
        }

        public void UNLockTextBox()
        {
            txtMaSV.Enabled = true;
            txtTenSV.Enabled = true;
            txtDiem.Enabled = true;
            txtLop.Enabled = true;
        }

        public void UnLockControl()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            txtMaSV.ReadOnly = false;
            txtTenSV.ReadOnly = false;
            txtDiem.ReadOnly = false;
            txtLop.ReadOnly = false;

            txtMaSV.Focus();
        }



        private void f_grade_Load(object sender, EventArgs e)
        {
            LockControl();
            LockTextBox();
            dtSV = createTable();
        }


        public bool CheckData()
        {
            if(String.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSV.Focus();
                return false;   
            }
            if(String.IsNullOrWhiteSpace(txtTenSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sinh viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSV.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show("Bạn chưa nhập điểm cho sinh viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiem.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtLop.Text))
            {
                MessageBox.Show("Bạn chưa nhập lớp cho sinh viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLop.Focus();
                return false;
            }
            return true;
        }

        private void btnThem_Click_2(object sender, EventArgs e)
        {
            UnLockControl();
            UNLockTextBox();
            flag = "add";

            txtMaSV.Text = "";
            txtTenSV.Text = "";
            txtDiem.Text = "";
            txtLop.Text = "";
        }

        private void btnSua_Click_2(object sender, EventArgs e)
        {
            UnLockControl();
            flag = "edit";
        }

        private void btnLuu_Click_2(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if (CheckData())
                {
                    dtSV.Rows.Add(txtMaSV.Text, txtTenSV.Text, txtDiem.Text, txtLop.Text);
                    dataGridSinhVien.DataSource = dtSV;
                    dataGridSinhVien.RefreshEdit();

                }
                
            }
            else if (flag == "edit")
            {
                if (CheckData())
                {
                    dtSV.Rows[index][0] = txtMaSV.Text;
                    dtSV.Rows[index][1] = txtTenSV.Text;
                    dtSV.Rows[index][2] = txtDiem.Text;
                    dtSV.Rows[index][3] = txtLop.Text;
                    dataGridSinhVien.DataSource = dtSV;
                    dataGridSinhVien.RefreshEdit();
                }
            }
            LockControl();
        }

        private void dataGridSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            index = dataGridSinhVien.CurrentCell != null ? dataGridSinhVien.CurrentCell.RowIndex : -1;

            if (index != -1)
            {
                txtMaSV.Text = dataGridSinhVien.Rows[index].Cells[0].Value.ToString();
                txtTenSV.Text = dataGridSinhVien.Rows[index].Cells[1].Value.ToString();
                txtDiem.Text = dataGridSinhVien.Rows[index].Cells[2].Value.ToString();
                txtLop.Text = dataGridSinhVien.Rows[index].Cells[3].Value.ToString();
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa sinh viên này", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==DialogResult.Yes)
            {
                dtSV.Rows.RemoveAt(index);
                dataGridSinhVien.DataSource = dtSV;
                dataGridSinhVien.RefreshEdit();
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
