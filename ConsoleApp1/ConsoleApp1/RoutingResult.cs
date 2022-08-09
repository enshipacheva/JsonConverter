using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonObjects
{
    internal class RoutingResult
    {
        

    }

    public class JobInfo
    {
        [JsonProperty("paths.count")]
        public int PathsCount { get; set; }

        [JsonProperty("parts.count")]
        public int PartsCount { get; set; }

        [JsonProperty("total.points.count")]
        public int TotalPointsСount { get; set; }

        [JsonProperty("total.address.pairs.count")]
        public int TotalAddressPairsCount { get; set; }

        [JsonProperty("list")]
        public List<Coord[]> List { get; set; } = new();
        public List<Path> Paths { get; set; } = new();
    }

     public class Path
    {
        [JsonProperty("part.id")]
        public int PartId { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("partid")]
        public string PartName { get; set; }
        //Попробую без JsonProperty
        public List<Coord[]> Points { get; set; } = new ();
    }



     public record Coord (decimal X, decimal Y, decimal Сurve);  

     
}
