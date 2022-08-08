﻿using System.ComponentModel.DataAnnotations;

namespace MSA.Phase2.Weatherman.Models
{
    public class WeatherInfo
    {
        public int id {
            get { return id; }
            set
            {
                if (id > 0)
                {
                    this.id = id;
                }
            }
        }
        public string name { get; set; }
        public IEnumerable<Weather> Weather { get; set; } 
        public Main Main { get; set; }
        public int? visibility { get; set; }
        public int? dt { get; set; }
        public int? cod { get; set; }
    }

}
