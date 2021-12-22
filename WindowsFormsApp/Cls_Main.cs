using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp.Data;
namespace WindowsFormsApp
{
    class Cls_Main
    {
        // Xử lí admin
        public static Admin adminStc = new Admin();
        public static AdminDow adStc = new AdminDow();
        // Xử lí Khoa
        public static khoadow khoaDowStc = new khoadow();
        // Xử lí Lớp
        public static LopDow lopDowStc = new LopDow();
        // file chứa mật khẩu đã lưu
        public static string pathRem = string.Format(@"{0}\rem.ini", Application.StartupPath);
        public static SinhvienDow svDow = new SinhvienDow();

    }
}
