using System;

namespace MapService
{
    internal class MapMetadata
    {
        public string MapName { get; set; }
        public string FileName { get; set; }
        public string PathToMap { get; set; }
        public double LatitudeMin { get; set; }
        public double LatitudeMax { get; set; }
        public double LongitudeMin { get; set; }
        public double LongitudeMax { get; set; }

        public double MapWidth
        {
            get
            {
                return Math.Abs(LatitudeMax - LatitudeMin);
            }
        }

        public double MapHeight
        {
            get
            {
                return Math.Abs(LongitudeMax - LongitudeMin);
            }
        }

        public bool IsCoordinatesOnMap(Coordinates coordinates)
        {
            if(coordinates.Latitude < LatitudeMin || coordinates.Latitude > LatitudeMax)
            {
                return false;
            }
            if(coordinates.Longitude < LongitudeMin || coordinates.Longitude > LongitudeMax)
            {
                return false;
            }

            return true;
        }
    }
}
