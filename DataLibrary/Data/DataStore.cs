using DataLibrary.Enums;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Group = DataLibrary.Models.Group;
using Match = DataLibrary.Models.Match;


namespace DataLibrary.Data
{
    public static class DataStore
    {
        public static List<Group> Groups { get; private set; } = new();
        public static List<Match> Matches { get; private set; } = new();
        public static List<MatchEvent> MatchEvents { get; private set; } = new();
        public static List<Player> Players { get; private set; } = new();
        public static List<Team> Teams { get; private set; } = new();
        public static List<TeamBasic> TeamBasics { get; private set; } = new();
        public static List<TeamScore> TeamScores { get; private set; } = new();
        public static List<TeamStanding> TeamStandings { get; private set; } = new();
        public static List<TeamStatistics> TeamStatistics { get; private set; } = new();
        public static List<Weather> WeatherData { get; private set; } = new();


        public static async Task LoadAllDataAsync(GenderCategory gender)
        {
            var folder = gender == GenderCategory.Male ? "jsonMen" : "jsonWomen";
            try
            {
                Groups = await LoadJsonAsync<Group>("DataLibrary/{folder}/groups.json");
                Matches = await LoadJsonAsync<Match>("DataLibrary/{folder}/matches.json");
                MatchEvents = await LoadJsonAsync<MatchEvent>("DataLibrary/{folder}/match_events.json");
                Players = await LoadJsonAsync<Player>("DataLibrary/{folder}/players.json");
                Teams = await LoadJsonAsync<Team>("DataLibrary/{folder}/teams.json");
                TeamBasics = await LoadJsonAsync<TeamBasic>("DataLibrary/{folder}/team_basics.json");
                TeamScores = await LoadJsonAsync<TeamScore>("DataLibrary/{folder}/team_scores.json");
                TeamStandings = await LoadJsonAsync<TeamStanding>("DataLibrary/{folder}/team_standings.json");
                TeamStatistics = await LoadJsonAsync<TeamStatistics>("DataLibrary/{folder}/team_statistics.json");
                WeatherData = await LoadJsonAsync<Weather>("DataLibrary/{folder}/weather.json");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static async Task<List<T>> LoadJsonAsync<T>(string path)
        {
            using var stream = File.OpenRead(path);
            var data = await JsonSerializer.DeserializeAsync<List<T>>(stream, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return data ?? new List<T>();
        }
    }
}
