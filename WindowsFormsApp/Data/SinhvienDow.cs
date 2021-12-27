using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Net;

using Newtonsoft.Json;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp.Data
{
    class SinhvienDow
    {
        public bool updateSv(int Id,String Name, String Email, String Address, String Date, String Phone, String Sex, int Lop_id)
        {

            String link = "https://qlsv.phamthanhnam.com/sv/edit";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(link);

            httpWebRequest.Headers.Add("Authorization", "Bearer " + Cls_Main.adminStc.token);

            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";


            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    id = Id,
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

        }
        public bool addSv(String Name, String Email, String Address, String Date,String Phone, String Sex, int Lop_id)
        {
            
            String link = "http://qlsv.phamthanhnam.com/sv/create";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(link);

            httpWebRequest.Headers.Add("Authorization", "Bearer "+ Cls_Main.adminStc.token);

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
            
        }
        public SinhVien timsinhVien(String msvien)
        {
            
            String link = "https://qlsv.phamthanhnam.com/sv/search/"+ msvien;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(link);

            httpWebRequest.Headers.Add("Authorization", "Bearer " + Cls_Main.adminStc.token);

            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";


            

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {

                var result = streamReader.ReadToEnd();
                Console.WriteLine(result);
                dynamic stuff = JsonConvert.DeserializeObject(result);
                JObject[] sv1 = stuff.data.ToObject<JObject[]>();
                if(sv1 == null)
                {
                    return null;
                }
                SinhVien svs = new SinhVien();
                foreach (JObject sv in sv1)
                {
                    int id = (int)sv["id"];
                    string name = (string)sv["name"];
                    string mssv = (string)sv["uid"];
                    string email = (string)sv["email"];
                    string address = (string)sv["address"];
                    string date  = (string)sv["date"];

                    string sex = (string)sv["sex"];
                    string phone = (string)sv["phone"];
                    dynamic stuff2 = sv["sinhviens"];
                    string mslop = (string)stuff2.malop;               
                    dynamic stuff3 = stuff2.lops;
                    string mskhoa = (string)stuff3.makhoa;
                    svs = new SinhVien(id, name, phone, mssv, email, date, address, mslop, mskhoa,sex);
                    //public SinhVien(int id, string name, string phone, string mssv, string email, string ngaysinh, string adress, string mslop, string mskhoa, string gioitinh)
                    
                }    
                if (stuff.status != "success")
                {

                    return null;
                }
                else
                {
                    
                    return svs;
                }
            }

        }
        public void xoasinhVien(int id)
        {

            String link = "https://qlsv.phamthanhnam.com/sv/delete/" + Convert.ToString(id);
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(link);

            httpWebRequest.Headers.Add("Authorization", "Bearer " + Cls_Main.adminStc.token);

            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "DELETE";
            Console.WriteLine("Xóa");



            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {

                var result = streamReader.ReadToEnd();
                Console.WriteLine(result);
                
            }

        }
    }
}
