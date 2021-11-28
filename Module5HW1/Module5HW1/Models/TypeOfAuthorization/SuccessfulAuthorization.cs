using System.Text.Json.Serialization;

namespace Module5HW1.Models.TypeOfAuthorization
{
    public class SuccessfulAuthorization : UserAuthorization
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
