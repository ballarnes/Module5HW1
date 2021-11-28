using System.Text.Json.Serialization;

namespace Module5HW1.Models
{
    public class Response<T>
    {
        [JsonPropertyName("page")]
        public string Page { get; set; }

        [JsonPropertyName("per_page")]
        public string PerPage { get; set; }
        [JsonPropertyName("total")]
        public string Total { get; set; }

        [JsonPropertyName("total_pages")]
        public string TotalPages { get; set; }
        [JsonPropertyName("data")]
        public T Data { get; set; }
        [JsonPropertyName("support")]
        public Support Support { get; set; }
    }
}
