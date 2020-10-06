using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using System.IO;
using System.Text;
using System.Text.Json;
using Newtonsoft.Json;

namespace WpfAppCloudService.Controllers
{
    public class WeatherController : ApiController
    {
        // GET: api/Weather
        public string Get()
        {
            string teststring;

            using (var client = new HttpClient())
            {
                double lat = 56.859625;
                double lon = 35.911851;
                string lang = "ru_RU";
                int limit = 2;
                bool hours = false;
                bool extra = false;
                string apiValue = "8f45aa9d-04a5-4af7-a9d1-e9fb8dc7df3e";
                string apiKey = $"X-Yandex-API-Key";
                NameValueCollection apiKeyNVCol = new NameValueCollection();
                apiKeyNVCol.Add(apiKey, apiValue);


                string responsePath = "https://api.weather.yandex.ru/v2/forecast?" + $"lat={lat}&lon={lon}&lang={lang}&limit={limit}&hours={hours.ToString()}&extra={extra.ToString()}";

                

                //var response = client.GetAsync().;
                HttpWebRequest httpWebRequest = HttpWebRequest.CreateHttp(responsePath);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = "application/json";
                //httpWebRequest.Headers.Add(apiKeyNVCol);
                httpWebRequest.Headers.Add(apiKey, apiValue);
                
                

                Task<WebResponse> response = httpWebRequest.GetResponseAsync();
                string test = response.Result.ContentType;
                var test2 = response.Result.GetResponseStream();
                FileStream fs = (FileStream)test2;
                fs.
                
                return test2;
            }
            
        }




    }
}
