using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WindowFrom.Data;

namespace WindowFrom
{
    public partial class f_User_Modifile : Form
    {
        //Khai báo
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public f_User_Modifile()
        {
            InitializeComponent();
            //Tạo đường viền boder-radius 10 px
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }
        public bool isAdd = false;
        UserDAO userDAO;

        private void f_User_Modifile_Load(object sender, EventArgs e)
        {
            userDAO = new UserDAO();
            userDAO.GetUser(Cls_Main.pathfile);
            LoadDataToComUserType();
            if (isAdd == true)
            {
                //Thêm User
                txtID.Text = CreateMaxID();
                txtID.Enabled = false;


            }
            else
            {
                //Sửa user
                SetDataToControl(user);
            }
        }

        private void SetDataToControl(User user)
        {
            txtID.Text = user.ID.ToString();
            txtFullName.Text = user.FullName.ToString();
            txtUserName.Text = user.UserName.ToString();
            txtPassWord.Text = user.PassWord.ToString();
            rdoMale.Checked = user.Sex;
            ckbRemember.Checked = user.Remember;
            cboUserType.SelectedValue = user.IdUserType;
        }

        private void LoadDataToComUserType()
        {
            //Có Data
            List<UserType> userType = new List<UserType>() {
                new UserType(){IDUserType = 1, NameUserType = "Admin"},
                new UserType(){IDUserType = 2, NameUserType = "User"}
            };


            //Gán vào Datasource cua combo
            cboUserType.DataSource = userType;
            //Thiết lập thuộc tính
            cboUserType.DisplayMember = "NameUserType";
            cboUserType.ValueMember = "IDUserType";


        }

        private string CreateMaxID()
        {
            string maxID = string.Empty;
            maxID = userDAO.GetMaxID().ToString();
            return maxID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }


        public User user;
        string err = string.Empty;
        private void btnUpDate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFullName.Text))
            {
                if (!string.IsNullOrEmpty(txtUserName.Text))
                {
                    if (!string.IsNullOrEmpty(txtPassWord.Text))
                    {
                        if (cboUserType.SelectedIndex > -1)
                        {
                            user = new User()
                            {
                                ID = Convert.ToInt32(txtID.Text),
                                FullName = txtFullName.Text,
                                Sex = rdoMale.Checked,
                                UserName = txtUserName.Text,
                                PassWord = txtPassWord.Text,
                                Remember = ckbRemember.Checked,
                                IdUserType = Convert.ToInt32(cboUserType.SelectedValue.ToString())
                            };

                            if (UpdateUser(ref err, user))
                            {
                                MessageBox.Show("Tạo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hãy chọn loại tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Hãy mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Hãy nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập tên hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool UpdateUser(ref string err, User user)
        {
            try
            {
                if (isAdd)
                {
                    userDAO.listUser.Add(user);
                    userDAO.WriteUser(Cls_Main.pathfile);
                    return true;
                }
                else
                {
                    foreach (User item in userDAO.listUser)
                    {
                        if (item.ID == user.ID)
                        {
                            item.FullName = user.FullName;
                            item.UserName = user.UserName;
                            item.PassWord = user.PassWord;
                            item.Sex = user.Sex;
                            item.Remember = user.Remember;
                            item.IdUserType = user.IdUserType;
                        }
                    }
                    userDAO.WriteUser(Cls_Main.pathfile);
                    return true;
                }
            }
            catch (Exception e)
            {
                err = e.Message;
            }
            return false;
        }
    }
}
