using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowFrom.Data;
using System.Drawing;
using System.Runtime.InteropServices;

namespace WindowFrom
{
    public partial class f_Login : Form
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
        //constructor
        public f_Login()
        {
            InitializeComponent();
            //Tạo đường viền boder-radius 10 px
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }
        //Khởi tạo shadown
        private const int CS_DropShadow = 0 * 00020000;
        public List<User> listUser;
        UserDAO _userDAO;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        //UserDAO _user;

        private void f_Login_Load(object sender, EventArgs e)
        {
            _userDAO = new UserDAO();
            _userDAO.GetUser(Cls_Main.pathfile);
            Cls_Main._listUser = _userDAO.listUser;
            
            listUser = _userDAO.listUser;

            getRem();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Kiểm tra đăng nhập
            if (!string.IsNullOrEmpty(txbUserName.Text))
            {
                if (!string.IsNullOrEmpty(txbPassWord.Text))
                {
                    
                    if(Kiemtradangnhap(txbUserName.Text, txbPassWord.Text))
                    {
                        if(chbRemember.Checked)
                        {
                            SaveRem(Cls_Main.pathRem);
                        }
                        else if (File.Exists(Cls_Main.pathRem))
                        {
                            File.Delete(Cls_Main.pathRem);
                        }
                        
                        
                        f_Main main = new f_Main();
                        this.Hide();
                        main.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nhập sai tên đăng nhập hoặc mật khẩu", "Thông báo");
                    }
                }
            }
        }
        // hàm để lưu mật khẩu
        public void SaveRem(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {


                        sw.WriteLine(string.Format("{0},{1}", txbUserName.Text, txbPassWord.Text));

                }
            }
        }    
        // hàm để lấy tài khoản mật khẩu đã lưu
        public void getRem()
        {
            string path = Cls_Main.pathRem;
            if (File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line = string.Empty;

                        //listUser.Clear();
                        while ((line = sr.ReadLine()) != null)
                        {
                            //Kiểm tra xem line có giá trị hay không
                            if (!string.IsNullOrEmpty(line))
                            {
                                string[] userArray = line.Split(',');
                                txbUserName.Text = userArray[0];
                                txbPassWord.Text = userArray[1];
                            }
                        }

                    }
                }
            }
        }    
        private bool Kiemtradangnhap(string userName, string passWord)
        {
            foreach (User item in Cls_Main._listUser)
            {
                //Console.WriteLine(item.GetString());
                if (item.UserName.Equals(userName) && item.PassWord.Equals(passWord))
                {
                    item.Remember = chbRemember.Checked;
                    Cls_Main._staticUser = item;
                    return true;
                }

            }
            return false;

        }

        //private void f_Login_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
        //    {
        //        e.Cancel = true;
        //    }
        //}

        //hàm nhớ mật khẩu
        private void txbUserName_Leave(object sender, EventArgs e)
        {
             foreach (User item in listUser)
             {
                 if (item.UserName==txbUserName.Text && item.Remember)
                 {
                     chbRemember.Checked = true;
                     txbPassWord.Text = item.PassWord;
                     btnLogin.Focus();
                 }
             }
            
        }
    }
}
