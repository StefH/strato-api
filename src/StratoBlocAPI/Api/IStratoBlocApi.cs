using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using StratoBlocAPI.Models;

namespace StratoBlocAPI.Api
{
    /// <summary>
    /// See http://archive.ame-church.com/bloc-server/1.2/docs
    /// </summary>
    public interface IStratoBlocApi
    {
        /// <summary>
        /// Returns the array of users with keys
        /// </summary>
        [Get("users")]
        Task<IEnumerable<string>> UsersGetAsync();

        /// <summary>
        /// Returns an array of user public addresses.
        /// </summary>
        /// <param name="user"></param>
        [Get("users/{user}")]
        Task<IEnumerable<string>> UsersGetAsync([Path] string user);

        [Get("contracts")]
        Task<IDictionary<string, IEnumerable<ContractResponse>>> ContractsGetAsync();

        [Get("search/{contractname}")]
        Task<IEnumerable<string>> ContractsSearchGetAsync([Path] string contractname);

        [Post("users/{user}/{address}/contract")]
        Task<BlocTransactionResult> UsersContractPostAsync([Path] string user, [Path] string address, [Body] PostUsersContractRequest request);

        [Post("users/{user}/{userAddress}/contract/{contractName}/{contractAddress}/call")]
        Task<BlocTransactionResult> UsersContractMethodCallPostAsync([Path] string user, [Path] string userAddress, [Path] string contractName, [Path] string contractAddress, [Body] PostUsersContractMethodRequest request);
    }
}