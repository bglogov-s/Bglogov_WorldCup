using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataLibrary.Services
{
    public static class FactoryAPI
    {
        public static Task<List<System.Text.RegularExpressions.Match>?> GetAllMatchesAsync(string gender) =>
        DataLibrary.Services.ApiService.FetchFromApiAsync<List<System.Text.RegularExpressions.Match>>($"/{gender}/matches");

        public static Task<List<System.Text.RegularExpressions.Match>?> GetMatchesByCountryAsync(string gender, string fifaCode) =>
         DataLibrary.Services.ApiService.FetchFromApiAsync<List<System.Text.RegularExpressions.Match>>($"/{gender}/matches/country?fifa_code={fifaCode}");
        public static Task<List<Team>?> GetTeamsAsync(string gender) =>
        DataLibrary.Services.ApiService.FetchFromApiAsync<List<Team>>($"/{gender}/teams");

        public static Task<List<TeamScore>?> GetTeamResultsAsync(string gender) =>
        DataLibrary.Services.ApiService.FetchFromApiAsync<List<TeamScore>>($"/{gender}/teams/results");


        public static Task<List<System.Text.RegularExpressions.Group>?> GetGroupResultsAsync(string gender) =>
        DataLibrary.Services.ApiService.FetchFromApiAsync<List<System.Text.RegularExpressions.Group>>($"/{gender}/teams/group_results");

    }
}
