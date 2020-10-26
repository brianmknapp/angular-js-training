using System.Collections;
using System.Collections.Generic;
using AutoBogus;
using RulesApi.Models;

namespace RulesApi.Data
{
    public sealed class WeatherFaker : AutoFaker<Weather>
    {
        public WeatherFaker()
        {
            RuleFor(fake => fake.Id, f => f.IndexFaker);
            RuleFor(fake => fake.Main, f => f.PickRandom(MainOptions));
            RuleFor(fake => fake.Description, (f, w) => f.PickRandom(Descriptions[w.Main]));
            RuleFor(fake => fake.Icon, f => f.Image.LoremPixelUrl());
        }

        private static readonly IEnumerable<string> MainOptions = new List<string>
        {
            "Clouds", "Sun", "Rain", "Snow"
        };

        private static readonly IEnumerable<string> CloudsOptions = new List<string>
        {
            "overcast clouds",
            "scattered clouds",
            "partly cloudy"
        };

        private static readonly IEnumerable<string> SunOptions = new List<string>
        {
            "full sun",
            "mostly sunny",
            "partly sunny"
        };

        private static readonly IEnumerable<string> RainOptions = new List<string>
        {
            "mist",
            "drizzle",
            "light rain",
            "heavy rain",
            "thunderstorms",
            "hailstorms"
        };

        private static readonly IEnumerable<string> SnowOptions = new List<string>
        {
            "dusting",
            "coating",
            "light snow",
            "heavy snow",
            "blizzard",
            "white out",
            "snow wall"
        };

        private static readonly IDictionary<string, IEnumerable<string>> Descriptions =
            new Dictionary<string, IEnumerable<string>>
            {
                {"Clouds", CloudsOptions}, {"Sun", SunOptions}, {"Rain", RainOptions}, {"Snow", SnowOptions}
            };
    }
}