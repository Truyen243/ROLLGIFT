using System;

namespace WindowFrom.Data
{
    public class User
    {
        private int iD;
        private string userName;
        private string passWord;
        //private string fullName;
        private bool remember;
        private int idUserType;

        //Contructor - hàm tạo cho đối tượng User
        public User() { }

        public User(int iD, string userName, string passWord, bool remember, int idUserType)
        {
            this.ID = iD;
            this.UserName = userName;
            this.PassWord = passWord;
            //this.FullName = fullName;
            this.Remember = remember;
            this.IdUserType = idUserType;

        }

        public int ID { get => iD; set => iD = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        //public string FullName { get => fullName; set => fullName = value; }
        public bool Remember { get => remember; set => remember = value; }
        public int IdUserType { get => idUserType; set => idUserType = value; }

        public string GetString()
        {
            return string.Format("{0},{1},{2},{3},{4}", ID, UserName, PassWord, Remember.ToString(), IdUserType);
        }
    }
}
