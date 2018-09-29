using System.Threading.Tasks;
using RestEase;
using Strato.Client.Models;

namespace Strato.Client.Api
{
    public  interface IStratoFaucetApi
    {
        /// <summary>
        /// Faucets the post asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>32 byte hex encoded string</returns>
        [Post("faucet")]
        Task<string> FaucetPostAsync([Body(BodySerializationMethod.UrlEncoded)] FaucetRequest request);
    }
}