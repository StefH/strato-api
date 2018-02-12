using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Strato.Client.Models
{
    public class Block
    {
        public string Kind { get; set; }

        public string Next { get; set; }

        public IEnumerable<BlockData> BlockUncles { get; set; }

        public IEnumerable<Transaction> ReceiptTransactions { get; set; }

        public BlockData BlockData { get; set; }
    }

    public class BlockData
    {
        public double ExtraData { get; set; }

        public double GasUsed { get; set; }

        public double GasLimit { get; set; }

        public string Kind { get; set; }

        public string UnclesHash { get; set; }

        public string MixHash { get; set; }

        public string ReceiptsRoot { get; set; }

        public double Number { get; set; }

        public double Difficulty { get; set; }

        public string Timestamp { get; set; }

        public string Coinbase { get; set; }

        public string ParentHash { get; set; }

        public long Nonce { get; set; }

        public string StateRoot { get; set; }

        public string TransactionsRoot { get; set; }
    }

    public class ExtabiResponse
    {
        public IDictionary<string, XabiSchema> Src { get; set; }
    }

    public class StatsDifficulty
    {
        public long Difficulty { get; set; }
    }

    public class StatsTxCount
    {
        public long TransactionCount { get; set; }
    }

    public class Storage
    {
        public string StorageAddress { get; set; }

        public string StorageKey { get; set; }

        public string StorageValue { get; set; }
    }

    public class Transaction
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public TransactionType TransactionType { get; set; }

        public string Hash { get; set; }

        public double GasLimit { get; set; }

        public string CodeOrData { get; set; }

        public double GasPrice { get; set; }

        public string To { get; set; }

        public string From { get; set; }

        public double Value { get; set; }

        public bool? FromBlock { get; set; }

        public long? BlockNumber { get; set; }

        public string R { get; set; }

        public string S { get; set; }

        public string V { get; set; }

        public string Timestamp { get; set; }

        public double Nonce { get; set; }

        public string Origin { get; set; }
    }

    public enum TransactionType
    {
        Contract = 0,

        FunctionCall = 1,

        Transfer = 2
    }

    public class XabiSchema
    {
        public IDictionary<string, FunctionType> Funcs { get; set; }

        public IDictionary<string, FunctionType> Constr { get; set; }

        public IDictionary<string, VarType> Vars { get; set; }

        public IDictionary<string, TypeDef> Types { get; set; }

        public IDictionary<string, FunctionModifier> Modifiers { get; set; }
    }
}