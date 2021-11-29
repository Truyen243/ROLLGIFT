
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
            this.mnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnChangedPassWord = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUserList = new System.Windows.Forms.ToolStripMenuItem();
            this.rollGiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tsslblInFo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 20, 0, 2);
            this.menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            resources.ApplyResources(this.menuStrip2, "menuStrip2");
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.mnFile,
            this.rollGiftToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip2.MdiWindowListItem = this.mnFile;
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            resources.ApplyResources(this.thôngTinCáNhânToolStripMenuItem, "thôngTinCáNhânToolStripMenuItem");
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            // 
            // mnFile
            // 
            this.mnFile.AutoToolTip = true;
            this.mnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnChangedPassWord,
            this.mnUserList});
            resources.ApplyResources(this.mnFile, "mnFile");
            this.mnFile.Name = "mnFile";
            this.mnFile.Click += new System.EventHandler(this.mnFile_Click);
            // 
            // mnChangedPassWord
            // 
            resources.ApplyResources(this.mnChangedPassWord, "mnChangedPassWord");
            this.mnChangedPassWord.Name = "mnChangedPassWord";
            this.mnChangedPassWord.Click += new System.EventHandler(this.mnChangedPassWord_Click);
            // 
            // mnUserList
            // 
            resources.ApplyResources(this.mnUserList, "mnUserList");
            this.mnUserList.Name = "mnUserList";
            this.mnUserList.Click += new System.EventHandler(this.mnUserList_Click);
            // 
            // rollGiftToolStripMenuItem
            // 
            resources.ApplyResources(this.rollGiftToolStripMenuItem, "rollGiftToolStripMenuItem");
            this.rollGiftToolStripMenuItem.Name = "rollGiftToolStripMenuItem";
            this.rollGiftToolStripMenuItem.Click += new System.EventHandler(this.rollGiftToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.logOutToolStripMenuItem, "logOutToolStripMenuItem");
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // tsslblInFo
            // 
            resources.ApplyResources(this.tsslblInFo, "tsslblInFo");
            this.tsslblInFo.Name = "tsslblInFo";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblInFo});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // f_Main
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.Name = "f_Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
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
        private System.Windows.Forms.ToolStripMenuItem mnFile;
        private System.Windows.Forms.ToolStripMenuItem mnChangedPassWord;
        private System.Windows.Forms.ToolStripMenuItem mnUserList;
        private System.Windows.Forms.ToolStripMenuItem rollGiftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslblInFo;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}