using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Data
{
    class Khoa
    {
        public string id;
        public string ten;
        public string makhoa;
        public Khoa() { }
        public Khoa(string id, string ten, string makhoa)
        {
            this.Id = id;
            this.Ten = ten;
            this.MaKhoa = makhoa;
        }
        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string MaKhoa { get => makhoa; set => makhoa = value; }
    }
}
