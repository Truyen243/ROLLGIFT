﻿using System;
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
    class DiemDow
    {
        public void xoaDiem(int id)
        {

            String link = "https://qlsv.phamthanhnam.com/diem/delete/" + Convert.ToString(id);
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(link);

            httpWebRequest.Headers.Add("Authorization", "Bearer " + Cls_Main.adminStc.token);

            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "DELETE";
            Console.WriteLine("Đã Xóa");



            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {

                var result = streamReader.ReadToEnd();
                Console.WriteLine(result);

            }

        }
        public bool suadiem(int id, float d10, float d30, float d60, float dtong)
        {
            String link = "https://qlsv.phamthanhnam.com/diem/edit/" + id.ToString();
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(link);

            httpWebRequest.Headers.Add("Authorization", "Bearer " + Cls_Main.adminStc.token);

            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";


            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    diem10 = d10,
                    diem30 = d30,
                    diem60 = d60,
                    diemtong = dtong

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
       
        public List<Diem> laydiem(int msvien)
        {
       
            List<Diem> lstDiem = new List<Diem>();

            String link = "https://qlsv.phamthanhnam.com/sv/diem/" + Convert.ToString(msvien);
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
                if (stuff.status != "success")
                {

                    return null;
                }
                JObject[] diem = stuff.data.diemsv.ToObject<JObject[]>();

                Diem dm = new Diem();
                
                foreach (JObject d in diem)
                {
                    int id = (int)d["id"];
                    int mamh =(int) d["mh_id"];
                    int masv = (int)msvien;
                    float diem10 = (float)d["diem10"];
                    float diem30 = (float)d["diem30"];
                    float diem60 = (float)d["diem60"];
                    float diemtong = (float)d["diemtong"];
                    string tenmon = Cls_Main.monDow.getTen(mamh);
                    dm = new Diem(id, tenmon, masv, mamh, diem10, diem30, diem60, diemtong);
                    Console.WriteLine(tenmon);
                    lstDiem.Add(dm);
                    
                }
                Console.WriteLine(lstDiem.Count);
               
                if (stuff.status != "success")
                {

                    return null;
                }
                else
                {

                    return lstDiem;
                }
            }

        }
        public bool add(Diem diem)
        {
            String link = "https://qlsv.phamthanhnam.com/diem/create";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(link);

            httpWebRequest.Headers.Add("Authorization", "Bearer " + Cls_Main.adminStc.token);

            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    sv_id = diem.masv,
                    mh_id = diem.mamonhoc,
                    diem10 = diem.diem10,
                    diem30 = diem.diem30,
                    diem60 = diem.diem60,
                    diemtong = diem.diemtong

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
