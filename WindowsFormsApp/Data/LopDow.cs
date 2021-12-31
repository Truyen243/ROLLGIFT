using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;

namespace WindowsFormsApp.Data
{
    class LopDow
    {
        public List<Lop> lstlop = new List<Lop>();
        public string getTenLop(int idlop)
        {
            foreach (Lop lop in Cls_Main.lopDowStc.lstlop)
            {

                if (lop.id == idlop)
                {
                    return lop.ten;
                }
            }
            return "";
        }
        public int getidlop(string tenlop)
        {
            foreach (Lop lop in Cls_Main.lopDowStc.lstlop)
            {

                if (lop.ten == tenlop)
                {
                    return lop.id;
                }
            }
            return 0;
        }
        public bool getLop()
        {
            this.lstlop.Clear();
            String link = "https://qlsv.phamthanhnam.com/lop/get/all";
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

                JObject[] Lops = stuff.data.ToObject<JObject[]>();
                foreach (JObject lop in Lops)
                {
                    int a = (int)lop["id"];
                    String b = (string)lop["ten"];
                    String c = (string)lop["khoa_id"];
                    String d = (string)lop["malop"];
                    Lop k = new Lop(a, d, b, c);
                    this.lstlop.Add(k);
                }
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
        public List<SinhVien> getSv(string id)
        {
            List<SinhVien> lstsv = new List<SinhVien>();

            String link = "https://qlsv.phamthanhnam.com/lop/sv/" + id;
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

                JObject[] Svs = stuff.data.sinhviens.ToObject<JObject[]>();
                foreach (JObject sv in Svs)
                {
                    string j = "";
                    foreach (Lop lp in Cls_Main.lopDowStc.lstlop)
                    {
                        if (lp.id == Int32.Parse(id))
                        {
                            j = lp.khoa_id;
                        }
                    }
                    int a = (int)sv["id"];
                    String b = (string)sv["name"];
                    String c = (string)sv["uid"];
                    String d = (string)sv["email"];
                    String e = (string)sv["address"];
                    String f = (string)sv["lop_id"];
                    String g = (string)sv["date"];
                    String h = (string)sv["phone"];
                    String i = (string)sv["sex"];
                    SinhVien k = new SinhVien(a, b, h, c, d, g, e, f, j, i);
                    lstsv.Add(k);

                }
                if (stuff.status == "success")
                {
                    return lstsv;
                }
                else
                {
                    return null;
                }
            }

        }
        public bool addLop(String ten, int khoa_id, String malop)
        {

            String link = "https://qlsv.phamthanhnam.com/lop/create";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(link);

            httpWebRequest.Headers.Add("Authorization", "Bearer " + Cls_Main.adminStc.token);

            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";


            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    ten = ten,
                    khoa_id = khoa_id,
                    malop = malop

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
        public bool editLop(int id, String ten, int khoa_id, String malop)
        {

            String link = "https://qlsv.phamthanhnam.com/lop/edit";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(link);

            httpWebRequest.Headers.Add("Authorization", "Bearer " + Cls_Main.adminStc.token);

            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";


            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {   
                    id=id,
                    ten = ten,
                    khoa_id = khoa_id,
                    malop = malop

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
