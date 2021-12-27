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
    }
}
