using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace FuelSA.Client.Example
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new FuelSAClient("YOUR-API-KEY-HERE");
            var result = await client.GetCurrentFuelPrices();
            var fuelpricesForYear = await client.GetFuelPricesForYear(2020);
            Console.WriteLine("Current Fuel Prices: " + JsonSerializer.Serialize(result));
            Console.WriteLine("Fuel Prices for 2020: " + JsonSerializer.Serialize(fuelpricesForYear));
            Console.ReadLine();
        }
    }
}
