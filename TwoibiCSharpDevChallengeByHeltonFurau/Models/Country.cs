using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace TwoibiCSharpDevChallengeByHeltonFurau.Models
{
    public class Country
    {
        [JsonPropertyName("region")]
        public string Region { get; set; }
        [JsonPropertyName("subregion")]
        public string Subregion { get; set; }
        [JsonPropertyName("name")]
        public Name Name { get; set; }
        [JsonPropertyName("capital")]
        public string[]? Capital { get; set; }
        [JsonPropertyName("flags")]
        public Flags Flags { get; set; }
        [JsonPropertyName("borders")]
        public string[]? Borders { get; set; }
        [JsonPropertyName("population")]
        public int Population { get; set; }
        [JsonPropertyName("area")]
        public double Area { get; set; }
        [JsonPropertyName("maps")]
        public Maps Maps { get; set; }
        [JsonPropertyName("timezones")]
        public string[] Timezones { get; set; }

    }

    public class Name
    {
        [JsonPropertyName("common")]
        public string Common { get; set; }
        [JsonPropertyName("official")]
        public string Official { get; set; }

    }
    
    public class Flags
    {
        [JsonPropertyName("png")]
        public string Png { get; set; }
        [JsonPropertyName("svg")]
        public string Svg { get; set; }
    }

    public class Maps
    {
        [JsonPropertyName("googleMaps")]
        public string GoogleMaps { get; set; }
        [JsonPropertyName("openStreetMaps")]
        public string OpenStreetMaps { get; set; }
    }

}
