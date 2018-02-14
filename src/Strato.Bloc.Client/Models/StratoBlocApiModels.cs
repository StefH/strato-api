using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Strato.Bloc.Client.Models
{
    public class BlocTransactionData
    {
        public PostTransaction Send { get; set; }

        public ContractDetails Upload { get; set; }

        public IEnumerable<string> Call { get; set; }
    }

    public class BlocTransactionResult
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public BlocTransactionStatus Status { get; set; }

        public string Hash { get; set; }

        public TransactionResult TxResult { get; set; }

        public BlocTransactionData Data { get; set; }
    }

    public enum BlocTransactionStatus
    {
        Success = 0,

        Failure = 1,

        Pending = 2
    }

    public class Contract
    {
        public int Bytes { get; set; }
    }

    public class ContractDetails
    {
        public string Bin { get; set; }

        public string Address { get; set; }

        public string BinRuntime { get; set; }

        public string CodeHash { get; set; }

        public string Name { get; set; }

        public XabiSchema Xabi { get; set; }
    }

    public class ContractResponse
    {
        public string Address { get; set; }

        public long CreatedAt { get; set; }
    }

    public class Enum
    {
        public IEnumerable<string> Names { get; set; }

        public int Bytes { get; set; }
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

    public class SearchContractState
    {
        public string Address { get; set; }

        public IDictionary<string, string> State { get; set; }
    }

    public class SolidityType
    {
        public int IndexedTypeIndex { get; set; }

        public SolidityType IndexedTypeType { get; set; }
    }

    public class Struct
    {
        public int Bytes { get; set; }

        public IDictionary<string, FieldType> Fields { get; set; }
    }

    public class TransactionParameters
    {
        public int? GasLimit { get; set; }

        public int? GasPrice { get; set; }

        public int? Nonce { get; set; }
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

    public class TypeDef
    {
        public Enum Enum { get; set; }

        public Struct Struct { get; set; }

        public Contract Contract { get; set; }
    }

    public class UploadListContract
    {
        public string ContractName { get; set; }

        public IDictionary<string, string> Args { get; set; }

        public TransactionParameters TxParams { get; set; }

        public double? Value { get; set; }
    }

    public class UploadListRequest
    {
        public string Password { get; set; }

        public IEnumerable<UploadListContract> Contracts { get; set; }

        public bool Resolve { get; set; }
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