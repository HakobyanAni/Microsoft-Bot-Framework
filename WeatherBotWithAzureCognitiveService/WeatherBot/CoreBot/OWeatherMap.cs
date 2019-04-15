using CoreBot.Models;
using Microsoft.Bot.Builder;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoreBot
{
    public class OWeatherMap
    {
        private const string appId = "b4b9bd6fea1717f9a328337f527cf69d";

        public async Task<string> GetWeatherData(string cityName)
        {
            try
            {
                using (HttpClient OWMHttpClient = new HttpClient())
                {
                    string weatherApi = $"https://api.openweathermap.org/data/2.5/weather?q=" + $"{cityName}" + $"&APPID=" + $"{appId}";
                    string response = await OWMHttpClient.GetStringAsync(new Uri(weatherApi));
                    WeatherObject owmResponde = JsonConvert.DeserializeObject<WeatherObject>(response);
                    if (owmResponde != null)
                    {
                        return GetWeatherResult(owmResponde);
                    }
                    return null;
                }
            }
            catch (Exception e)
            {
                var a = e;
                return null;
            }
        }

        public string GetWeatherResult(WeatherObject weatherData)
        {
            if (weatherData.ToString() == null)
            {
                return "There is nothing to show.";
            }

            string responseMessage = $"--> Weather in {weatherData.name}\n \n Coordinates: \n lat - {weatherData.coord.lat} \n lon - {weatherData.coord.lon}\n";

            if (weatherData.main != null)
            {
                responseMessage += $"description - {weatherData.weather[0].description}.\n";
            }

            double temp = Math.Round(weatherData.main.temp - 273.15, 1);
            double minTemp = Math.Round(weatherData.main.temp_min - 273.15, 1);
            double maxTemp = Math.Round(weatherData.main.temp_max - 273.15, 1);

            responseMessage += $"temperature - {temp} &#x2103; \n" 
                            + $"min temperature - {minTemp} &#x2103; \n"
                            + $"max temperature - {maxTemp} &#x2103; \n";

            if (weatherData.main != null)
            {
                responseMessage += $"air pressure - {weatherData.main.pressure}.\n";
            }
            if (weatherData.wind != null)
            {
                responseMessage += $"wind speed- {weatherData.wind.speed}.\n";
            }
            if (weatherData.main.humidity != 0)
            {
                responseMessage += $"humidity - {weatherData.main.humidity}.\n";
            }
            if (weatherData._base != null)
            {
                responseMessage += $"base - {weatherData._base}";
            }
            return responseMessage;
        }
    }
}
