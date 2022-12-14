using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeStore.Tests
{
    public class BaseApi
    {
        private readonly string ApiUri = "http://localhost:5000";

        // Create Client
        private RestClient ApiClient()
        {
            var client = new RestClient(ApiUri);
            return client;
        }

        // Create Request
        private RestRequest ApiRequest(string uri)
        {
            var request = new RestRequest(uri, Method.Get);
            request.AddHeader("Accept", "application/json");
            return request;
        }

        // Create JsonRequest

        // GET
        public T Get<T>(string uri)
        {
            var client = ApiClient();
            var request = ApiRequest(uri);
            var response = client.Execute(request);
            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonResponse = JsonConvert.DeserializeObject<T>(response.Content);
                return jsonResponse;
            }
            else
            {
                throw new Exception($"Error: Not able to get data from {uri}");
            }
        }

        // POST

        // PUT

        // DELETE
    }
}
