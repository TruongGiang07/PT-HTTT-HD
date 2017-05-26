using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.UI.Common
{
    public class ServiceConnector
    {
        public static List<T> GetDataFromServiceByPost<T>(string uri, object postValue, bool isJavaService) where T : class
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(isJavaService ? AppConfigs.JavaBaseServiceUri : AppConfigs.NetBaseServiceUri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.PostAsJsonAsync(uri, postValue).Result;
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string responseString = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<List<T>>(responseString);
                }
                return new List<T>();
            }
        }

        public static List<T> GetDataFromServiceByGet<T>(string uri, bool isJavaService) where T : class
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(isJavaService ? AppConfigs.JavaBaseServiceUri : AppConfigs.NetBaseServiceUri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync(uri).Result;
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string responseString = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<List<T>>(responseString);
                }
                return new List<T>();
            }
        }

        public static bool InsertOrUpdate<T>(string uri, T postValue, bool isJavaService) where T : class
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(isJavaService ? AppConfigs.JavaBaseServiceUri : AppConfigs.NetBaseServiceUri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.PostAsJsonAsync(uri, postValue).Result;
                return response.StatusCode == System.Net.HttpStatusCode.Created;
            }
        }
    }
}
