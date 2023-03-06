using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonObjects
{
    internal class RoutingResult
    {
        [JsonPropertyName("job")]
        public JobInfo Job { get; set; }

        [JsonPropertyName("results")]
        public ResultInfo Results { get; set; }
    }

    public class JobInfo
    {
        [JsonPropertyName("paths.count")]
        public int PathsCount { get; set; }

        [JsonPropertyName("parts.count")]
        public int PartsCount { get; set; }

        [JsonPropertyName("total.points.count")]
        public int TotalPointsСount { get; set; }

        [JsonPropertyName("total.address.pairs.count")]
        public int TotalAddressPairsCount { get; set; }

        [JsonPropertyName("list")]
        public List<double[]> List { get; set; } = new();
        public List<Path> Paths { get; set; } = new();
    }

     public class Path
    {
        [JsonPropertyName("part.id")]
        public int PartId { get; set; }
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("partid")]
        public string PartName { get; set; }
        //Попробую без JsonPropertyName
        public List<double[]> Points { get; set; } = new ();
    }

    public class ResultInfo
    {
        [JsonPropertyName("result")]
        public decimal Result { get; set; }

        [JsonPropertyName("route.length.no.contours")]
        public decimal RouteLengthNoContours { get; set; }

        [JsonPropertyName ("route.length")]
        public decimal RouteLength { get; set; }

        [JsonPropertyName ("count.time")]
        public string CountTime { get; set; }

        [JsonPropertyName("toolpath")]
        public List<RouteComponent> Toolpath { get; set; }
    }

    public class RouteComponent
    {
        [JsonPropertyName("point.id")]
        public int PointId { get; set; }

        [JsonPropertyName("mode")]
        public string Mode { get; set; }

        [JsonPropertyName("part.id")]
        public int? Part_Id { get; set; }

        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("partid")]
        public string? PartId { get; set; }

        [JsonPropertyName("point")]
        public double[] Point {get;set;}
    }


     public record Coord (decimal X, decimal Y, decimal Сurve);  

     
}
