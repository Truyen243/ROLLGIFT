using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Data
{
    class Diem
    {
        public int id;
        public string masv;
        public string mamonhoc;
        public float diem10;
        public float diem30;
        public float diem60;
        public float diemtong;
        public Diem() { }
        public Diem(int id, string masv, string mamonhoc, float diem10, float diem30, float diem60, float diemtong)
        {
            this.Id = id;
            this.Masv = masv;
            this.Mamonhoc = mamonhoc;
            this.Diem10 = diem10;
            this.Diem30 = diem30;
            this.Diem60 = diem60;
            this.Diemtong = diemtong;


        }
        public int Id { get => id; set => id = value; }
        public string Masv { get => masv; set => masv = value; }
        public string Mamonhoc { get => mamonhoc; set => mamonhoc = value; }
        public float Diem10 { get => diem10; set => diem10 = value; }
        public float Diem30 { get => diem30; set => diem30 = value; }
        public float Diem60 { get => diem60; set => diem60 = value; }
        public float Diemtong { get => diemtong; set => diemtong = value; }

    }
}
