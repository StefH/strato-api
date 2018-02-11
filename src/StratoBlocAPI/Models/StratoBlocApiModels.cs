using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StratoBlocAPI.Models
{
    public class ContractResponse
    {
        public string Address { get; set; }

        public long CreatedAt { get; set; }
    }

    public class BlocTransactionResult
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public BlocTransactionStatus Status { get; set; }

        public string Hash { get; set; }

        public TransactionResult TxResult { get; set; }

        public BlocTransactionData Data { get; set; }
    }
}
