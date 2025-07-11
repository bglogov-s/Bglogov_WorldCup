﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class TeamStanding
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; } = string.Empty;

        [JsonPropertyName("alternate_name")]
        public string? AlternateName { get; set; }

        [JsonPropertyName("fifa_code")]
        public string FifaCode { get; set; } = string.Empty;

        [JsonPropertyName("group_id")]
        public int GroupId { get; set; }

        [JsonPropertyName("group_letter")]
        public string GroupLetter { get; set; } = string.Empty;

        [JsonPropertyName("wins")]
        public int Wins { get; set; }

        [JsonPropertyName("draws")]
        public int Draws { get; set; }

        [JsonPropertyName("losses")]
        public int Losses { get; set; }

        [JsonPropertyName("games_played")]
        public int GamesPlayed { get; set; }

        [JsonPropertyName("points")]
        public int Points { get; set; }

        [JsonPropertyName("goals_for")]
        public int GoalsFor { get; set; }

        [JsonPropertyName("goals_against")]
        public int GoalsAgainst { get; set; }

        [JsonPropertyName("goal_differential")]
        public int GoalDifferential { get; set; }
    }
}
