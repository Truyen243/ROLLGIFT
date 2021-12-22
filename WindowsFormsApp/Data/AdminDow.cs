using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace WindowsFormsApp.Data
{
    class AdminDow
    {


        public bool login(string Email, string Password)
        {
            
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://qlsv.phamthanhnam.com/admin/login");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    email = Email,
                    password = Password
                });

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                Console.WriteLine(result);
                dynamic stuff = JsonConvert.DeserializeObject(result);
                if (stuff.status != "success")
                {
                    return false;
                }    
                    
                else
                {
                    return true;
                }    
            }
           

        }

        public bool getAdmin(string Email, string Password)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://qlsv.phamthanhnam.com/admin/login");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    email = Email,
                    password = Password
                });

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                Console.WriteLine(result);
                dynamic stuff = JsonConvert.DeserializeObject(result);
               


                if (stuff.status != "success")
                {
                    return false;
                }

                else
                {

                    dynamic b = stuff.data;
                    int id = b.id;
                    String name = b.name;
                    String email = b.email;
                    String token = stuff.token;
                   
                    String password = Password;
                    Cls_Main.adminStc = new Admin(id, name, token, email, password);
                    Console.WriteLine(Cls_Main.adminStc.GetString());
                    return true;
                }
            }
        }    
        public bool add(string Name, string Email, string Password)
        {

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://qlsv.phamthanhnam.com/admin/create");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    name = Name,
                    email = Email,
                    password = Password
                });

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {

                var result = streamReader.ReadToEnd();
                Console.WriteLine(result);
                dynamic stuff = JsonConvert.DeserializeObject(result);
                if(stuff.status == "success")
                {
                    return true;
                }    
                else
                {
                    return false;
                }    
            }
        }
        public bool changePassWord(string Newpassword, string Password)
        {

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://qlsv.phamthanhnam.com/admin/forgot/1");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    newpassword = Newpassword,
                    password = Password
                });

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {

                var result = streamReader.ReadToEnd();
                Console.WriteLine(result);
                dynamic stuff = JsonConvert.DeserializeObject(result);
                if (stuff.status == "success")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
