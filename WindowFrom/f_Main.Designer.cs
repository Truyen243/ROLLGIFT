
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_Main));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnChangedPassWord = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSignupAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUserList = new System.Windows.Forms.ToolStripMenuItem();
            this.rollGiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslblInFo = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 20, 0, 2);
            this.menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.mnFile,
            this.rollGiftToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Margin = new System.Windows.Forms.Padding(20);
            this.menuStrip2.MdiWindowListItem = this.mnFile;
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip2.Size = new System.Drawing.Size(741, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnExit});
            this.thôngTinCáNhânToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thôngTinCáNhânToolStripMenuItem.Image")));
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Home";
            // 
            // mnExit
            // 
            this.mnExit.Image = ((System.Drawing.Image)(resources.GetObject("mnExit.Image")));
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(160, 26);
            this.mnExit.Text = "Đăng xuất";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // mnFile
            // 
            this.mnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnChangedPassWord,
            this.mnSignupAccount,
            this.mnUserList});
            this.mnFile.Image = ((System.Drawing.Image)(resources.GetObject("mnFile.Image")));
            this.mnFile.Name = "mnFile";
            this.mnFile.Size = new System.Drawing.Size(97, 24);
            this.mnFile.Text = "Manage";
            // 
            // mnChangedPassWord
            // 
            this.mnChangedPassWord.Image = ((System.Drawing.Image)(resources.GetObject("mnChangedPassWord.Image")));
            this.mnChangedPassWord.Name = "mnChangedPassWord";
            this.mnChangedPassWord.Size = new System.Drawing.Size(218, 26);
            this.mnChangedPassWord.Text = "Changed PassWord";
            this.mnChangedPassWord.Click += new System.EventHandler(this.mnChangedPassWord_Click);
            // 
            // mnSignupAccount
            // 
            this.mnSignupAccount.Image = ((System.Drawing.Image)(resources.GetObject("mnSignupAccount.Image")));
            this.mnSignupAccount.Name = "mnSignupAccount";
            this.mnSignupAccount.Size = new System.Drawing.Size(218, 26);
            this.mnSignupAccount.Text = "Resgist User";
            this.mnSignupAccount.Click += new System.EventHandler(this.mnSignupAccount_Click_1);
            // 
            // mnUserList
            // 
            this.mnUserList.Image = ((System.Drawing.Image)(resources.GetObject("mnUserList.Image")));
            this.mnUserList.Name = "mnUserList";
            this.mnUserList.Size = new System.Drawing.Size(218, 26);
            this.mnUserList.Text = "Manage User";
            this.mnUserList.Click += new System.EventHandler(this.mnUserList_Click);
            // 
            // rollGiftToolStripMenuItem
            // 
            this.rollGiftToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rollGiftToolStripMenuItem.Image")));
            this.rollGiftToolStripMenuItem.Name = "rollGiftToolStripMenuItem";
            this.rollGiftToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.rollGiftToolStripMenuItem.Text = "Roll Gift";
            this.rollGiftToolStripMenuItem.Click += new System.EventHandler(this.rollGiftToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblInFo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 397);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(741, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslblInFo
            // 
            this.tsslblInFo.Image = ((System.Drawing.Image)(resources.GetObject("tsslblInFo.Image")));
            this.tsslblInFo.Name = "tsslblInFo";
            this.tsslblInFo.Size = new System.Drawing.Size(38, 20);
            this.tsslblInFo.Text = "...";
            // 
            // f_Main
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(741, 423);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(50, 50);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "f_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Aplication";
            this.TopMost = true;
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
        private System.Windows.Forms.ToolStripMenuItem rollGiftToolStripMenuItem;
    }
}