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
using System.IO;
namespace WindowsFormsApp
{
    public partial class Form_Login : Form
    {   
        
        public Form_Login()
        {
            InitializeComponent();
        }
        
        private void Form_Login_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            getRem();
            guna2CustomCheckBox1.Checked = true;
            //rq.Request();
            //rq.post();
            //rq.delete("4e596539-342e-44e6-b554-faaec514f4ad");

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.ShowDialog();
            this.Close();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
          
           
            formMain.ShowDialog();
            this.Close();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {


            if (Cls_Main.adStc.getAdmin(guna2TextBox2.Text, guna2TextBox4.Text))
            {

               if(guna2CustomCheckBox1.Checked==true)
                {
                    SaveRem();
                }    
               else
                {
                    if (File.Exists(Cls_Main.pathRem))
                    {
                        File.Delete(Cls_Main.pathRem);
                    }
                }   
                this.Hide();
                FormMain formMain = new FormMain();
                formMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nhập sai tài khoản hoặc mật khẩu");
            } 
            
            
        }
        public void SaveRem()
        {
            string path = Cls_Main.pathRem;

            if (File.Exists(path))
            {
                File.Delete(path);
            }
           
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {


                    sw.Write(string.Format("{0}\n{1}", guna2TextBox2.Text, guna2TextBox4.Text));

                }
            }
        }
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
                        List<string> list = new List<string>();
                        
                        //listUser.Clear();
                        while ((line = sr.ReadLine()) != null)
                        {
                            list.Add(line);
                            //Kiểm tra xem line có giá trị hay không
                        }
                        string[] userArray = list.ToArray();
                        guna2TextBox2.Text = userArray[0];
                        guna2TextBox4.Text = userArray[1];

                    }
                }
            }
        }

        private void guna2TextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
