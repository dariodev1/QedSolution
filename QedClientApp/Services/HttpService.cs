using QedClientApp.Services.Abstract;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace QedClientApp.Services
{
    internal class HttpService : IHttpService
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        public async Task<string> PerformApiOperationAsync(string? number1, string? number2)
        {
            var url = $"https://localhost:7171/addNumbers/{{number1,number2}}?number1={number1}&number2={number2}";
            
            try
            {
                var response = await _httpClient.GetAsync(url);
                var result = await response.Content.ReadAsStringAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
