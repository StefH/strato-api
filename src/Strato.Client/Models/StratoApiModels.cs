using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Strato.Client.Models
{
    public class AbiBin
    {
        public string Abi { get; set; }

        public string Bin { get; set; }

        public string BinRuntime { get; set; }
    }

    public class Account
    {
        public string Address { get; set; }

        public int Nonce { get; set; }

        public string Kind { get; set; }

        public double Balance { get; set; }

        public string ContractRoot { get; set; }

        public string Code { get; set; }

        public string CodeHash { get; set; }

        public double LatestBlockNum { get; set; }

        public string Source { get; set; }
    }

    public class BatchTransactionResult
    {
        public IDictionary<string, IEnumerable<TransactionResult>> UnBatchTransactionResult { get; set; }
    }

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

    public class Contract
    {
        public int Bytes { get; set; }
    }

    public class Enum
    {
        public IEnumerable<string> Names { get; set; }

        public int Bytes { get; set; }
    }

    public class ExtabiResponse
    {
        public IDictionary<string, XabiSchema> Src { get; set; }
    }

    public class FieldType
    {
        public int FieldTypeAtBytes { get; set; }

        public SolidityType FieldTypeType { get; set; }
    }

    public class FunctionModifier
    {
        public IDictionary<string, SolidityType> Args { get; set; }

        public string Selector { get; set; }

        public IDictionary<string, SolidityType> Vals { get; set; }

        public string Contents { get; set; }
    }

    public class FunctionType
    {
        public IDictionary<string, SolidityType> Args { get; set; }

        public IDictionary<string, SolidityType> Vals { get; set; }

        public string Contents { get; set; }

        public bool? Mutable { get; set; }

        public bool? Payable { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public VisibilityOfAFunction? Visibility { get; set; }

        public IEnumerable<string> Modifiers { get; set; }
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

    public class SolcResponse
    {
        public IDictionary<string, AbiBin> SolcresponseSrc { get; set; }
    }

    public class SolidityType
    {
        public int IndexedTypeIndex { get; set; }

        public SolidityType IndexedTypeType { get; set; }
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

    public class Struct
    {
        public int Bytes { get; set; }

        public IDictionary<string, FieldType> Fields { get; set; }
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

    public class TransactionResult
    {
        public string BlockHash { get; set; }

        public string TransactionHash { get; set; }

        public string Message { get; set; }

        public string Response { get; set; }

        public string Trace { get; set; }

        public string GasUsed { get; set; }

        public string EtherUsed { get; set; }

        public string ContractsCreated { get; set; }

        public string ContractsDeleted { get; set; }

        public string StateDiff { get; set; }

        public double Time { get; set; }

        public string NewStorage { get; set; }

        public string DeletedStorage { get; set; }
    }

    public enum TransactionType
    {
        Contract = 0,

        FunctionCall = 1,

        Transfer = 2
    }

    public class TypeDef
    {
        public Enum Enum { get; set; }

        public Struct Struct { get; set; }

        public Contract Contract { get; set; }
    }

    public class VarType
    {
        public int VarTypeAtBytes { get; set; }

        public bool? VarTypePublic { get; set; }

        public SolidityType VarTypeType { get; set; }
    }

    public enum VisibilityOfAFunction
    {
        Private = 0,

        Public = 1,

        Internal = 2,

        External = 3
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