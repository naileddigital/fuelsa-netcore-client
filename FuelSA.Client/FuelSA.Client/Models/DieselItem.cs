using System;
using System.Text.Json.Serialization;

namespace FuelSA.Client.Models
{
    public class DieselItem
    {
        [JsonPropertyName("_id")]
        public string Id { get; set; }
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }
        [JsonPropertyName("location")]
        public string Location { get; set; }
        [JsonPropertyName("percentage")]
        public string Percentage { get; set; }
        [JsonPropertyName("value")]
        public int Value { get; set; }
        [JsonPropertyName("ppm")]
        public string PPM { get; set; }
        [JsonPropertyName("sulfates")]
        public string Sulfates { get; set; }
    }
}
