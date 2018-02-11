using System.Linq;
using System.Threading.Tasks;
using RestEase;
using StratoAPI.Api;
using StratoBlocAPI.Api;
using StratoBlocAPI.Models;

namespace ConsoleAppStratoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            TestStratoApi().Wait(44444);

            TestStratoBlocApi().Wait(444444);

            int y = 0;
        }

        private static async Task TestStratoApi()
        {
            var api = RestClient.For<IStratoApi>("http://stratodev.blockapps.net/strato-api/eth/v1.2/");

            var stefTests = await api.AccountsGetAsync("997b582e5e85afd141f4bce1cdcf57c1791a81b7");

            // var response = await api.ExtabiPostAsync("");

            int y = 99;
        }

        private static async Task TestStratoBlocApi()
        {
            var api = RestClient.For<IStratoBlocApi>("http://stratodev.blockapps.net/bloc/v2.2/");

            var users1 = await api.UsersGetAsync();

            var users2 = await api.UsersGetAsync("stef-test");
            string stefTestAddress = users2.FirstOrDefault();

            var contracts = await api.ContractsGetAsync();

            var search = await api.ContractsSearchGetAsync("MyFirstContract");

            var contractRequest = new PostUsersContractRequest
            {
                Password = "stefstef",
                Contract = "Test02",
                Src = "contract Test02 { uint storedData; function set(uint x) { storedData = x; } function get() returns (uint retVal) { return storedData; } }"
            };
            var create = await api.UsersContractPostAsync("stef-01", "eb872895e2729a3c75109322c82eee662ec934b4", contractRequest);

            int y = 99;
        }
    }
}
