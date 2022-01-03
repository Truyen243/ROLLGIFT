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
    }
}
