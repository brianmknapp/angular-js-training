using System.Security.Cryptography.X509Certificates;
using AutoBogus;
using RulesApi.Models;

namespace RulesApi.Data
{
    public sealed class CityFaker : AutoFaker<City>
    {
        public CityFaker(string name = null, string country = null)
        {
            RuleFor(fake => fake.Id, f => f.IndexFaker);
            RuleFor(fake => fake.Name, f => name ?? f.Address.City());
            RuleFor(fake => fake.Coord, () => new CoordinatesFaker().Generate());
            RuleFor(fake => fake.Country, f => country ?? f.Address.Country());
            RuleFor(fake => fake.Population, f => f.Random.Int(1000));
            RuleFor(fake => fake.Sys, (f, c) => new Sys {Population = c.Population});
        }
    }
}