﻿namespace MSA.Phase2.Weatherman.Models
{
    public class Main
    {
        public int id { get; set; }
        public float temp { get; set; }
        public float feels_like { get; set; }
        public float temp_min { get; set; }
        public float temp_max { get; set; }

        public int WeatherInfoForeignKey { get; set; }
        public WeatherInfo WeatherInfo { get; set; }
    }

}
