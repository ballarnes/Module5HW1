using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Module5HW1.Models;
using Module5HW1.Services.Abstractions;
using Newtonsoft.Json;

namespace Module5HW1.Services
{
    public class UserService : IUserService
    {
        public async Task<List<User>> GetListUsers()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/users?page=2");

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var randomUsers = JsonConvert.DeserializeObject<Response<List<User>>>(content);
                    return randomUsers.Data;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<User> GetSingleUser()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/users/2");

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var randomUser = JsonConvert.DeserializeObject<Response<User>>(content);
                    return randomUser.Data;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<User> GetSingleUserNotFound()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/users/23");

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var randomUser = JsonConvert.DeserializeObject<User>(content);
                    return randomUser;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<User> PostCreate()
        {
            using (var httpClient = new HttpClient())
            {
                var payload = new
                {
                    name = "morpheus",
                    job = "leader"
                };

                var httpContent = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");

                var result = await httpClient.PostAsync(@"https://reqres.in/api/users", httpContent);

                if (result.StatusCode == HttpStatusCode.Created)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var response = JsonConvert.DeserializeObject<User>(content);
                    return response;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<User> PutUpdate()
        {
            using (var httpClient = new HttpClient())
            {
                var payload = new
                {
                    name = "morpheus",
                    job = "zion resident"
                };

                var httpContent = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");

                var result = await httpClient.PutAsync(@"https://reqres.in/api/users/2", httpContent);

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var response = JsonConvert.DeserializeObject<User>(content);
                    return response;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<User> PatchUpdate()
        {
            using (var httpClient = new HttpClient())
            {
                var payload = new
                {
                    name = "morpheus",
                    job = "zion resident"
                };

                var httpContent = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");

                var result = await httpClient.PatchAsync(@"https://reqres.in/api/users/2", httpContent);

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var response = JsonConvert.DeserializeObject<User>(content);
                    return response;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<User> Delete()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.DeleteAsync(@"https://reqres.in/api/users/2");

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var deletedUser = JsonConvert.DeserializeObject<User>(content);
                    return deletedUser;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<List<User>> GetDelayedResponse()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/users?delay=3");

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var randomUsers = JsonConvert.DeserializeObject<Response<List<User>>>(content);
                    return randomUsers.Data;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
