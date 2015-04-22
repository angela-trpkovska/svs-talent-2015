using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example.Models
{
    public class BikeModel
    {
        public string RegNumber { get; set; }
        public string Producer { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public BikeModel(string RegNumber, string Producer, string Model, string Color)
        {
            this.RegNumber = RegNumber;
            this.Producer = Producer;
            this.Model = Model;
            this.Color = Color;


        }

    }
}