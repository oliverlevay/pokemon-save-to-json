using System;
using PokemonSaveToJson.Models;
using PokemonSaveToJson.Models.Enums;

namespace PokemonSaveToJson
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainerInformation totte = new TrainerInformation(Gender.Male, 13, true);

            string json = totte.ToJson();

            Console.WriteLine(json);

            string tottesKlon = json;

            TrainerInformation cloneBoi = TrainerInformation.FromJson(tottesKlon);

            Console.WriteLine(cloneBoi.ToJson());
        }
    }
}
