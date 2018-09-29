using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Strato.Client.Models;

namespace Strato.Client.Api
{
    public interface IStratoBlockApi
    {
        [Get("block")]
        Task<IEnumerable<Block>> BlocksGetAsync(long number, long? minnumber = null, long? maxnumber = null, long? gaslim = null, long? mingaslim = null, long? maxgaslim = null, long? gasused = null, long? mingasused = null, long? maxgasused = null, long? diff = null, long? mindiff = null, long? maxdiff = null, string txaddress = null, string address = null, string coinbase = null, string hash = null);

        [Get("block/last/{number}")]
        Task<IEnumerable<Block>> BlocksLastGetAsync([Path] int number);
    }
}