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
        public string tenmon;
        public int masv;
        public int mamonhoc;
        
        public float diem10;
        public float diem30;
        public float diem60;
        public float diemtong;
        public Diem() { }
        public Diem(int id, string tenmon, int masv, int mamonhoc, float diem10, float diem30, float diem60, float diemtong)
        {
            this.Id = id;
            this.Tenmon = tenmon;
            this.Masv = masv;
            this.Mamonhoc = mamonhoc;
            this.Diem10 = diem10;
            this.Diem30 = diem30;
            this.Diem60 = diem60;
            this.Diemtong = diemtong;


        }
        public int Id { get => id; set => id = value; }
        public string Tenmon { get => tenmon; set => tenmon = value; }
        public int Masv { get => masv; set => masv = value; }
        
        public int Mamonhoc { get => mamonhoc; set => mamonhoc = value; }
        public float Diem10 { get => diem10; set => diem10 = value; }
        public float Diem30 { get => diem30; set => diem30 = value; }
        public float Diem60 { get => diem60; set => diem60 = value; }
        public float Diemtong { get => diemtong; set => diemtong = value; }

    }
}
