using System.Collections.Generic;

namespace RulesApi.Models
{
    public class WeatherForecast
    {
        public long Dt { get; set; }
        public Temperature Temp { get; set; }
        public decimal Pressure { get; set; }
        public decimal Humidity { get; set; }
        public IList<Weather> Weather { get; set; }
        public decimal Speed { get; set; }
        public decimal Deg { get; set; }
        public decimal Clouds { get; set; }
        public decimal Rain { get; set; }
    }
}