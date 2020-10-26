using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using AutoBogus;
using RulesApi.Models;

namespace RulesApi.Data
{
    public sealed class ForecastFaker : AutoFaker<Forecast>
    {
        public ForecastFaker(string city = null, int cnt = 2)
        {
            RuleFor(fake => fake.Cod, () => "200");
            RuleFor(fake => fake.Message, f => f.Random.Decimal(1000M));
            RuleFor(fake => fake.City, () => new CityFaker(name: city).Generate());
            RuleFor(fake => fake.Cnt, () => cnt);
            RuleFor(fake => fake.List, () => new WeatherForecastFaker().Generate(cnt));
        }
    }
}