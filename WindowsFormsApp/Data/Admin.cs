using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Data
{
    class Admin
    {
        private int id;
        private string fullName;
        private string adminName;
        private string passWord;
        private int remember;
        public Admin() { }
        public Admin(int id, string fullName, string adminName, string passWord, int remember)
        {
            this.Id = id;
            this.FullName = fullName;
            this.AdminName = adminName;
            this.PassWord = passWord;
            this.Remember = remember;
        }
        public int Id { get => id; set => id = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string AdminName { get => adminName; set => adminName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public int Remember { get => remember; set => remember = value; }

        public string GetString()
        {
            return string.Format("{0},{1},{2},{3},{4}", Id, FullName, AdminName, PassWord, Remember);
        }
        public override int GetHashCode() { return 0; }
        public override bool Equals(object obj)
        {
            if (obj is Admin)
            {
                return this.id.Equals(((Admin)obj).Id);
            }
            return false;

        }

        public int CompareTo(object obj)
        {
            if (obj is Admin)
            {
                return this.id.CompareTo(((Admin)obj).Id);
            }
            return -1;
        }
    }
    

}
