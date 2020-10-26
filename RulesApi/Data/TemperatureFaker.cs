using System;
using AutoBogus;
using RulesApi.Models;

namespace RulesApi.Data
{
    public sealed class TemperatureFaker : AutoFaker<Temperature>
    {
        public TemperatureFaker(decimal day = decimal.Zero, decimal min = decimal.Zero, decimal max = decimal.Zero,
            decimal night = decimal.Zero, decimal eve = decimal.Zero, decimal morn = decimal.Zero)
        {
            RuleFor(fake => fake.Day, f => day == decimal.Zero ? f.Random.Decimal(227.594M, 324.817M) : day);
            RuleFor(fake => fake.Min, f => day == decimal.Zero ? f.Random.Decimal(227.594M, 324.817M) : min);
            RuleFor(fake => fake.Max, f => day == decimal.Zero ? f.Random.Decimal(227.594M, 324.817M) : max);
            RuleFor(fake => fake.Night, f => day == decimal.Zero ? f.Random.Decimal(227.594M, 324.817M) : night);
            RuleFor(fake => fake.Eve, f => day == decimal.Zero ? f.Random.Decimal(227.594M, 324.817M) : eve);
            RuleFor(fake => fake.Morn, f => day == decimal.Zero ? f.Random.Decimal(227.594M, 324.817M) : morn);

        }
    }
}