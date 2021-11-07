using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowFrom.Data;
using LibraryClass.DatabaseType;
namespace WindowFrom
{
    public class Cls_Main
    {
        //Biến lưu User khi đăng nhập thành công
        public static User _staticUser = new User();
        //Đối tượng danh sách User, danh sách này được khởi tạo khi mở chương trình. Giá trị được đọc từ file text
        public static List<User> _listUser = new UserDAO().listUser;
        //Biến lưu đường dẫn file text
        public static string pathfile = string.Format(@"{0}\listUser.ini", Application.StartupPath);
        public static string pathRem = string.Format(@"{0}\rem.ini", Application.StartupPath);
        public static string pathGiaiThuong = Application.StartupPath + @"\Giai.ini";
        public static string pathNhanVienNhanGiai = Application.StartupPath + @"\NhanVienNhanGiai.ini";
        public static string pathNhanVienNhanGiaiExcel = Application.StartupPath + @"\NhanVienNhanGiai.xls";
        public static string pathNhanVien = Application.StartupPath + @"\NhanVien1.xls";

        public static TypeDatabase typeDatabase = TypeDatabase.INI;

    }
}
