using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JSON_Prueba
{
    public class WeatherForecast
    {
        public DateTimeOffset date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string Summary { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            var weatherForecast = new WeatherForecast
            {
                date = DateTime.Parse("2024-02-09 "),
                TemperatureCelsius = 25,
                Summary = "Hot"
            };

            /*string jsonString = JsonSerializer.Serialize<WeatherForecast>(weatherForecast);
            Console.WriteLine(jsonString);*/

            string fileName = "WeatherForecast.json";
            //string jsonString = JsonSerializer.Serialize(weatherForecast);
            //File.WriteAllText(fileName, jsonString);
            string jsonString = File.ReadAllText(fileName);
            WeatherForecast weatherForecast1 = JsonSerializer.Deserialize<WeatherForecast>(jsonString);

            Console.WriteLine($"Date: {weatherForecast1.date}");
            Console.WriteLine($"TemperatureCelsius: {weatherForecast1.TemperatureCelsius}");
            Console.WriteLine($"Sumary: {weatherForecast1.Summary}");

            //Console.WriteLine(File.ReadAllText(fileName));

            Console.ReadKey();
        }
    }
}
