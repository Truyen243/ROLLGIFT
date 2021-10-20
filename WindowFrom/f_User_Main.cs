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

namespace WindowFrom
{
    public partial class f_User_Main : Form
    {
        public f_User_Main()
        {
            InitializeComponent();
        }
        UserDAO userDAO;
        List<User> listUser;

        private void f_User_Main_Load(object sender, EventArgs e)
        {
            userDAO = new UserDAO();

            GetDataToDataGridView();
        }

        private void GetDataToDataGridView()
        {
            //Lấy được data
            userDAO.GetUser(Cls_Main.pathfile);
            listUser = userDAO.listUser;

            //Gán danh sách user vào data
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = listUser;
            dgvUserList.DataSource = bindingSource;

            lblQuantity.Text = dgvUserList.RowCount.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            f_User_Modifile f_UserModifile = new f_User_Modifile();
            f_UserModifile.isAdd = true;
            f_UserModifile.ShowDialog();
            GetDataToDataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                f_User_Modifile f_UserModifile = new f_User_Modifile();
                f_UserModifile.isAdd = false;
                f_UserModifile.user = user;
                f_UserModifile.ShowDialog();
                user = null;
                GetDataToDataGridView();
            }
            else
            {
                MessageBox.Show("");
            }
            
        }

        User user;
        private void dgvUserList_Click(object sender, EventArgs e)
        {
            if (dgvUserList.RowCount > 0)
            {
                user = new User()
                {
                    ID = Convert.ToInt32(dgvUserList.CurrentRow.Cells["colID"].Value.ToString()),
                    FullName = dgvUserList.CurrentRow.Cells["colFullName"].Value.ToString(),
                    Sex = Convert.ToBoolean(dgvUserList.CurrentRow.Cells["colSex"].Value.ToString()),
                    UserName = dgvUserList.CurrentRow.Cells["colUserName"].Value.ToString(),
                    PassWord = dgvUserList.CurrentRow.Cells["colPassWord"].Value.ToString(),
                    Remember = Convert.ToBoolean(dgvUserList.CurrentRow.Cells["colRemember"].Value.ToString()),
                    IdUserType =Convert.ToInt32(dgvUserList.CurrentRow.Cells["colIdUserType"].Value.ToString())

                };
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                userDAO.listUser.Remove(user);
                userDAO.WriteUser(Cls_Main.pathfile);
                user = null;
                GetDataToDataGridView();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefrecsh_Click(object sender, EventArgs e)
        {
            GetDataToDataGridView();
        }
    }
}
