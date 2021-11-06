using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowFrom.Data
{
    public class NhanVienNhanGiai : IComparable
    {
        public int sTT = 0;
        public int iD;
        public string hoTen;
        public string phongBan;
        public string giai;

        public int ID { get => iD; set => iD = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string PhongBan { get => phongBan; set => phongBan = value; }
        public int STT { get => sTT; set => sTT = value; }
        public string Giai { get => giai; set => giai = value; }
        public NhanVienNhanGiai(int iD, string hoTen, string phongBan, string giai)
        {
            this.ID = iD;
            this.HoTen = hoTen;
            this.PhongBan = phongBan;
            this.Giai = giai;
        }
        public NhanVienNhanGiai()
        {

        }
        public int CompareTo(object obj)
        {
            return this.Giai.CompareTo(((NhanVienNhanGiai)obj).Giai);
        }
    }
}
