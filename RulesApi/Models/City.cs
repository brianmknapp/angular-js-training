namespace RulesApi.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Coordinates Coord { get; set; }
        public string Country { get; set; }
        public int Population { get; set; }
        public Sys Sys { get; set; }
    }
}