using JsonObjects;
using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Sirius\job\3211_01.dbs_result.json";

            if(!File.Exists(path)) {
                Console.WriteLine("Файл не найден");
                return;
            }

            string jsonData = File.ReadAllText(path);

            var ob = JsonSerializer.Deserialize<RoutingResult>(jsonData);
            Console.WriteLine("Файл считан успешно");
        }
    }
}
