using System.Text.Json.Serialization;

namespace Module5HW1.Models
{
    public class User
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
        [JsonPropertyName("job")]
        public string Job { get; set; }
        [JsonPropertyName("updatedAt")]
        public string UpdatedAt { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    }
}
