using System.Text.Json.Serialization;

namespace Module5HW1.Models.TypeOfAuthorization
{
    public class UnsuccessfulAuthorization : UserAuthorization
    {
        [JsonPropertyName("error")]
        public string Error { get; set; }
    }
}
