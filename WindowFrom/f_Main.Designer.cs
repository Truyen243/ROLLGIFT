
namespace WindowFrom
{
    partial class f_Main
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnChangedPassWord = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSignupAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUserList = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslblInFo = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.mnFile});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1053, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnExit});
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Home";
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(128, 22);
            this.mnExit.Text = "Đăng xuất";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // mnFile
            // 
            this.mnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnChangedPassWord,
            this.mnSignupAccount,
            this.mnUserList});
            this.mnFile.Name = "mnFile";
            this.mnFile.Size = new System.Drawing.Size(57, 20);
            this.mnFile.Text = "System";
            // 
            // mnChangedPassWord
            // 
            this.mnChangedPassWord.Name = "mnChangedPassWord";
            this.mnChangedPassWord.Size = new System.Drawing.Size(177, 22);
            this.mnChangedPassWord.Text = "Changed PassWord";
            this.mnChangedPassWord.Click += new System.EventHandler(this.mnChangedPassWord_Click);
            // 
            // mnSignupAccount
            // 
            this.mnSignupAccount.Name = "mnSignupAccount";
            this.mnSignupAccount.Size = new System.Drawing.Size(177, 22);
            this.mnSignupAccount.Text = "Resgist User";
            this.mnSignupAccount.Click += new System.EventHandler(this.mnSignupAccount_Click_1);
            // 
            // mnUserList
            // 
            this.mnUserList.Name = "mnUserList";
            this.mnUserList.Size = new System.Drawing.Size(177, 22);
            this.mnUserList.Text = "List User";
            this.mnUserList.Click += new System.EventHandler(this.mnUserList_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblInFo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 563);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1053, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslblInFo
            // 
            this.tsslblInFo.Name = "tsslblInFo";
            this.tsslblInFo.Size = new System.Drawing.Size(16, 17);
            this.tsslblInFo.Text = "...";
            // 
            // f_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1053, 585);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip2);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "f_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roll Gift";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.f_Main_FormClosing);
            this.Load += new System.EventHandler(this.f_Main_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslblInFo;
        private System.Windows.Forms.ToolStripMenuItem mnFile;
        private System.Windows.Forms.ToolStripMenuItem mnChangedPassWord;
        private System.Windows.Forms.ToolStripMenuItem mnUserList;
        private System.Windows.Forms.ToolStripMenuItem mnSignupAccount;
    }
}