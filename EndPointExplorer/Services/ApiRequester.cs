using System.Net.Http;
using System.Text;
using EndPointExplorer.Models;

namespace EndPointExplorer.Services
{
    internal class ApiRequester
    {
        private readonly HttpClient _client = new HttpClient();

        public async Task<string> SendRequestAsync(RequestModel requestModel)
        {
            var request = new HttpRequestMessage(new HttpMethod(requestModel.Method), requestModel.Url);

            // Add headers to the request
            foreach (var header in requestModel.Headers)
            {
                request.Headers.Add(header.Key, header.Value);
            }

            // Set request body for applicable methods
            if (!string.IsNullOrWhiteSpace(requestModel.Body) && (requestModel.Method == "POST" || requestModel.Method == "PUT"))
            {
                request.Content = new StringContent(requestModel.Body, Encoding.UTF8, "application/json");
            }

            var response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
    }
}
