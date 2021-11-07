namespace WindowFrom
{
    partial class f_quaysomayman
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGiai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dsQuay = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhongban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btQuay = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblErr = new System.Windows.Forms.ToolStripButton();
            this.dgtDanhsachtrunggiai = new System.Windows.Forms.GroupBox();
            this.dsNhanGiai = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btLayDanhSach = new System.Windows.Forms.Button();
            this.btInDanhSach = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenGiai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsQuay)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.dgtDanhsachtrunggiai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsNhanGiai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1349, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUAY SỐ MAY MẮN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbGiai
            // 
            this.cbGiai.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGiai.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbGiai.FormattingEnabled = true;
            this.cbGiai.Location = new System.Drawing.Point(12, 51);
            this.cbGiai.Name = "cbGiai";
            this.cbGiai.Size = new System.Drawing.Size(322, 31);
            this.cbGiai.TabIndex = 1;
            this.cbGiai.Text = "Chọn Giải Thưởng";
            this.cbGiai.SelectedIndexChanged += new System.EventHandler(this.CbGiai_SelectedIndexChanged);
            this.cbGiai.Click += new System.EventHandler(this.cbGiai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 36);
            this.label2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dsQuay);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(897, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 554);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách quay";
            // 
            // dsQuay
            // 
            this.dsQuay.AllowUserToAddRows = false;
            this.dsQuay.AllowUserToDeleteRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dsQuay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dsQuay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dsQuay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsQuay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colID,
            this.colTen,
            this.colPhongban});
            this.dsQuay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsQuay.Location = new System.Drawing.Point(3, 28);
            this.dsQuay.Name = "dsQuay";
            this.dsQuay.ReadOnly = true;
            this.dsQuay.RowHeadersVisible = false;
            this.dsQuay.RowHeadersWidth = 51;
            this.dsQuay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsQuay.Size = new System.Drawing.Size(446, 523);
            this.dsQuay.TabIndex = 1;
            this.dsQuay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsQuay_CellContentClick);
            // 
            // colSTT
            // 
            this.colSTT.DataPropertyName = "STT";
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 50;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colID.DefaultCellStyle = dataGridViewCellStyle23;
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            this.colID.Width = 125;
            // 
            // colTen
            // 
            this.colTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTen.DataPropertyName = "HoTen";
            this.colTen.HeaderText = "Ten";
            this.colTen.MinimumWidth = 6;
            this.colTen.Name = "colTen";
            this.colTen.ReadOnly = true;
            // 
            // colPhongban
            // 
            this.colPhongban.DataPropertyName = "PhongBan";
            this.colPhongban.HeaderText = "Phòng ban";
            this.colPhongban.MinimumWidth = 6;
            this.colPhongban.Name = "colPhongban";
            this.colPhongban.ReadOnly = true;
            this.colPhongban.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.lbl4);
            this.groupBox3.Controls.Add(this.lbl5);
            this.groupBox3.Controls.Add(this.lbl3);
            this.groupBox3.Controls.Add(this.lbl2);
            this.groupBox3.Controls.Add(this.lbl1);
            this.groupBox3.Location = new System.Drawing.Point(3, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(891, 292);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // lbl4
            // 
            this.lbl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl4.Font = new System.Drawing.Font("Microsoft Tai Le", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(515, 71);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(144, 171);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "0";
            // 
            // lbl5
            // 
            this.lbl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl5.Font = new System.Drawing.Font("Microsoft Tai Le", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(659, 71);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(144, 171);
            this.lbl5.TabIndex = 6;
            this.lbl5.Text = "0";
            // 
            // lbl3
            // 
            this.lbl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl3.Font = new System.Drawing.Font("Microsoft Tai Le", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(371, 71);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(144, 171);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "0";
            // 
            // lbl2
            // 
            this.lbl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Red;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Tai Le", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(227, 71);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(144, 171);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "0";
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl1.Font = new System.Drawing.Font("Microsoft Tai Le", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(83, 71);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(144, 171);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "0";
            // 
            // btQuay
            // 
            this.btQuay.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuay.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btQuay.Location = new System.Drawing.Point(489, 50);
            this.btQuay.Name = "btQuay";
            this.btQuay.Size = new System.Drawing.Size(123, 32);
            this.btQuay.TabIndex = 6;
            this.btQuay.Text = "Quay";
            this.btQuay.UseVisualStyleBackColor = true;
            this.btQuay.Click += new System.EventHandler(this.btQuay_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblErr});
            this.toolStrip1.Location = new System.Drawing.Point(0, 598);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1349, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblErr
            // 
            this.lblErr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lblErr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(23, 22);
            this.lblErr.Text = "...";
            // 
            // dgtDanhsachtrunggiai
            // 
            this.dgtDanhsachtrunggiai.Controls.Add(this.dsNhanGiai);
            this.dgtDanhsachtrunggiai.Controls.Add(this.toolStrip2);
            this.dgtDanhsachtrunggiai.Controls.Add(this.dataGridView1);
            this.dgtDanhsachtrunggiai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgtDanhsachtrunggiai.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgtDanhsachtrunggiai.ForeColor = System.Drawing.SystemColors.Highlight;
            this.dgtDanhsachtrunggiai.Location = new System.Drawing.Point(0, 395);
            this.dgtDanhsachtrunggiai.Name = "dgtDanhsachtrunggiai";
            this.dgtDanhsachtrunggiai.Size = new System.Drawing.Size(897, 203);
            this.dgtDanhsachtrunggiai.TabIndex = 8;
            this.dgtDanhsachtrunggiai.TabStop = false;
            this.dgtDanhsachtrunggiai.Text = "Danh sách trúng giải";
            this.dgtDanhsachtrunggiai.Enter += new System.EventHandler(this.dgtDanhsachtrunggiai_Enter);
            // 
            // dsNhanGiai
            // 
            this.dsNhanGiai.AllowUserToAddRows = false;
            this.dsNhanGiai.AllowUserToDeleteRows = false;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dsNhanGiai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle24;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dsNhanGiai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dsNhanGiai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsNhanGiai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.colTenGiai});
            this.dsNhanGiai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsNhanGiai.Location = new System.Drawing.Point(3, 23);
            this.dsNhanGiai.Name = "dsNhanGiai";
            this.dsNhanGiai.ReadOnly = true;
            this.dsNhanGiai.RowHeadersVisible = false;
            this.dsNhanGiai.RowHeadersWidth = 51;
            this.dsNhanGiai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsNhanGiai.Size = new System.Drawing.Size(891, 177);
            this.dsNhanGiai.TabIndex = 4;
            this.dsNhanGiai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Location = new System.Drawing.Point(9, 203);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(111, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(891, 177);
            this.dataGridView1.TabIndex = 0;
            // 
            // btLayDanhSach
            // 
            this.btLayDanhSach.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLayDanhSach.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btLayDanhSach.Location = new System.Drawing.Point(618, 49);
            this.btLayDanhSach.Name = "btLayDanhSach";
            this.btLayDanhSach.Size = new System.Drawing.Size(123, 32);
            this.btLayDanhSach.TabIndex = 9;
            this.btLayDanhSach.Text = "Danh Sách";
            this.btLayDanhSach.UseVisualStyleBackColor = true;
            this.btLayDanhSach.Click += new System.EventHandler(this.btLayDanhSach_Click);
            // 
            // btInDanhSach
            // 
            this.btInDanhSach.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInDanhSach.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btInDanhSach.Location = new System.Drawing.Point(747, 49);
            this.btInDanhSach.Name = "btInDanhSach";
            this.btInDanhSach.Size = new System.Drawing.Size(123, 32);
            this.btInDanhSach.TabIndex = 10;
            this.btInDanhSach.Text = "In";
            this.btInDanhSach.UseVisualStyleBackColor = true;
            this.btInDanhSach.Click += new System.EventHandler(this.btInDanhSach_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "STT";
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HoTen";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PhongBan";
            this.dataGridViewTextBoxColumn4.HeaderText = "Phòng ban";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // colTenGiai
            // 
            this.colTenGiai.DataPropertyName = "Giai";
            this.colTenGiai.HeaderText = "Tên Giải";
            this.colTenGiai.MinimumWidth = 6;
            this.colTenGiai.Name = "colTenGiai";
            this.colTenGiai.ReadOnly = true;
            this.colTenGiai.Width = 125;
            // 
            // f_quaysomayman
            // 
            this.AcceptButton = this.btQuay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 47F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 623);
            this.Controls.Add(this.btInDanhSach);
            this.Controls.Add(this.btLayDanhSach);
            this.Controls.Add(this.dgtDanhsachtrunggiai);
            this.Controls.Add(this.btQuay);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbGiai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.Name = "f_quaysomayman";
            this.Text = "f_quaysomayman";
            this.Load += new System.EventHandler(this.f_quaysomayman_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsQuay)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.dgtDanhsachtrunggiai.ResumeLayout(false);
            this.dgtDanhsachtrunggiai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsNhanGiai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGiai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dsQuay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btQuay;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton lblErr;
        private System.Windows.Forms.GroupBox dgtDanhsachtrunggiai;
        private System.Windows.Forms.DataGridView dsNhanGiai;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btLayDanhSach;
        private System.Windows.Forms.Button btInDanhSach;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhongban;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenGiai;
    }
}