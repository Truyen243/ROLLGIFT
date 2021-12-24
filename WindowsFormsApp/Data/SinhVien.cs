using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Data
{
    class SinhVien
    {
        public int id;
        public string name;
        public string phone;
        public string mssv;
        public string email;
        public string ngaysinh;
        public string adress;
        public string mslop;
        public string mskhoa;
        public string gioitinh;
        
        public SinhVien() { }

        public SinhVien(int id, string name, string phone, string mssv, string email, string ngaysinh, string adress, string mslop, string mskhoa, string gioitinh)
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;
            this.Mssv = mssv;
            this.Email = email;
            this.Ngaysinh = ngaysinh;
            this.Adress = adress;
            this.Mslop = mslop;
            this.Gioitinh = gioitinh;
            this.Mskhoa = mskhoa;

        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Mssv { get => mssv; set => mssv = value; }
        public string Email { get => email; set => email = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Adress { get => adress; set => adress = value; }
        public string Mslop { get => mslop; set => mslop = value; }
        public string Mskhoa { get => mskhoa; set => mskhoa = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }

        public string GetString()
        {
            return string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", id, name, phone, mssv, email, ngaysinh, adress, mslop,mskhoa, gioitinh);
        }

    }
}
