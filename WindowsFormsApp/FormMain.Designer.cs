
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.formUser1 = new WindowsFormsApp.FormUser();
            this.btnDiem = new Guna.UI2.WinForms.Guna2Button();
            this.btnMonHoc = new Guna.UI2.WinForms.Guna2Button();
            this.btnSinhVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnKhoa = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.gunaContextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lookUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ìnormationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.formKhoa1 = new WindowsFormsApp.FormKhoa();
            this.formDiem1 = new WindowsFormsApp.FormDiem();
            this.formMonHoc1 = new WindowsFormsApp.FormMonHoc();
            this.formSinhVien1 = new WindowsFormsApp.FormSinhVien();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.gunaContextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel2.Controls.Add(this.formUser1);
            this.guna2Panel2.Controls.Add(this.btnDiem);
            this.guna2Panel2.Controls.Add(this.btnMonHoc);
            this.guna2Panel2.Controls.Add(this.btnSinhVien);
            this.guna2Panel2.Controls.Add(this.btnKhoa);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2Panel2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.guna2Panel2.Location = new System.Drawing.Point(0, 34);
            this.guna2Panel2.MaximumSize = new System.Drawing.Size(220, 566);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(202, 566);
            this.guna2Panel2.TabIndex = 1;
            // 
            // formUser1
            // 
            this.formUser1.AutoSize = true;
            this.formUser1.Location = new System.Drawing.Point(31, 1);
            this.formUser1.Name = "formUser1";
            this.formUser1.Size = new System.Drawing.Size(133, 136);
            this.formUser1.TabIndex = 4;
            // 
            // btnDiem
            // 
            this.btnDiem.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDiem.CheckedState.Parent = this.btnDiem;
            this.btnDiem.CustomBorderThickness = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnDiem.CustomImages.Parent = this.btnDiem;
            this.btnDiem.FillColor = System.Drawing.Color.White;
            this.btnDiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDiem.ForeColor = System.Drawing.Color.Black;
            this.btnDiem.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.btnDiem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnDiem.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.btnDiem.HoverState.Parent = this.btnDiem;
            this.btnDiem.Location = new System.Drawing.Point(2, 260);
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.PressedDepth = 0;
            this.btnDiem.ShadowDecoration.Parent = this.btnDiem;
            this.btnDiem.Size = new System.Drawing.Size(197, 45);
            this.btnDiem.TabIndex = 3;
            this.btnDiem.Text = "Điểm";
            this.btnDiem.Click += new System.EventHandler(this.btnDiem_Click);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMonHoc.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMonHoc.CheckedState.Parent = this.btnMonHoc;
            this.btnMonHoc.CustomBorderThickness = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnMonHoc.CustomImages.Parent = this.btnMonHoc;
            this.btnMonHoc.FillColor = System.Drawing.Color.White;
            this.btnMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMonHoc.ForeColor = System.Drawing.Color.Black;
            this.btnMonHoc.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.btnMonHoc.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnMonHoc.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.btnMonHoc.HoverState.Parent = this.btnMonHoc;
            this.btnMonHoc.Location = new System.Drawing.Point(2, 209);
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.PressedDepth = 0;
            this.btnMonHoc.ShadowDecoration.Parent = this.btnMonHoc;
            this.btnMonHoc.Size = new System.Drawing.Size(197, 45);
            this.btnMonHoc.TabIndex = 2;
            this.btnMonHoc.Text = "Môn Học";
            this.btnMonHoc.Click += new System.EventHandler(this.btnMonHoc_Click);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSinhVien.Checked = true;
            this.btnSinhVien.CheckedState.Parent = this.btnSinhVien;
            this.btnSinhVien.CustomBorderThickness = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnSinhVien.CustomImages.Parent = this.btnSinhVien;
            this.btnSinhVien.FillColor = System.Drawing.Color.White;
            this.btnSinhVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSinhVien.ForeColor = System.Drawing.Color.Black;
            this.btnSinhVien.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.btnSinhVien.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSinhVien.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.btnSinhVien.HoverState.Parent = this.btnSinhVien;
            this.btnSinhVien.Location = new System.Drawing.Point(2, 158);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.PressedDepth = 0;
            this.btnSinhVien.ShadowDecoration.Parent = this.btnSinhVien;
            this.btnSinhVien.Size = new System.Drawing.Size(197, 45);
            this.btnSinhVien.TabIndex = 1;
            this.btnSinhVien.Text = "Sinh Viên";
            this.btnSinhVien.Click += new System.EventHandler(this.btnSinhVien_Click);
            // 
            // btnKhoa
            // 
            this.btnKhoa.BackColor = System.Drawing.Color.White;
            this.btnKhoa.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnKhoa.CheckedState.Parent = this.btnKhoa;
            this.btnKhoa.CustomBorderThickness = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnKhoa.CustomImages.Parent = this.btnKhoa;
            this.btnKhoa.FillColor = System.Drawing.Color.White;
            this.btnKhoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKhoa.ForeColor = System.Drawing.Color.Black;
            this.btnKhoa.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.btnKhoa.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnKhoa.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.btnKhoa.HoverState.Parent = this.btnKhoa;
            this.btnKhoa.Location = new System.Drawing.Point(3, 311);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.PressedDepth = 0;
            this.btnKhoa.ShadowDecoration.Parent = this.btnKhoa;
            this.btnKhoa.Size = new System.Drawing.Size(197, 45);
            this.btnKhoa.TabIndex = 0;
            this.btnKhoa.Text = "Lớp";
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1052, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox3);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1100, 34);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1001, 2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 5;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.Animated = true;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ControlBox3.HoverState.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.Location = new System.Drawing.Point(950, 2);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.ShadowDecoration.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 4;
            this.guna2ControlBox3.Click += new System.EventHandler(this.guna2ControlBox3_Click);
            // 
            // gunaContextMenuStrip1
            // 
            this.gunaContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.gunaContextMenuStrip1.Name = "gunaContextMenuStrip1";
            this.gunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.ColorTable = null;
            this.gunaContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.gunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaContextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            this.gunaContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.gunaContextMenuStrip1_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem1.Text = "Sytem";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lookUpToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.chứcNăngToolStripMenuItem.Text = "Tool";
            // 
            // lookUpToolStripMenuItem
            // 
            this.lookUpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ìnormationToolStripMenuItem});
            this.lookUpToolStripMenuItem.Name = "lookUpToolStripMenuItem";
            this.lookUpToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.lookUpToolStripMenuItem.Text = "Look Up";
            // 
            // ìnormationToolStripMenuItem
            // 
            this.ìnormationToolStripMenuItem.Name = "ìnormationToolStripMenuItem";
            this.ìnormationToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.ìnormationToolStripMenuItem.Text = "Ìnormation";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(0, 27);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(898, 67);
            this.gunaLabel1.TabIndex = 7;
            this.gunaLabel1.Text = "Manage Student";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.AutoSize = true;
            this.guna2TextBox1.BorderRadius = 16;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(0, 108);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Nhập Thông Tin Cần Tìm";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(276, 31);
            this.guna2TextBox1.TabIndex = 10;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 16;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(309, 105);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(82, 34);
            this.guna2Button1.TabIndex = 9;
            this.guna2Button1.Text = "Find";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2DateTimePicker1.BorderRadius = 16;
            this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(631, 97);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(261, 40);
            this.guna2DateTimePicker1.TabIndex = 13;
            this.guna2DateTimePicker1.Value = new System.DateTime(2021, 12, 10, 21, 18, 17, 145);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.systemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(898, 33);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("informationToolStripMenuItem.Image")));
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(139, 29);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click_1);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.ToolStripRefresh});
            this.systemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("systemToolStripMenuItem.Image")));
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // ToolStripRefresh
            // 
            this.ToolStripRefresh.Image = global::WindowsFormsApp.Properties.Resources.icons8_refresh_32;
            this.ToolStripRefresh.Name = "ToolStripRefresh";
            this.ToolStripRefresh.Size = new System.Drawing.Size(180, 30);
            this.ToolStripRefresh.Text = "Refresh";
            this.ToolStripRefresh.Click += new System.EventHandler(this.ToolStripRefresh_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.Controls.Add(this.menuStrip1);
            this.guna2Panel3.Controls.Add(this.guna2DateTimePicker1);
            this.guna2Panel3.Controls.Add(this.guna2Button1);
            this.guna2Panel3.Controls.Add(this.guna2TextBox1);
            this.guna2Panel3.Controls.Add(this.gunaLabel1);
            this.guna2Panel3.Location = new System.Drawing.Point(202, 34);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(898, 143);
            this.guna2Panel3.TabIndex = 12;
            this.guna2Panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel3_Paint);
            // 
            // formKhoa1
            // 
            this.formKhoa1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formKhoa1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.formKhoa1.Location = new System.Drawing.Point(202, 177);
            this.formKhoa1.Name = "formKhoa1";
            this.formKhoa1.Size = new System.Drawing.Size(898, 421);
            this.formKhoa1.TabIndex = 16;
            // 
            // formDiem1
            // 
            this.formDiem1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formDiem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.formDiem1.Location = new System.Drawing.Point(202, 177);
            this.formDiem1.Name = "formDiem1";
            this.formDiem1.Size = new System.Drawing.Size(898, 421);
            this.formDiem1.TabIndex = 15;
            // 
            // formMonHoc1
            // 
            this.formMonHoc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formMonHoc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.formMonHoc1.Location = new System.Drawing.Point(202, 177);
            this.formMonHoc1.Name = "formMonHoc1";
            this.formMonHoc1.Size = new System.Drawing.Size(898, 421);
            this.formMonHoc1.TabIndex = 14;
            // 
            // formSinhVien1
            // 
            this.formSinhVien1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formSinhVien1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.formSinhVien1.Location = new System.Drawing.Point(202, 177);
            this.formSinhVien1.Name = "formSinhVien1";
            this.formSinhVien1.Size = new System.Drawing.Size(898, 421);
            this.formSinhVien1.TabIndex = 13;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.formKhoa1);
            this.Controls.Add(this.formDiem1);
            this.Controls.Add(this.formMonHoc1);
            this.Controls.Add(this.formSinhVien1);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.gunaContextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnDiem;
        private Guna.UI2.WinForms.Guna2Button btnMonHoc;
        private Guna.UI2.WinForms.Guna2Button btnSinhVien;
        private Guna.UI2.WinForms.Guna2Button btnKhoa;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lookUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ìnormationToolStripMenuItem;
        private FormUser formUser1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private System.Windows.Forms.ToolStripMenuItem ToolStripRefresh;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private FormSinhVien formSinhVien1;
        private FormMonHoc formMonHoc1;
        private FormDiem formDiem1;
        private FormKhoa formKhoa1;
    }
}

