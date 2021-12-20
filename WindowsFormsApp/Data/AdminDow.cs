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
        List<Admin> lstAdmin;

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
                if (stuff.status == "error")
                {
                    return false;
                }    
                    
                else
                {
                    return true;
                }    
            }
            return false;

        }
        public void add(string name, string email, string password)
        {

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://qlsv.phamthanhnam.com/admin/create");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    name = "Foo",
                    email = "truyenlol714@gmail.com",
                    password = "Aa@12345678"
                });

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {

                var result = streamReader.ReadToEnd();
                Console.WriteLine(result);
            }
        } 
    }
}
