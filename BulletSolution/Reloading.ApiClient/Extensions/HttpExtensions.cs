using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Reloading.ApiClient.Extensions
{
    public static class HttpResponseExtentions
    {
        //static async method with a generic type T with parameters HttpResponseMessage and response
        public static async Task<T> ReadResponse<T>(this HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode) throw new Exception(response.StatusCode.ToString());

            // reading HTTP responses content as string
            var responseContent = await response.Content.ReadAsStringAsync();

            // First deserializes json string to an object type(T), then returns the object
            return JsonConvert.DeserializeObject<T>(responseContent);
        }

        //creates a public awaitable Task which has TResult as HttpResponseMessage. 
        public static async Task<HttpResponseMessage> Post(this string address, object data)
        {
            // creates a new instance of HttpClient
            using var client = new HttpClient();

            // defines string content and serializes the object (data) to JSON string. After that returns a JSON string
            var content = JsonConvert.SerializeObject(data);

            //Sends a Post request to the url (address). After that creates a new instance of StringContent defined by parameters
            return await client.PostAsync(address, new StringContent(content, Encoding.UTF8, "application/json"));
        }

        //creates a public awaitable task with a generic type T with parameter string named address
        public static async Task<T> Get<T>(this string address)
        {
            //creates a new instance of HttpClient
            using var client = new HttpClient();

            // awaitable GetAsync method that sends a get request to the url (address)
            var response = await client.GetAsync(address);

            //returns the response content from ReadResponse extension.
            return await response.ReadResponse<T>();
        }
    }
}