using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Strato.Client.Models;

namespace Strato.Client.Api
{
    public interface IStratoStorageApi
    {
        [Get("storage")]
        Task<IEnumerable<Storage>> StoragesGetAsync(string address);
    }
}