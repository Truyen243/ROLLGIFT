
namespace WindowFrom
{
    partial class f_ChangedPassWord
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
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbAdmin = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRestPassword = new System.Windows.Forms.Button();
            this.grpUser = new System.Windows.Forms.GroupBox();
            this.btnChangedPassword = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPasswordNewTow = new System.Windows.Forms.TextBox();
            this.txbPasswordNewOne = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.grbAdmin.SuspendLayout();
            this.grpUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboUser
            // 
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Location = new System.Drawing.Point(182, 36);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(224, 27);
            this.cboUser.TabIndex = 0;
            this.cboUser.SelectedIndexChanged += new System.EventHandler(this.cboUser_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài khoản:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grbAdmin
            // 
            this.grbAdmin.Controls.Add(this.label4);
            this.grbAdmin.Controls.Add(this.btnRestPassword);
            this.grbAdmin.Controls.Add(this.cboUser);
            this.grbAdmin.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAdmin.Location = new System.Drawing.Point(24, 59);
            this.grbAdmin.Name = "grbAdmin";
            this.grbAdmin.Size = new System.Drawing.Size(432, 132);
            this.grbAdmin.TabIndex = 2;
            this.grbAdmin.TabStop = false;
            this.grbAdmin.Text = "Đặt lại mật khẩu";
            this.grbAdmin.Enter += new System.EventHandler(this.grbAdmin_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chọn tài khoản";
            // 
            // btnRestPassword
            // 
            this.btnRestPassword.Location = new System.Drawing.Point(281, 69);
            this.btnRestPassword.Name = "btnRestPassword";
            this.btnRestPassword.Size = new System.Drawing.Size(115, 42);
            this.btnRestPassword.TabIndex = 1;
            this.btnRestPassword.Text = "Cập nhập";
            this.btnRestPassword.UseVisualStyleBackColor = true;
            this.btnRestPassword.Click += new System.EventHandler(this.btnRestPassword_Click);
            // 
            // grpUser
            // 
            this.grpUser.Controls.Add(this.btnChangedPassword);
            this.grpUser.Controls.Add(this.label3);
            this.grpUser.Controls.Add(this.label2);
            this.grpUser.Controls.Add(this.txbPasswordNewTow);
            this.grpUser.Controls.Add(this.txbPasswordNewOne);
            this.grpUser.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUser.Location = new System.Drawing.Point(24, 197);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(432, 160);
            this.grpUser.TabIndex = 3;
            this.grpUser.TabStop = false;
            this.grpUser.Text = "Thay đổi mật khẩu";
            // 
            // btnChangedPassword
            // 
            this.btnChangedPassword.Location = new System.Drawing.Point(281, 105);
            this.btnChangedPassword.Name = "btnChangedPassword";
            this.btnChangedPassword.Size = new System.Drawing.Size(115, 42);
            this.btnChangedPassword.TabIndex = 4;
            this.btnChangedPassword.Text = "Lưu";
            this.btnChangedPassword.UseVisualStyleBackColor = true;
            this.btnChangedPassword.Click += new System.EventHandler(this.btnChangedPassword_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Xác nhận mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu mới";
            // 
            // txbPasswordNewTow
            // 
            this.txbPasswordNewTow.Location = new System.Drawing.Point(198, 72);
            this.txbPasswordNewTow.Name = "txbPasswordNewTow";
            this.txbPasswordNewTow.Size = new System.Drawing.Size(208, 27);
            this.txbPasswordNewTow.TabIndex = 1;
            // 
            // txbPasswordNewOne
            // 
            this.txbPasswordNewOne.Location = new System.Drawing.Point(198, 32);
            this.txbPasswordNewOne.Name = "txbPasswordNewOne";
            this.txbPasswordNewOne.Size = new System.Drawing.Size(208, 27);
            this.txbPasswordNewOne.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(118, 15);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserName.Size = new System.Drawing.Size(302, 26);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "N/A";
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // f_ChangedPassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 402);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.grpUser);
            this.Controls.Add(this.grbAdmin);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "f_ChangedPassWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "f_ChangedPassWord";
            this.Load += new System.EventHandler(this.f_ChangedPassWord_Load);
            this.grbAdmin.ResumeLayout(false);
            this.grbAdmin.PerformLayout();
            this.grpUser.ResumeLayout(false);
            this.grpUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbAdmin;
        private System.Windows.Forms.Button btnRestPassword;
        private System.Windows.Forms.GroupBox grpUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPasswordNewTow;
        private System.Windows.Forms.TextBox txbPasswordNewOne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChangedPassword;
        private System.Windows.Forms.Label lblUserName;
    }
}