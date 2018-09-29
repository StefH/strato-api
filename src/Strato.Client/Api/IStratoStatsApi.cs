using System.Threading.Tasks;
using RestEase;
using Strato.Client.Models;

namespace Strato.Client.Api
{
    public interface IStratoStatsApi
    {
        [Get("stats/difficulty")]
        Task<StatsDifficulty> StatsDifficultyGetAsync();

        [Get("stats/totaltx")]
        Task<StatsTxCount> StatsTotalTxGetAsync();
    }
}