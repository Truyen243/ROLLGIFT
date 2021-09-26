using System;
using System.Collections.Generic;
using System.IO;

namespace WindowFrom.Data
{
    public class UserDAO
    {
        //public User user;
        public List<User> listUser= new List<User>();


        //Phương thức ghi danh sách listUser vào file text theo đường dẫn file path
        public void WriteUser(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (User item in listUser)
                    {
                        sw.WriteLine(string.Format("{0},{1},{2},{3},{4}", item.ID, item.UserName, item.PassWord,item.Remember.ToString(), item.IdUserType));
                    }
                }
            }
        }

        // Phương thức đọc danh sách listUser từ file text
        public void GetUser(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = string.Empty;
                    User user;
                    while ((line = sr.ReadLine()) != null)
                    {
                        //Kiểm tra xem line có giá trị hay không
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] userArray = line.Split(',');

                            user = new User();
                            user.ID = Convert.ToInt32(userArray[0]);
                            user.UserName = userArray[1];
                            user.PassWord = userArray[2];
                            //user.FullName = userArray[3];
                            user.Remember = Convert.ToBoolean(userArray[3].ToString());
                            user.IdUserType = Convert.ToInt32(userArray[4]);

                            //Thêm User vào danh sách listUser
                            listUser.Add(user);
                        }
                    }
                    
                }
            }
        }
    }
}
