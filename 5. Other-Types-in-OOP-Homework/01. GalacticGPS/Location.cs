﻿namespace _01.GalacticGPS
{
    public struct Location
    {
        public Location(double latitude, double longitude, Planet planet) : this()
        {
           this.Latitude = latitude;
           this.Longitude = longitude;
           this.Planet = planet;
        }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Planet Planet { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}", Latitude, Longitude, Planet);
        }
    }
}
