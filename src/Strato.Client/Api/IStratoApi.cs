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
        Task<IEnumerable<Account>> AccountsGetAsync(string address = null, long? balance = null, long? minbalance = null, long? maxbalance = null, long? nonce = null, long? minnonce = null, long? maxnonce = null);

        [Get("block")]
        Task<IEnumerable<Block>> BlocksGetAsync(long? number = null, long? minnumber = null, long? maxnumber = null, long? gaslim = null, long? mingaslim = null, long? maxgaslim = null, long? gasused = null, long? mingasused = null, long? maxgasused = null, long? diff = null, long? mindiff = null, long? maxdiff = null, string txaddress = null, string address = null, string coinbase = null, string hash = null);

        [Get("block/last/{number}")]
        Task<IEnumerable<Block>> BlocksLastGetAsync([Path] int number);

        [Post("extabi")]
        Task<ExtabiResponse> ExtabiPostAsync(string src);

        // Task<string> FaucetPostAsync(string address);

        [Post("solc")]
        Task<SolcResponse> SolcPostAsync(string src);

        [Get("stats/difficulty")]
        Task<StatsDifficulty> StatsDifficultyGetAsync();

        [Get("stats/totaltx")]
        Task<StatsTxCount> StatsTotalTxGetAsync();

        [Get("storage")]
        Task<IEnumerable<Storage>> StoragesGetAsync(string address);

        [Get("transaction")]
        Task<IEnumerable<Transaction>> TransactionsGetAsync(string from = null, string to = null, string address = null, long? value = null, long? maxvalue = null, long? minvalue = null, long? gasprice = null, long? maxgasprice = null, long? mingasprice = null, long? gaslimit = null, long? maxgaslimit = null, long? mingaslimit = null, long? blocknumber = null, string hash = null);

        // Task<IEnumerable<Transaction>> TransactionLastIntegerGetAsync(long? integer);

        // Task<IEnumerable<string>> TransactionListPostAsync(IEnumerable<PostTransaction> body);

        // Task<string> TransactionPostAsync(PostTransaction body);

        // Task<BatchTransactionResult> TransactionResultBatchPostAsync(IEnumerable<string> body);

        // Task<IEnumerable<TransactionResult>> TransactionResultHashGetAsync(string hash);
    }
}