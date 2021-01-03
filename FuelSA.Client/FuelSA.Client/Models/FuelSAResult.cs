using System;
using System.Text.Json.Serialization;

namespace FuelSA.Client.Models
{
    public class FuelSAResult
    {
        [JsonPropertyName("petrol")]
        public PetrolItem[] PetrolData { get; set; }
        [JsonPropertyName("diesel")]
        public DieselItem[] DieselData { get; set; }
    }
}
