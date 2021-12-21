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
        private string token;
        public string passWord;
        private string email;
        public Admin() { }
        public Admin(int id, string fullName, string token,string email, string passWord)
        {
            this.Id = id;
            this.FullName = fullName;
            this.Token = token;
            this.PassWord = passWord;
            this.Email = email;
        }
        public int Id { get => id; set => id = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Token { get => token; set => token = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string Email { get => email; set => email = value; }

        public string GetString()
        {
            return string.Format("{0},{1},{2},{3},{4}", Id, FullName, Token,email, PassWord);
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
