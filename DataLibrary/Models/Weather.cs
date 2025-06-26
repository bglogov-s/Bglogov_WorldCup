using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class Weather
    {
        [JsonPropertyName("humidity")]
        public string Humidity { get; set; } = string.Empty;

        [JsonPropertyName("temp_celsius")]
        public string TempCelsius { get; set; } = string.Empty;

        [JsonPropertyName("temp_farenheit")]
        public string TempFahrenheit { get; set; } = string.Empty;

        [JsonPropertyName("wind_speed")]
        public string WindSpeed { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;
    }
}
