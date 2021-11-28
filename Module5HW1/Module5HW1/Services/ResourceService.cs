using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Module5HW1.Models;
using Newtonsoft.Json;
using Module5HW1.Services.Abstractions;

namespace Module5HW1.Services
{
    public class ResourceService : IResourceService
    {
        public async Task<List<Resource>> GetListResources()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/unknown");

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var randomResources = JsonConvert.DeserializeObject<Response<List<Resource>>>(content);
                    return randomResources.Data;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<Resource> GetSingleResource()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/unknown/2");

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var randomResource = JsonConvert.DeserializeObject<Response<Resource>>(content);
                    return randomResource.Data;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<Resource> GetSingleResourceNotFound()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/unknown/23");

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var randomResource = JsonConvert.DeserializeObject<Response<Resource>>(content);
                    return randomResource.Data;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
