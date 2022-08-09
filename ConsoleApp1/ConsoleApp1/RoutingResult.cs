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
        public JobInfo Job { get; set; }

        public ResultInfo Results { get; set; }
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

    public class ResultInfo
    {
        [JsonProperty("partid")]
        public decimal Result { get; set; }

        [JsonProperty("route.length.no.contours")]
        public decimal RouteLengthNoContours { get; set; }

        [JsonProperty ("route.length")]
        public decimal RouteLength { get; set; }

        [JsonProperty ("count.time")]
        public string CountTime { get; set; }
        public List<RouteComponent> Toolpath { get; set; }
    }

    public class RouteComponent
    {
        [JsonProperty("point.id")]
        public int PointId { get; set; }
        public string Mode { get; set; }

        [JsonProperty("part.id")]
        public int? Part_Id { get; set; }

        public int? Id { get; set; }

        public string? PartId { get; set; }

        public Coord[] Point {get;set;}
    }


     public record Coord (decimal X, decimal Y, decimal Сurve);  

     
}
