using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WindowFrom.Data
{
    public class GiaiThuongDAO
    {
        public List<Giaithuong> giaiThuongs;
        public GiaiThuongDAO()
        {
            giaiThuongs = new List<Giaithuong>();

        }

        public void DocFileDanhSachGiaiThuong(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = string.Empty;
                    Giaithuong giaiThuong;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] vs = line.Split(',');
                            giaiThuong = new Giaithuong()
                            {
                                ID = Convert.ToInt32(vs[0]),
                                TenGiai = vs[1]

                            };

                            giaiThuongs.Add(giaiThuong);

                        }
                    }
                }
            }
        }


    }
}
