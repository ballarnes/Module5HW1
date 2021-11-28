using System.Text.Json.Serialization;

namespace Module5HW1.Models
{
    public class Support
    {
        [JsonPropertyName("url")]
        public string URL { get; set; }
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
