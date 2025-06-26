using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class Match
    {
        [JsonPropertyName("venue")]
        public string Venue { get; set; } = string.Empty;

        [JsonPropertyName("location")]
        public string Location { get; set; } = string.Empty;

        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;      // npr. "completed"

        [JsonPropertyName("time")]
        public string Time { get; set; } = string.Empty;        // npr. "full-time"

        [JsonPropertyName("fifa_id")]
        public string FifaId { get; set; } = string.Empty;

        [JsonPropertyName("weather")]
        public Weather Weather { get; set; } = new();

        [JsonPropertyName("attendance")]
        public string Attendance { get; set; } = string.Empty;

        [JsonPropertyName("officials")]
        public List<string> Officials { get; set; } = new();

        [JsonPropertyName("stage_name")]
        public string StageName { get; set; } = string.Empty;   // npr. "First stage"

        [JsonPropertyName("home_team_country")]
        public string HomeTeamCountry { get; set; } = string.Empty;

        [JsonPropertyName("away_team_country")]
        public string AwayTeamCountry { get; set; } = string.Empty;

        [JsonPropertyName("datetime")]
        public DateTime DateTime { get; set; }

        [JsonPropertyName("winner")]
        public string Winner { get; set; } = string.Empty;      // "Draw" ili zemlja

        [JsonPropertyName("winner_code")]
        public string WinnerCode { get; set; } = string.Empty;

        [JsonPropertyName("home_team")]
        public TeamScore HomeTeam { get; set; } = new();

        [JsonPropertyName("away_team")]
        public TeamScore AwayTeam { get; set; } = new();

        [JsonPropertyName("home_team_events")]
        public List<MatchEvent> HomeTeamEvents { get; set; } = new();

        [JsonPropertyName("away_team_events")]
        public List<MatchEvent> AwayTeamEvents { get; set; } = new();

        [JsonPropertyName("home_team_statistics")]
        public TeamStatistics HomeTeamStatistics { get; set; } = new();

        [JsonPropertyName("away_team_statistics")]
        public TeamStatistics AwayTeamStatistics { get; set; } = new();

        [JsonPropertyName("last_event_update_at")]
        public DateTime? LastEventUpdateAt { get; set; }

        [JsonPropertyName("last_score_update_at")]
        public DateTime? LastScoreUpdateAt { get; set; }
    }
}
