using System.Text.Json.Serialization;

namespace Module5HW1.Models
{
    public class Resource
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("year")]
        public string Year { get; set; }
        [JsonPropertyName("color")]
        public string Color { get; set; }
        [JsonPropertyName("pantone_value")]
        public string PantoneValue { get; set; }
    }
}
