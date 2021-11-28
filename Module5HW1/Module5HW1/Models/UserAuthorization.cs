using System.Text.Json.Serialization;

namespace Module5HW1.Models
{
    public class UserAuthorization
    {
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
