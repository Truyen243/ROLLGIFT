using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using System.IO;
using System.Net;
namespace WindowsFormsApp.Data
{
    class SinhvienDow
    {
        public bool addSv(String Name, String Email, String Address, String Date,String Phone, String Sex, String Lop_id)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://qlsv.phamthanhnam.com/sv/create");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    name = Name,
                    email = Email,
                    address = Address,
                    date = Date,
                    phone = Phone, 
                    sex = Sex,
                    lop_id = Lop_id
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
            return false;
        }    
    }
}
