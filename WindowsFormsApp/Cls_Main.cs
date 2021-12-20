using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp.Data;
namespace WindowsFormsApp
{
    class Cls_Main
    {
        public static Admin adminStc = new Admin();
        public static AdminDow adStc = new AdminDow();
        public static string pathRem = string.Format(@"{0}\rem.ini", Application.StartupPath);
    }
}
