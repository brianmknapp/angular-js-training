using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using AutoBogus;
using RulesApi.Models;

namespace RulesApi.Data
{
    public sealed class WeatherForecastFaker : AutoFaker<WeatherForecast>
    {
        public WeatherForecastFaker()
        {
            RuleFor(fake => fake.Dt, () => DateTime.UtcNow.Ticks);
            RuleFor(fake => fake.Temp, f => new TemperatureFaker().Generate());
            RuleFor(fake => fake.Pressure, f => f.Random.Decimal(982.05M, 1083.64M));
            RuleFor(fake => fake.Humidity, f => f.Random.Decimal(0M, 100M));
            RuleFor(fake => fake.Weather, f => new WeatherFaker().Generate(1));
            RuleFor(fake => fake.Speed, f => f.Random.Decimal(0M, 60M));
            RuleFor(fake => fake.Deg, f => f.Random.Decimal(227.594M, 324.817M));
            RuleFor(fake => fake.Clouds, f => f.Random.Decimal(0M, 100M));
            RuleFor(fake => fake.Rain, f => f.Random.Decimal(0M, 5M));

        }
    }
}