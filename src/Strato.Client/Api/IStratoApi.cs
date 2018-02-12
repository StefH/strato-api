using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Strato.Client.Models;

namespace Strato.Client.Api
{
    /// <summary>
    /// See http://stratodev.blockapps.net/docs/?url=/strato-api/eth/v1.2/swagger.json and http://archive.ame-church.com/strato-api/1.2/docs#post-solc
    /// </summary>
    public interface IStratoApi
    {
        [Get("account")]
        Task<IEnumerable<Account>> AccountsGetAsync(string address = null, int? balance = null, int? minbalance = null, int? maxbalance = null, int? nonce = null, int? minnonce = null, int? maxnonce = null);

        [Get("block")]
        Task<IEnumerable<Block>> BlocksGetAsync(int? number = null, int? minnumber = null, int? maxnumber = null, int? gaslim = null, int? mingaslim = null, int? maxgaslim = null, int? gasused = null, int? mingasused = null, int? maxgasused = null, int? diff = null, int? mindiff = null, int? maxdiff = null, string txaddress = null, string address = null, string coinbase = null, string hash = null);

        [Get("block/last/{number}")]
        Task<IEnumerable<Block>> BlocksLastGetAsync([Path] int number);

        [Post("extabi")]
        Task<ExtabiResponse> ExtabiPostAsync(string src);

        // Task<string> FaucetPostAsync(string address);

        [Post("solc")]
        Task<SolcResponse> SolcPostAsync(string src);

        // Task<Difficulty> StatsDifficultyGetAsync();

        // Task<TxCount> StatsTotaltxGetAsync();

        // Task<IEnumerable<Storage>> StorageGetAsync(string address = null);

        [Get("transaction")]
        Task<IEnumerable<Transaction>> TransactionsGetAsync(string from = null, string to = null, string address = null, int? value = null, int? maxvalue = null, int? minvalue = null, int? gasprice = null, int? maxgasprice = null, int? mingasprice = null, int? gaslimit = null, int? maxgaslimit = null, int? mingaslimit = null, int? blocknumber = null, string hash = null);

        // Task<IEnumerable<Transaction>> TransactionLastIntegerGetAsync(int? integer);

        // Task<IEnumerable<string>> TransactionListPostAsync(IEnumerable<PostTransaction> body);

        // Task<string> TransactionPostAsync(PostTransaction body);

        // Task<BatchTransactionResult> TransactionResultBatchPostAsync(IEnumerable<string> body);

        // Task<IEnumerable<TransactionResult>> TransactionResultHashGetAsync(string hash);
    }
}