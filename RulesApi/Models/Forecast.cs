using System.Collections.Generic;

namespace RulesApi.Models
{
    public class Forecast
    {
        public string Cod { get; set; }
        public decimal Message { get; set; }
        public City City { get; set; }
        public int Cnt { get; set; }
        public IList<WeatherForecast> List { get; set; }

    }
}