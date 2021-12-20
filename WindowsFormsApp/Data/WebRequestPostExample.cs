using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
namespace WindowsFormsApp.Data
{
    class WebRequestPostExample
    {
       
        public void Request()
        {

            // Create a request for the URL.
            WebRequest request = WebRequest.Create(
              "https://api.phamthanhnam.com/api/users");
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;

            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            // Get the stream containing content returned by the server.
            // The using block ensures the stream is automatically closed.
            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
     
                dynamic stuff = JsonConvert.DeserializeObject(responseFromServer);
                Console.WriteLine(stuff);
                
               // Console.WriteLine(stuff.data.GetType());
                

            }

            // Close the response.
            
        }
        public void post()
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.phamthanhnam.com/api/user");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"email\":\"truyenlol@gmail.com\"," +
                                "\"password\":\"A@123456789\"}";

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                
                var result = streamReader.ReadToEnd();
                Console.WriteLine(result);
            }
        }
        public void delete(string uuid)
        {
            
        } 
        public void deleteAll()
        {

        }    
    }
}
