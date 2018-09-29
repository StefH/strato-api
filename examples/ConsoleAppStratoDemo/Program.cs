using System;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestEase;
using Strato.Bloc.Client.Api;
using Strato.Client.Api;
using Strato.Client.Models;

namespace ConsoleAppStratoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            TestStratoApi().Wait(60000);

            TestStratoBlocApi().Wait(60000);
        }

        private static async Task TestStratoApi()
        {
            var client = RestClient.For<IStratoApi>("http://stratodev.blockapps.net/strato-api/eth/v1.2/");

            var accounts = await client.AccountsGetAsync("e1fd0d4a52b75a694de8b55528ad48e2e2cf7859");
            Console.WriteLine("AccountsGetAsync = " + JsonConvert.SerializeObject(accounts, Formatting.Indented));

            var blocs = await client.BlocksGetAsync(28971);
            Console.WriteLine("BlocksGetAsync = " + JsonConvert.SerializeObject(blocs, Formatting.Indented));

            var last = await client.BlocksLastGetAsync(2);
            Console.WriteLine("BlocksLastGetAsync = " + JsonConvert.SerializeObject(last, Formatting.Indented));

            var trans = await client.TransactionsGetAsync("e1fd0d4a52b75a694de8b55528ad48e2e2cf7859");
            Console.WriteLine("TransactionsGetAsync = " + JsonConvert.SerializeObject(trans, Formatting.Indented));

            var lastTrans = await client.TransactionLastGetAsync(27143);
            Console.WriteLine("TransactionLastGetAsync = " + JsonConvert.SerializeObject(lastTrans.FirstOrDefault(), Formatting.Indented));

            var transResult = await client.TransactionResultsHashGetAsync("883eee9f2223dfc125c31dbd937b68278a7a8251d54f85b8c1b2c834ce8c9b34");
            Console.WriteLine("TransactionResultsHashGetAsync = " + JsonConvert.SerializeObject(transResult, Formatting.Indented));

            var stats1 = await client.StatsDifficultyGetAsync();
            Console.WriteLine("StatsDifficultyGetAsync = " + JsonConvert.SerializeObject(stats1, Formatting.Indented));

            var stats2 = await client.StatsTotalTxGetAsync();
            Console.WriteLine("StatsTotalTxGetAsync = " + JsonConvert.SerializeObject(stats2, Formatting.Indented));

            string f = await client.FaucetPostAsync(new FaucetRequest("18cb93ccd293a7407e7747a635902fad390f43a7"));
            Console.WriteLine("FaucetPostAsync = " + JsonConvert.SerializeObject(f, Formatting.Indented));

            // var solc = await client.SolcPostAsync(new SolcRequest { Src = "contract Test { uint storedData; function set(uint x) { storedData = x; } function get() returns (uint retVal) { return storedData; } }" });


            //var storages = await client.StoragesGetAsync("eb49ed4bb6ed7f0a73189166fc9486fff65b1630");

            //var response = await client.ExtabiPostAsync(new ExtabiRequest("contract Test { uint storedData; function set(uint x) { storedData = x; } function get() returns (uint retVal) { return storedData; } }"));

        }

        private static async Task TestStratoBlocApi()
        {
            var client = RestClient.For<IStratoBlocApi>("http://stratodev.blockapps.net/bloc/v2.2/");

            // var users1 = await client.UsersGetAsync();

            //var users2 = await client.UsersGetAsync("stef-test");
            //string stefTestAddress = users2.FirstOrDefault();

            //var contracts = await client.ContractsGetAsync();

            //var search = await client.ContractsSearchGetAsync("MyFirstContract");

            //string name = "Test" + DateTime.UtcNow.Ticks;
            //var contractRequest = new PostUserContractRequest
            //{
            //    Password = "stefstef",
            //    Contract = name,
            //    Src = "contract " + name + " { uint storedData; function set(uint x) { storedData = x; } function get() returns (uint retVal) { return storedData; } }"
            //};
            //var create = await client.UserContractPostAsync("stef-01", "eb872895e2729a3c75109322c82eee662ec934b4", contractRequest);
            //Console.WriteLine("create = " + JsonConvert.SerializeObject(create));

            //// Takes about 10 to 30 seconds
            //int i = 0;
            //BlocTransactionResult res;
            //for (; ; )
            //{
            //    res = await client.TransactionResultsGetAsync(create.Hash);
            //    i++;

            //    Console.WriteLine("Waiting...");
            //    Thread.Sleep(5000);

            //    if (res.Status == BlocTransactionStatus.Success || i > 10)
            //    {
            //        break;
            //    }
            //}

            //Console.WriteLine($"i={i}, res={JsonConvert.SerializeObject(res)}");
        }
    }
}