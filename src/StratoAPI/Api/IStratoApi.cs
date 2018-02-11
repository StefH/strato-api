using System.Collections.Generic;
using System.Threading.Tasks;
using StratoAPI.Models;
using RestEase;

namespace StratoAPI.Api
{
    /// <summary>
    /// 1] Generated via https://editor.swagger.io//#/ --> csharp
    /// 2] Removed all methods ***WithHttpInfo
    /// 3] Replaced List by IEnumerable 
    /// 4] Added RestEase method attributes (Get and Post)
    /// 5] Pluralize methods
    /// 6] Replaced comment with comments from http://archive.ame-church.com/strato-api/1.2/docs#post-solc
    /// </summary>
    public interface IStratoApi
    {
        [Get("account")]
        Task<IEnumerable<Account>> AccountsGetAsync(string address = null, int? balance = null, int? minbalance = null, int? maxbalance = null, int? nonce = null, int? minnonce = null, int? maxnonce = null);

        //[Get("block")]
        //Task<IEnumerable<Block>> BlockGetAsync(int? number = null, int? minnumber = null, int? maxnumber = null, int? gaslim = null, int? mingaslim = null, int? maxgaslim = null, int? gasused = null, int? mingasused = null, int? maxgasused = null, int? diff = null, int? mindiff = null, int? maxdiff = null, string txaddress = null, string address = null, string coinbase = null, string hash = null);

        //[Get("block/last/{integer}")]
        //Task<IEnumerable<Block>> BlockLastIntegerGetAsync([Path] int integer);

        /// <summary>
        /// Get the symbol table associated with a solidity source file.
        /// </summary>
        /// <param name="src">The solidity source</param>
        /// <returns>ExtabiResponse</returns>
        [Post("extabi")]
        Task<ExtabiResponse> ExtabiPostAsync(string src);

        // Task<string> FaucetPostAsync(string address);

        /// <summary>
        /// Compile a smart contract with the solidity compiler. 
        /// </summary>
        /// <param name="src">The solidity source</param>
        /// <returns>SolcResponse</returns>
        [Post("solc")]
        Task<SolcResponse> SolcPostAsync(string src);

        // Task<Difficulty> StatsDifficultyGetAsync();

        // Task<TxCount> StatsTotaltxGetAsync();

        // Task<IEnumerable<Storage>> StorageGetAsync(string address = null);

        // Task<IEnumerable<Transaction>> TransactionGetAsync(string from = null, string to = null, string address = null, int? value = null, int? maxvalue = null, int? minvalue = null, int? gasprice = null, int? maxgasprice = null, int? mingasprice = null, int? gaslimit = null, int? maxgaslimit = null, int? mingaslimit = null, int? blocknumber = null, string hash = null);

        // Task<IEnumerable<Transaction>> TransactionLastIntegerGetAsync(int? integer);

        // Task<IEnumerable<string>> TransactionListPostAsync(IEnumerable<PostTransaction> body);

        // Task<string> TransactionPostAsync(PostTransaction body);

        // Task<BatchTransactionResult> TransactionResultBatchPostAsync(IEnumerable<string> body);

        // Task<IEnumerable<TransactionResult>> TransactionResultHashGetAsync(string hash);
    }
}