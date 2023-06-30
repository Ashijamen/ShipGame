using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShipGame
{
    class RequestSender
    {
        public static async Task<ServiceResponse> Get(string path, string queryString)
        {
            ServiceResponse response = new ServiceResponse();

            var builder = new UriBuilder("http://localhost:5001" + path + queryString);

            var client = new HttpClient(); 
            var responseTask = await client.GetAsync(builder.Uri);
            response.ResponseJson = await responseTask.Content.ReadAsStringAsync();
            response.StausCode = (int)responseTask.StatusCode;

            // Return the content from the Main method
            return response;
        }

        public static async Task<ServiceResponse> Post(string path, string content)
        {
            ServiceResponse response = new ServiceResponse();
            var client = new HttpClient();
            var uri = new Uri("http://localhost:5001" + path);
            var requestBody = new StringContent(content, Encoding.UTF8, "application/json");
            var responseTask = await client.PostAsync(uri, requestBody);
            Console.WriteLine($"Status code: {(int)responseTask.StatusCode} {responseTask.StatusCode}");
            response.ResponseJson = await responseTask.Content.ReadAsStringAsync();
            response.StausCode = (int)responseTask.StatusCode;
            return response;
        }

        public static async Task<ServiceResponse> Put(string path, string content)
        {
            ServiceResponse response = new ServiceResponse();
            var client = new HttpClient();
            var uri = new Uri("http://localhost:5001" + path);
            var requestBody = new StringContent(content, Encoding.UTF8, "application/json");
            var responseTask = await client.PutAsync(uri, requestBody);
            Console.WriteLine($"Status code: {(int)responseTask.StatusCode} {responseTask.StatusCode}");
            response.ResponseJson = await responseTask.Content.ReadAsStringAsync();
            response.StausCode = (int)responseTask.StatusCode;
            return response;
        }
    }
}
