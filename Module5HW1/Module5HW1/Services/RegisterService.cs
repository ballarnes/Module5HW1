using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Module5HW1.Models;
using Module5HW1.Models.TypeOfAuthorization;
using Module5HW1.Services.Abstractions;
using Newtonsoft.Json;

namespace Module5HW1.Services
{
    public class RegisterService : IRegisterService
    {
        public async Task<UserAuthorization> PostRegisterSuccessful()
        {
            using (var httpClient = new HttpClient())
            {
                var payload = new
                {
                    email = "eve.holt@reqres.in",
                    password = "pistol"
                };

                var httpContent = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");

                var result = await httpClient.PostAsync(@"https://reqres.in/api/register", httpContent);

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

        public async Task<UserAuthorization> PostRegisterUnsuccessful()
        {
            using (var httpClient = new HttpClient())
            {
                var payload = new
                {
                    email = "sydney@fife"
                };

                var httpContent = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");

                var result = await httpClient.PostAsync(@"https://reqres.in/api/register", httpContent);

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
