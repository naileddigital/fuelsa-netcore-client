using FuelSA.Client.Models;
using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace FuelSA.Client
{
    public class FuelSAClient
    {
        private string _apiKey { get; set; }

        public FuelSAClient(string apiKey)
        {
            _apiKey = apiKey;
        }

        public async Task<FuelSAResult> GetCurrentFuelPrices()
        {
            using (var client = new WebClient())
            {
                client.Headers.Add("key", _apiKey);
                var data = await client.DownloadStringTaskAsync("https://api.fuelsa.co.za/exapi/fuel/current");
                return JsonSerializer.Deserialize<FuelSAResult>(data);
            }
        }

        public async Task<FuelSAResult> GetFuelPricesForYear(int year)
        {
            using (var client = new WebClient())
            {
                client.Headers.Add("key", _apiKey);
                var data = await client.DownloadStringTaskAsync($"https://api.fuelsa.co.za/exapi/fuel/byyear/{year}");
                return JsonSerializer.Deserialize<FuelSAResult>(data);
            }
        }
    }
}
