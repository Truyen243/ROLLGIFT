using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Data
{
    class Lop
    {
        public int id;
        public string ten;
        public string malop;
        public string khoa_id;
        public Lop() { }
        public Lop(int id, string malop, string ten,  string khoa_id)
        {
            this.Id = id;
            this.Malop = malop;
            this.Ten= ten;
            this.Khoa_id = khoa_id;
        }
        public int Id { get => id; set => id = value; }
        public string Malop { get => malop; set => malop = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Khoa_id { get => khoa_id; set => khoa_id = value; }

    }
}
