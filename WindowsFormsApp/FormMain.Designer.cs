
namespace WindowsFormsApp
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDiem = new Guna.UI2.WinForms.Guna2Button();
            this.btnMonHoc = new Guna.UI2.WinForms.Guna2Button();
            this.btnSinhVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnKhoa = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.formDiem1 = new WindowsFormsApp.FormDiem();
            this.formMonHoc1 = new WindowsFormsApp.FormMonHoc();
            this.formKhoa1 = new WindowsFormsApp.FormKhoa();
            this.formSinhVien1 = new WindowsFormsApp.FormSinhVien();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel2.Controls.Add(this.btnDiem);
            this.guna2Panel2.Controls.Add(this.btnMonHoc);
            this.guna2Panel2.Controls.Add(this.btnSinhVien);
            this.guna2Panel2.Controls.Add(this.btnKhoa);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2Panel2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 34);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(202, 566);
            this.guna2Panel2.TabIndex = 1;
            // 
            // btnDiem
            // 
            this.btnDiem.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDiem.CheckedState.Parent = this.btnDiem;
            this.btnDiem.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnDiem.CustomImages.Parent = this.btnDiem;
            this.btnDiem.FillColor = System.Drawing.Color.White;
            this.btnDiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDiem.ForeColor = System.Drawing.Color.Black;
            this.btnDiem.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnDiem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnDiem.HoverState.Parent = this.btnDiem;
            this.btnDiem.Location = new System.Drawing.Point(2, 260);
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.PressedDepth = 0;
            this.btnDiem.ShadowDecoration.Parent = this.btnDiem;
            this.btnDiem.Size = new System.Drawing.Size(197, 45);
            this.btnDiem.TabIndex = 3;
            this.btnDiem.Text = "Điểm";
            this.btnDiem.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMonHoc.CheckedState.Parent = this.btnMonHoc;
            this.btnMonHoc.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnMonHoc.CustomImages.Parent = this.btnMonHoc;
            this.btnMonHoc.FillColor = System.Drawing.Color.White;
            this.btnMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMonHoc.ForeColor = System.Drawing.Color.Black;
            this.btnMonHoc.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnMonHoc.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnMonHoc.HoverState.Parent = this.btnMonHoc;
            this.btnMonHoc.Location = new System.Drawing.Point(2, 209);
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.PressedDepth = 0;
            this.btnMonHoc.ShadowDecoration.Parent = this.btnMonHoc;
            this.btnMonHoc.Size = new System.Drawing.Size(197, 45);
            this.btnMonHoc.TabIndex = 2;
            this.btnMonHoc.Text = "Môn Học";
            this.btnMonHoc.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSinhVien.CheckedState.Parent = this.btnSinhVien;
            this.btnSinhVien.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnSinhVien.CustomImages.Parent = this.btnSinhVien;
            this.btnSinhVien.FillColor = System.Drawing.Color.White;
            this.btnSinhVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSinhVien.ForeColor = System.Drawing.Color.Black;
            this.btnSinhVien.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSinhVien.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnSinhVien.HoverState.Parent = this.btnSinhVien;
            this.btnSinhVien.Location = new System.Drawing.Point(2, 158);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.PressedDepth = 0;
            this.btnSinhVien.ShadowDecoration.Parent = this.btnSinhVien;
            this.btnSinhVien.Size = new System.Drawing.Size(197, 45);
            this.btnSinhVien.TabIndex = 1;
            this.btnSinhVien.Text = "Sinh Viên";
            this.btnSinhVien.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnKhoa
            // 
            this.btnKhoa.BackColor = System.Drawing.Color.White;
            this.btnKhoa.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnKhoa.Checked = true;
            this.btnKhoa.CheckedState.Parent = this.btnKhoa;
            this.btnKhoa.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnKhoa.CustomImages.Parent = this.btnKhoa;
            this.btnKhoa.FillColor = System.Drawing.Color.White;
            this.btnKhoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKhoa.ForeColor = System.Drawing.Color.Black;
            this.btnKhoa.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnKhoa.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnKhoa.HoverState.Parent = this.btnKhoa;
            this.btnKhoa.Location = new System.Drawing.Point(2, 107);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.PressedDepth = 0;
            this.btnKhoa.ShadowDecoration.Parent = this.btnKhoa;
            this.btnKhoa.Size = new System.Drawing.Size(197, 45);
            this.btnKhoa.TabIndex = 0;
            this.btnKhoa.Text = "Khoa";
            this.btnKhoa.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1052, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 2;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1001, 2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 3;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.guna2ControlBox3.HoverState.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.Location = new System.Drawing.Point(950, 2);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.ShadowDecoration.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 4;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.guna2Panel1.Controls.Add(this.guna2ControlBox3);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1100, 34);
            this.guna2Panel1.TabIndex = 0;
            // 
            // formDiem1
            // 
            this.formDiem1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formDiem1.BackColor = System.Drawing.Color.Crimson;
            this.formDiem1.Location = new System.Drawing.Point(202, 34);
            this.formDiem1.Name = "formDiem1";
            this.formDiem1.Size = new System.Drawing.Size(898, 566);
            this.formDiem1.TabIndex = 5;
            // 
            // formMonHoc1
            // 
            this.formMonHoc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formMonHoc1.BackColor = System.Drawing.Color.Coral;
            this.formMonHoc1.Location = new System.Drawing.Point(202, 34);
            this.formMonHoc1.Name = "formMonHoc1";
            this.formMonHoc1.Size = new System.Drawing.Size(898, 566);
            this.formMonHoc1.TabIndex = 4;
            // 
            // formKhoa1
            // 
            this.formKhoa1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formKhoa1.AutoSize = true;
            this.formKhoa1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.formKhoa1.Location = new System.Drawing.Point(202, 34);
            this.formKhoa1.Name = "formKhoa1";
            this.formKhoa1.Size = new System.Drawing.Size(898, 566);
            this.formKhoa1.TabIndex = 2;
            // 
            // formSinhVien1
            // 
            this.formSinhVien1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formSinhVien1.BackColor = System.Drawing.Color.Chartreuse;
            this.formSinhVien1.Location = new System.Drawing.Point(202, 34);
            this.formSinhVien1.Name = "formSinhVien1";
            this.formSinhVien1.Size = new System.Drawing.Size(898, 566);
            this.formSinhVien1.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.formDiem1);
            this.Controls.Add(this.formMonHoc1);
            this.Controls.Add(this.formKhoa1);
            this.Controls.Add(this.formSinhVien1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnDiem;
        private Guna.UI2.WinForms.Guna2Button btnMonHoc;
        private Guna.UI2.WinForms.Guna2Button btnSinhVien;
        private Guna.UI2.WinForms.Guna2Button btnKhoa;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private FormSinhVien formSinhVien1;
        private FormKhoa formKhoa1;
        private FormDiem formDiem1;
        private FormMonHoc formMonHoc1;
    }
}

