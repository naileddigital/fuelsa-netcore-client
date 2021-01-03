using System;
using System.Text.Json.Serialization;

namespace FuelSA.Client.Models
{
    public class PetrolItem
    {
        [JsonPropertyName("_id")]
        public string Id { get; set; }
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }
        [JsonPropertyName("location")]
        public string Location { get; set; }
        [JsonPropertyName("octane")]
        public string Octane { get; set; }
        [JsonPropertyName("value")]
        public int Value { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
