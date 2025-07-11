﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class Player
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("captain")]
        public bool Captain { get; set; }

        [JsonPropertyName("shirt_number")]
        public int? ShirtNumber { get; set; }

        [JsonPropertyName("position")]
        public string Position { get; set; } = string.Empty;

        public string? PicturePath { get; set; }
    }
}
