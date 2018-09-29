using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Strato.Client.Models;

namespace Strato.Client.Api
{
    public interface IStratoAccountApi
    {
        [Get("account")]
        Task<IEnumerable<Account>> AccountsGetAsync(string address, long? balance = null, long? minbalance = null, long? maxbalance = null, long? nonce = null, long? minnonce = null, long? maxnonce = null);
    }
}