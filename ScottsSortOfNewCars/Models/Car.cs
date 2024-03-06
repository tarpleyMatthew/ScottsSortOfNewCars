using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace ScottsSortOfNewCars.Models
{
    public class Car
    {
        [JsonPropertyName("car")]
        public string? Name { get; set; }

        [JsonPropertyName("path")]
        public string? Path { get; set; }

        [JsonPropertyName("year")]
        public int? Year { get; set; }


        [JsonPropertyName("description")]
        public string? Description { get; set; }


        [JsonPropertyName("miles")]
        public int? Miles { get; set; }


        [JsonPropertyName("condition")]
        public string? Condition { get; set; }

    }
}
