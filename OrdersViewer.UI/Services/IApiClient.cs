using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using OrdersViewer.Models;
namespace OrdersViewer.UI.Services
{
    public interface IApiClient
    {
        Task<List<OrdersViewer.Models.Order>> GetOrdersAsync();
    }

    public class ApiClient : IApiClient
    {
        private readonly HttpClient _HttpClient;

        public ApiClient(HttpClient httpClient)
        {
            _HttpClient = httpClient;
        }

        public async Task<List<Order>> GetOrdersAsync()
        {
            var response = await _HttpClient.GetAsync("/api/Orders");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsJsonAsync<List<Order>>();
        }
    }
}