using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Services
{
        public static class FactoryAPI
        {
            public static Task<List<Match>?> GetAllMatchesAsync(string gender) =>
            ApiService.FetchFromApiAsync<List<Match>>($"/{gender}/matches");

             public static Task<List<Match>?> GetMatchesByCountryAsync(string gender, string fifaCode) => ApiService.FetchFromApiAsync<List<Match>>($"/{gender}/matches/country?fifa_code={fifaCode}");

            public static Task<List<Team>?> GetTeamsAsync(string gender) =>
                ApiService.FetchFromApiAsync<List<Team>>($"/{gender}/teams");

            public static Task<List<TeamScore>?> GetTeamResultsAsync(string gender) =>
                ApiService.FetchFromApiAsync<List<TeamScore>>($"/{gender}/teams/results");

            public static Task<List<TeamStanding>?> GetGroupResultsAsync(string gender) =>
                ApiService.FetchFromApiAsync<List<TeamStanding>>($"/{gender}/teams/group_results");
        }
}
