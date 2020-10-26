using System;
using AutoBogus;
using RulesApi.Models;

namespace RulesApi.Data
{
    public sealed class CoordinatesFaker : AutoFaker<Coordinates>
    {
        public CoordinatesFaker()
        {
            RuleFor(fake => fake.Lon, f => (decimal) f.Address.Longitude());
            RuleFor(fake => fake.Lat, f => (decimal) f.Address.Latitude());
        }
    }
}