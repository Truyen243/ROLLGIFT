using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowFrom.Data;
using WindowsFormsQuaySo;

namespace f_quaysomayman
{
    public class NhanVienDAO
    {
        public List<Nhanvien> nhanviens;
        public NhanVienDAO()
        {
            nhanviens = new List<Nhanvien>();
        }
        public void DocFileDanhSach(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                    }
            string line =string .Empty;
            Nhanvien nhanviens;
            while ((line=sr.ReadLine() )!= null)
                    {
                if (string.IsNullOrEmpty(line))
                {
                    string[] vs = line.Split(',');
                    Nhanvien = new Nhanvien()
                    {
                        ID = Convert.ToInt32(vs[0]),
                        HoTen = vs[1],
                        PhongBan = vs[2]
                    };
                    nhanviens.Add(nhanvien);
                }    
            }
        }
    }
}

