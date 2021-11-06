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
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (User item in listUser)
                    {
                        sw.WriteLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", item.ID,item.FullName, item.Sex.ToString(), item.UserName, item.PassWord,item.Remember.ToString(), item.IdUserType,item.PhongBan));
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
                    listUser.Clear();
                    while ((line = sr.ReadLine()) != null)
                    {
                        //Kiểm tra xem line có giá trị hay không
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] userArray = line.Split(',');

                            user = new User();
                            user.ID = Convert.ToInt32(userArray[0]);
                            user.FullName = userArray[1];
                            user.Sex = Convert.ToBoolean(userArray[2].ToString());
                            user.UserName = userArray[3];
                            user.PassWord = userArray[4];
                            user.Remember = Convert.ToBoolean(userArray[5].ToString());
                            user.IdUserType = Convert.ToInt32(userArray[6]);
                            user.PhongBan = userArray[7];
                            //Thêm User vào danh sách listUser
                            listUser.Add(user);
                        }
                    }
                    
                }
            }
        }

        //Lấy MaxID của listUser
        public int GetMaxID()
        {
            int maxID = 0;
            foreach (User item in listUser)
            {
                if (item.ID > maxID)
                {
                    maxID = item.ID;

                }
            }
            return maxID + 1;
        }
    }
}
