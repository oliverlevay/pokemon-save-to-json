using Newtonsoft.Json;

namespace PokemonSaveToJson.Models
{
    public static class Serialize
    {
        public static string ToJson(this TrainerInformation self) => JsonConvert.SerializeObject(self, new Newtonsoft.Json.Converters.StringEnumConverter());
    }
}