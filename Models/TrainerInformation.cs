using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PokemonSaveToJson.Models.Enums;

namespace PokemonSaveToJson.Models
{
    public partial class TrainerInformation
    {
        [JsonProperty("gender")]
        public Gender Gender { get; set; }

        [JsonProperty("position")]
        public double Position { get; set; }

        [JsonProperty("gay")]
        public bool Gay { get; set; }

        public static TrainerInformation FromJson(string json) => JsonConvert.DeserializeObject<TrainerInformation>(json, new Newtonsoft.Json.Converters.StringEnumConverter());

        public TrainerInformation(Gender gender, double position, bool gay)
        {
            Gender = gender;
            Position = position;
            Gay = gay;
        }
    }
}
