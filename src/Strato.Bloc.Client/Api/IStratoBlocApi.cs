using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Strato.Bloc.Client.Models;

namespace Strato.Bloc.Client.Api
{
    /// <summary>
    /// See http://stratodev.blockapps.net/docs/?url=/bloc/v2.2/swagger.json and http://archive.ame-church.com/bloc-server/1.2/docs
    /// </summary>
    public interface IStratoBlocApi
    {
        [Get("users")]
        Task<IEnumerable<string>> UsersGetAsync();

        [Get("users/{user}")]
        Task<IEnumerable<string>> UsersGetAsync([Path] string user);

        [Get("contracts")]
        Task<IDictionary<string, IEnumerable<ContractResponse>>> ContractsGetAsync();

        [Get("search/{contractname}")]
        Task<IEnumerable<string>> ContractsSearchGetAsync([Path] string contractname);

        [Post("users/{user}/{address}/contract")]
        Task<BlocTransactionResult> UserContractPostAsync([Path] string user, [Path] string address, [Body] PostUsersContractRequest request);

        [Post("users/{user}/{userAddress}/contract/{contractName}/{contractAddress}/call")]
        Task<BlocTransactionResult> UsersContractMethodCallPostAsync([Path] string user, [Path] string userAddress, [Path] string contractName, [Path] string contractAddress, [Body] PostUsersContractMethodRequest request);

        [Post("transaction")]
        Task<string> TransactionPostAsync([Body] PostTransaction body);

        [Get("/transactions/{hash}/result")]
        Task<BlocTransactionResult> TransactionResultsGetAsync([Path] string hash);
    }
}