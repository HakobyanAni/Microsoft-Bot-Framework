using CoreBot.Models;
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

        public async Task<WeatherObject> GetWeatherData(string cityName)
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
                        return owmResponde;
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

        //public async Task<WeatherForecastObject> GetForecastData(string cityName, DateTime dt)
        //{
        //    try
        //    {
        //        int days = (dt - DateTime.Now).Days;

        //        using (HttpClient OWMHttpClient = new HttpClient())
        //        {
        //            string countryCode = "";
        //            //string response = await OWMHttpClient.GetStringAsync(new Uri($"http://api.openweathermap.org/data/2.5/forecast/daily?q="+$"{cityName}" + "&appid=" + $"{appId}" + "&units=metric&lang=en&cnt={days}&lang={lang}"));
        //            string response = await OWMHttpClient.GetStringAsync(new Uri($"api.openweathermap.org/data/2.5/forecast?q={cityName},{countryCode}"));

        //            WeatherForecastObject owmResponde = JsonConvert.DeserializeObject<WeatherForecastObject>(response);
        //            if (owmResponde != null) return owmResponde;
        //        }

        //        return null;
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}
    }
}
