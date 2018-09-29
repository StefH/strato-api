namespace Strato.Client.Api
{
    /// <summary>
    /// See http://stratodev.blockapps.net/docs/?url=/strato-api/eth/v1.2/swagger.json and http://archive.ame-church.com/strato-api/1.2/docs#post-solc
    /// </summary>
    public interface IStratoApi : IStratoTransactionApi, IStratoAccountApi, IStratoBlockApi, IStratoStatsApi, IStratoStorageApi, IStratoFaucetApi
    {
        //[Post("extabi")]
        //Task<ExtabiResponse> ExtabiPostAsync([Body(BodySerializationMethod.UrlEncoded)] ExtabiRequest request);

        //[Post("solc")]
        //Task<SolcResponse> SolcPostAsync([Body]SolcRequest request);
    }
}