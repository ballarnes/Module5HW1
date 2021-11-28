using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using System.Net;
using Module5HW1.Models;
using Newtonsoft.Json;
using Module5HW1.Models.TypeOfAuthorization;
using Module5HW1.Services.Abstractions;

namespace Module5HW1.Services
{
    public class LoginService : ILoginService
    {
        public async Task<UserAuthorization> PostLoginSuccessful()
        {
            using (var httpClient = new HttpClient())
            {
                var payload = new
                {
                    email = "eve.holt@reqres.in",
                    password = "cityslicka"
                };

                var httpContent = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");

                var result = await httpClient.PostAsync(@"https://reqres.in/api/login", httpContent);

                var content = await result.Content.ReadAsStringAsync();

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var response = JsonConvert.DeserializeObject<SuccessfulAuthorization>(content);
                    return response;
                }
                else
                {
                    var response = JsonConvert.DeserializeObject<UnsuccessfulAuthorization>(content);
                    return response;
                }
            }
        }

        public async Task<UserAuthorization> PostLoginUnsuccessful()
        {
            using (var httpClient = new HttpClient())
            {
                var payload = new
                {
                    email = "peter@klaven"
                };

                var httpContent = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");

                var result = await httpClient.PostAsync(@"https://reqres.in/api/login", httpContent);

                var content = await result.Content.ReadAsStringAsync();

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var response = JsonConvert.DeserializeObject<SuccessfulAuthorization>(content);
                    return response;
                }
                else
                {
                    var response = JsonConvert.DeserializeObject<UnsuccessfulAuthorization>(content);
                    return response;
                }
            }
        }
    }
}
