using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Strato.Client.Models;

namespace Strato.Client.Api
{
    public interface IStratoTransactionApi
    {
        [Get("transaction")]
        Task<IEnumerable<Transaction>> TransactionsGetAsync(string from, string to = null, string address = null, long? value = null, long? maxvalue = null, long? minvalue = null, long? gasprice = null, long? maxgasprice = null, long? mingasprice = null, long? gaslimit = null, long? maxgaslimit = null, long? mingaslimit = null, long? blocknumber = null, string hash = null);

        [Get("transaction/last/{number}")]
        Task<IEnumerable<Transaction>> TransactionLastGetAsync([Path] long number);

        [Post("transactionList")]
        Task<IEnumerable<string>> TransactionListPostAsync([Body] IEnumerable<PostTransaction> body);

        [Post("transaction")]
        Task<string> TransactionPostAsync([Body] PostTransaction body);

        [Post("transactionResult/batch")]
        Task<BatchTransactionResult> TransactionResultBatchPostAsync([Body] IEnumerable<string> hashList);

        [Get("transactionResult/{hash}")]
        Task<IEnumerable<TransactionResult>> TransactionResultsHashGetAsync([Path] string hash);
    }
}