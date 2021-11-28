using System.Collections.Generic;
using System.Threading.Tasks;
using Module5HW1.Models;

namespace Module5HW1.Services.Abstractions
{
    public interface IResourceService
    {
        Task<List<Resource>> GetListResources();
        Task<Resource> GetSingleResource();
        Task<Resource> GetSingleResourceNotFound();
    }
}