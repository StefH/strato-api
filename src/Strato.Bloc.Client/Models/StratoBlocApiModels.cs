using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Strato.Bloc.Client.Models
{
    public class BlocTransactionResult
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public BlocTransactionStatus Status { get; set; }

        public string Hash { get; set; }

        public TransactionResult TxResult { get; set; }

        public BlocTransactionData Data { get; set; }
    }

    public class ContractResponse
    {
        public string Address { get; set; }

        public long CreatedAt { get; set; }
    }

    public class PostTransaction
    {
        public string Hash { get; set; }

        public double GasLimit { get; set; }

        public string CodeOrData { get; set; }

        public double GasPrice { get; set; }

        public string To { get; set; }

        public string From { get; set; }

        public double Value { get; set; }

        public string R { get; set; }

        public string S { get; set; }

        public string V { get; set; }

        public double Nonce { get; set; }
    }
}
