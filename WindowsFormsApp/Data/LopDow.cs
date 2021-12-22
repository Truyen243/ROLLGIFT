using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp.Data
{
    class LopDow
    {
        public List<Lop> lstlop = new List<Lop>();
        public bool getLop()
        {

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
                    Lop k = new Lop(a,d, b, c);
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
    }
}
