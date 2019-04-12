using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBot.Models
{
    public class LuisEntityModel
    {
        public string[] Weather_Location { get; set; }

    }

    public class WeatherLocationEntity
    {
        public int startIndex { get; set; }
        public int endIndex { get; set; }
        public string text { get; set; }
        public string type { get; set; }
        public float score { get; set; }

    }
}
