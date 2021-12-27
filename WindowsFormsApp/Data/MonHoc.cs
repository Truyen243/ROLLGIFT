using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Data
{
    class MonHoc
    {
        public int id;
        public string mamonhoc;
        public string ten;
        public int sotiet;
        public int heso;
        public MonHoc() { }
        public MonHoc(int id, string mamonhoc, string ten, int sotiet, int heso)
        {
            this.Id = id;
            this.Mamonhoc = mamonhoc;
            this.Ten = ten;
            this.Sotiet = sotiet;
            this.Heso = heso;

        }
        public int Id { get => id; set => id = value; }
        public string Mamonhoc { get => mamonhoc; set => mamonhoc = value; }
        public string Ten { get => ten; set => ten = value; }

        public int Sotiet { get => sotiet; set => sotiet = value; }
        public int Heso { get => heso; set => heso = value; }

    }
}
